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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GymEf
{
    public partial class MemberInfo : Form
    {
        private int loggedMemberId;
        GymContext gymContext = new GymContext();

        public MemberInfo(int memberId)
        {
            InitializeComponent();
            loggedMemberId = memberId;
        }

        private void MemberInfo_Load(object sender, EventArgs e)
        {
            
            var member = gymContext.Members.Find(loggedMemberId);
            var remainingDays = (member.MembershipEndDate-DateTime.Today).Days;
            
            if (member != null)
            {
                lab_hi.Text = "Hi " + member.FullName + "\nDon't Sit \nGet fit";
                txt_name.Text = member.FullName;
                txt_email.Text = member.Email;
                txt_phone.Text = member.Phone;
                cb_class.DataSource = gymContext.classes.ToList();
                cb_class.DisplayMember = "ClassName";
                cb_class.ValueMember = "ClassId";
                cb_class.SelectedValue = member.ClassId;

                txt_oldpass.Visible = false;
                txt_newPass.Visible = false;
                txt_confirm.Visible = false;
                lab_new.Visible = false;
                lab_confirm.Visible = false;
                lab_old.Visible = false;

                txt_oldpass.Text = member.Password;
                MessageBox.Show($"You have {remainingDays+2} days remaining in your membership.",
                   "Membership Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_oldpass.Visible = true;
            txt_newPass.Visible = true;
            txt_confirm.Visible = true;
            lab_new.Visible = true;
            lab_confirm.Visible = true;
            lab_old.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gymMember = gymContext.Members.FirstOrDefault(m => m.MemberID == loggedMemberId);
            if (txt_newPass.Text != "" && txt_confirm.Text != "")
            {
                if (txt_newPass.Text == txt_confirm.Text )
                {
                    gymMember.Password = txt_newPass.Text;
                    gymContext.SaveChanges();
                    lab_check.Visible = false;
                    MessageBox.Show("Password updated successfully");
                    txt_oldpass.Text = "";
                    txt_newPass.Text = "";
                    txt_confirm.Text = "";
                }
                else
                {
                    lab_check.Visible = true;
                    lab_check.Text = "Password and confirm password should match";
                }
            }
            else
            {
                lab_check.Visible = true;
                lab_check.Text = "Password and confirm password shouldn't be empty";
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (txt_oldpass.PasswordChar == '*' && txt_newPass.PasswordChar == '*' && txt_confirm.PasswordChar == '*')
            {
                txt_newPass.PasswordChar = '\0';
                txt_oldpass.PasswordChar = '\0';
                txt_confirm.PasswordChar = '\0';
                btn_show.Text = "Hide";
            }
            else
            {
                txt_newPass.PasswordChar = '*';
                txt_oldpass.PasswordChar = '*';
                txt_confirm.PasswordChar = '*';
                btn_show.Text = "Show";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.IsNullOrEmpty() || txt_name.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Email and name Shouldn't be empty");
            }
            else
            {
                var gymMember = gymContext.Members.FirstOrDefault(m => m.MemberID == loggedMemberId);

                if (gymMember != null)
                {
                    gymMember.FullName = txt_name.Text;
                    gymMember.Phone = txt_phone.Text;
                    gymMember.Email = txt_email.Text;
                    gymMember.ClassId = (int)cb_class.SelectedValue;

                    gymContext.SaveChanges();
                    MessageBox.Show("Data updated successfully");
                }
                else
                {
                    MessageBox.Show("Trainer not found");
                }
            }
        }
    }
}

