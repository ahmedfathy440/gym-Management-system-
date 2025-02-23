using GymEf.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymEf
{
    public partial class MemberPage : Form
    {
        GymContext gymContext = new GymContext();
        public MemberPage()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            var member = gymContext.Members.Select(m => new
            {
                Id = m.MemberID,
                Name = m.FullName,
                Email = m.Email,
                Password = m.Password,
                Phone = m.Phone,
                Gender = m.Gender,
                JoinDate = m.JoinDate,
                MemberShip = m.MembershipType.TypeName,
                Class = m.Class.ClassName,
            }).ToList();

            dgv_member.DataSource = member;
            dgv_member.Columns["Id"].Visible = false;
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            cb_gender.Items.Add("Male");
            cb_gender.Items.Add("Female");
            cb_gender.SelectedIndex = 0;

        }
        private void MemberPage_Load(object sender, EventArgs e)
        {
            LoadData();
            cb_membership.DataSource = gymContext.membershipTypes.ToList();
            cb_membership.DisplayMember = "TypeName";
            cb_membership.ValueMember = "MembershipTypeID";

            cb_class.DataSource = gymContext.classes.ToList();
            cb_class.DisplayMember = "ClassName";
            cb_class.ValueMember = "ClassId";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.IsNullOrEmpty() || txt_pass.Text.IsNullOrEmpty() || txt_name.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Email and password Shouldn't be empty");
            }
            else
            {
                var member = new Member()
                {
                    FullName = txt_name.Text,
                    Email = txt_email.Text,
                    Password = txt_pass.Text,
                    Phone = txt_phone.Text,
                    JoinDate = dtp_date.Value,
                    MembershipTypeID = (int)cb_membership.SelectedValue,
                    ClassId = (int)cb_class.SelectedValue,
                    Gender = cb_gender.Text,
                };

                gymContext.Members.Add(member);
                gymContext.SaveChanges();
                MessageBox.Show("Data inserted");
                LoadData();
            }

        }
        int selectedId = 0;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_member.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);

                txt_name.Text = row.Cells["Name"].Value.ToString();
                txt_email.Text = row.Cells["Email"].Value.ToString();
                txt_phone.Text = row.Cells["Phone"].Value.ToString();
                txt_pass.Text = row.Cells["Password"].Value.ToString();
                dtp_date.Value = Convert.ToDateTime(row.Cells["JoinDate"].Value);
                string memberGender = row.Cells["Gender"].Value.ToString();
                int index1 = cb_gender.FindStringExact(memberGender);
                if (index1 >= 0)
                {
                    cb_gender.SelectedIndex = index1;
                }
                string memberClass = row.Cells["Class"].Value.ToString();
                if (memberClass.IsNullOrEmpty())
                {
                    cb_class.SelectedIndex = 0;
                }
                else
                {
                    int index2 = cb_class.FindStringExact(memberClass);
                    if (index2 >= 0)
                    {
                        cb_class.SelectedIndex = index2;
                    }
                }
                string MemberShip = row.Cells["MemberShip"].Value.ToString();
                int index3 = cb_membership.FindStringExact(MemberShip);
                if (index3 >= 0)
                {
                    cb_membership.SelectedIndex = index3;
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
                MessageBox.Show("Please select a Member to Update");
                return;
            }
            var gymMember = gymContext.Members.FirstOrDefault(m => m.MemberID == selectedId);
            if (txt_email.Text.IsNullOrEmpty() || txt_pass.Text.IsNullOrEmpty() || txt_name.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Email and password Shouldn't be empty");
            }
            else
            {
                if (gymMember != null)
                {
                    gymMember.FullName = txt_name.Text;
                    gymMember.Email = txt_email.Text;
                    gymMember.Phone = txt_phone.Text;
                    gymMember.ClassId = (int)cb_class.SelectedValue;
                    gymMember.MembershipTypeID = (int)cb_membership.SelectedValue;
                    gymMember.JoinDate = dtp_date.Value;
                    gymMember.Gender = cb_gender.Text;
                    gymMember.Password = txt_pass.Text;

                    gymContext.SaveChanges();
                    MessageBox.Show("Data updated successfully");

                    LoadData();

                    txt_name.Text = "";
                    txt_email.Text = "";
                    txt_phone.Text = "";
                    txt_pass.Text = "";
                    dtp_date.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Member not found");
                }
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a Member to Delete");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this member?",
                                             "Confirm Deletion",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var gymMember = gymContext.Members.FirstOrDefault(m => m.MemberID == selectedId);
                var gymPayment = gymContext.Payments.Where(p => p.memberId == selectedId).ToList();


                if (gymMember != null)
                {
                    gymContext.Members.Remove(gymMember);
                    gymContext.Payments.RemoveRange(gymPayment);
                    gymContext.SaveChanges();
                    MessageBox.Show("Data Deleted successfully");

                    LoadData();
                    txt_name.Text = "";
                    txt_email.Text = "";
                    txt_phone.Text = "";
                    dtp_date.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Member not found");
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var searchText = txt_search.Text.ToLower();
            var member = gymContext.Members.Where(m => m.FullName.ToLower().StartsWith(searchText)).Select(m => new
            {
                Name = m.FullName,
                Email = m.Email,
                Password = m.Password,
                Phone = m.Phone,
                Gender = m.Gender,
                JoinDate = m.JoinDate,
                MemberShip = m.MembershipType.TypeName,
                Class = m.Class.ClassName,
            }).ToList();

            dgv_member.DataSource = member;

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            LoadData();
        }
    }
}
