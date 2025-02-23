using GymEf.Models;
using Microsoft.IdentityModel.Tokens;

namespace GymEf
{
    public partial class Login : Form
    {
        GymContext gymDb = new GymContext();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text.IsNullOrEmpty() || txt_username.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Missing Data");
                return;
            }

            
            using (var gymDb = new GymContext()) 
            {

                var employee = gymDb.Employees
                    .FirstOrDefault(s => s.Name == txt_username.Text && s.Password == txt_pass.Text);

                if (employee != null)
                {
                    MessageBox.Show("Welcome Employee!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm main = new MainForm();
                    main.Show();
                    return;
                }

                var member = gymDb.Members
                    .FirstOrDefault(m => m.Email == txt_username.Text && m.Password == txt_pass.Text);

                if (member != null )
                {
                    bool isPaid = gymDb.Payments.Any(p => p.memberId == member.MemberID);
                    if (!isPaid)
                    {
                        MessageBox.Show("Please Pay for MemberShip and try Login Later",
                              "Membership Expired",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (member.MembershipEndDate < DateTime.Today)
                    {
                        MessageBox.Show("Your membership has expired. Please renew to access your account.",
                                        "Membership Expired",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    MessageBox.Show("Welcome Member!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MemberInfo profile = new MemberInfo(member.MemberID);
                    profile.Show();
                    return;

                }
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_pass.Text = "";
        }

        private void cb_show_CheckedChanged(object sender, EventArgs e)
        {
            if(txt_pass.PasswordChar == '*')
            {
                txt_pass.PasswordChar = '\0';
                cb_show.Text = "Hide Password";
            }
            else
            {
                txt_pass.PasswordChar = '*';
                cb_show.Text = "Show Password";
            }
        }
    }
}
