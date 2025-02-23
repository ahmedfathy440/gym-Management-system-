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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_class_Click(object sender, EventArgs e)
        {
            ClassPage classPage = new ClassPage();
            classPage.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrainerPage trainerPage = new TrainerPage();
            trainerPage.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemberPage memberPage = new MemberPage();
            memberPage.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaymentPage paymentPage = new PaymentPage();
            paymentPage.Show();
            this.Close();
        }
    }
}
