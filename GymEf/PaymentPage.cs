using GymEf.Migrations;
using GymEf.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymEf
{
    public partial class PaymentPage : Form
    {
        GymContext gymContext = new GymContext();
        public PaymentPage()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
        private void LoadData()
        {
            var payment = gymContext.Payments.Select(p => new
            {
                Id = p.PaymentID,
                Member = p.member.FullName,
                PaymentDate = p.PaymentDate,
                EndedDate = p.payEndDate,
                Amount = p.Amount,
            }).ToList();

            dgv_payment.DataSource = payment;
            dgv_payment.Columns["Id"].Visible = false;
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
        }

        private void PaymentPage_Load(object sender, EventArgs e)
        {
            LoadData();
            cb_member.DataSource = gymContext.Members.ToList();
            cb_member.DisplayMember = "FullName";
            cb_member.ValueMember = "MemberId";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var member = gymContext.Members.Include(m => m.MembershipType).FirstOrDefault(m => m.MemberID == (int)cb_member.SelectedValue);

            if (member != null)
            {
                DateTime newEndDate = member.MembershipEndDate;
                if (member.MembershipType != null)
                {
                    if (member.MembershipType.TypeName == "monthly")
                    {
                        newEndDate = dtp_date.Value.AddMonths(1);
                        
                    }
                    else if (member.MembershipType.TypeName == "Yearly")
                    {
                        newEndDate = dtp_date.Value.AddYears(1);
                    
                    }
                }
                var payment = new Payment()
                {
                    Amount = nud_amount.Value,
                    PaymentDate = dtp_date.Value,
                    memberId = (int)cb_member.SelectedValue,
                    payEndDate = newEndDate,
                };

                gymContext.Payments.Add(payment);
                member.MembershipEndDate = newEndDate;
                gymContext.SaveChanges();
                MessageBox.Show("Data Inserted");
                LoadData();
            }
            else
            {
                MessageBox.Show("Member not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        int selectedId = 0;
        private void dgv_payment_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_payment.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);

                nud_amount.Value =Convert.ToInt32(row.Cells["Amount"].Value);
                dtp_date.Value = Convert.ToDateTime(row.Cells["PaymentDate"].Value);

                string member = row.Cells["Member"].Value.ToString();
                int index = cb_member.FindStringExact(member);
                if (index >= 0)
                {
                    cb_member.SelectedIndex = index;
                }

                btn_add.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a Payment to Update");
                return;
            }
            var member = gymContext.Members.Include(m => m.MembershipType).FirstOrDefault(m => m.MemberID == (int)cb_member.SelectedValue);

            if (member != null)
            {
                DateTime newEndDate = member.MembershipEndDate;
                if (member.MembershipType != null)
                {
                    if (member.MembershipType.TypeName == "monthly")
                    {
                        newEndDate = dtp_date.Value.AddMonths(1);
                    }
                    else if (member.MembershipType.TypeName == "Yearly")
                    {
                        newEndDate = dtp_date.Value.AddYears(1);
                    }
                }
                var gymPayment = gymContext.Payments.FirstOrDefault(p => p.PaymentID == selectedId);

                if (gymPayment != null)
                {
                    gymPayment.Amount = nud_amount.Value;
                    gymPayment.PaymentDate = dtp_date.Value;
                    gymPayment.memberId = (int)cb_member.SelectedValue;
                    gymPayment.payEndDate = newEndDate;

                    member.MembershipEndDate = newEndDate;
                    gymContext.SaveChanges();
                    MessageBox.Show("Data updated successfully");

                    LoadData();

                    nud_amount.Value = 200;
                    dtp_date.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("payment not found");
                }
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a Payment to Delete");
                return;
            }
            var gymPayment = gymContext.Payments.FirstOrDefault(p => p.PaymentID == selectedId);

            if (gymPayment != null)
            {

                gymContext.Payments.Remove(gymPayment);
                gymContext.SaveChanges();
                MessageBox.Show("Data Deleted successfully");

                LoadData();

                nud_amount.Value = 200;
                dtp_date.Value = DateTime.Now;

            }
            else
            {
                MessageBox.Show("Payment not found");
            }
        }
    }
}
