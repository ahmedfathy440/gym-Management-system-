using GymEf.Models;
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
    public partial class ClassPage : Form
    {
        GymContext gymContext = new GymContext();
        public ClassPage()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            var gymClass = gymContext.classes.Select(c => new
            {
                ClassID = c.ClassID,
                ClassName = c.ClassName,
                Schedule = c.Schedule,
                Capacity = c.MaxCapacity,
                Trainer = c.Trainer.Name
            }).ToList();

            dgv_class.DataSource = gymClass;
            dgv_class.Columns["ClassID"].Visible = false;
            
            btn_add.Enabled = true;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }
        private void ClassPage_Load(object sender, EventArgs e)
        {
            LoadData();
            cb_trainer.DataSource = gymContext.Trainers.ToList();
            cb_trainer.DisplayMember = "name";
            cb_trainer.ValueMember = "TrainerID";
            cb_schedule.Items.Add("12pm:2pm");
            cb_schedule.Items.Add("2pm:4pm");
            cb_schedule.Items.Add("4pm:6pm");
            cb_schedule.Items.Add("6pm:8pm");
            cb_schedule.Items.Add("8pm:10pm");
            cb_schedule.SelectedIndex = 0;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            var gymClass = new Class()
            {
                ClassName = txt_name.Text,
                Schedule = cb_schedule.Text,
                MaxCapacity = (int)nud_capacity.Value,
                TrainerID = (int)cb_trainer.SelectedValue,
            };

            gymContext.classes.Add(gymClass);
            gymContext.SaveChanges();
            MessageBox.Show("Data Inserted");
            LoadData();
        }
        int selecctedId = 0;
        private void dgv_class_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_class.Rows[e.RowIndex];
                selecctedId = Convert.ToInt32(row.Cells["ClassId"].Value);

                txt_name.Text = row.Cells["ClassName"].Value.ToString();
                cb_schedule.Text = row.Cells["Schedule"].Value.ToString();
                nud_capacity.Value = Convert.ToInt32(row.Cells["Capacity"].Value);
                string trainer = row.Cells["Trainer"].Value.ToString();
                int index = cb_trainer.FindStringExact(trainer);
                if (index >= 0)
                {
                    cb_trainer.SelectedIndex = index;
                }

                btn_add.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selecctedId == 0)
            {
                MessageBox.Show("Please select a class to Update");
                return;
            }
            var gymClass = gymContext.classes.FirstOrDefault(c => c.ClassID == selecctedId);

            if (gymClass != null)
            {
                gymClass.ClassName = txt_name.Text;
                gymClass.Schedule = cb_schedule.Text;
                gymClass.TrainerID = (int)cb_trainer.SelectedValue;
                gymClass.MaxCapacity = (int)nud_capacity.Value;

                gymContext.SaveChanges();
                MessageBox.Show("Data updated successfully");

                LoadData();

                txt_name.Text = "";
                cb_schedule.SelectedIndex = 0;
                nud_capacity.Value = 0;
            }
            else
            {
                MessageBox.Show("Class not found");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selecctedId == 0)
            {
                MessageBox.Show("Please select a class to Delete");
                return;
            }
            var gymClass = gymContext.classes.FirstOrDefault(c => c.ClassID == selecctedId);

            if (gymClass != null)
            {
                var members = gymContext.Members.Where(m => m.ClassId == selecctedId).ToList();

                foreach (var member in members)
                {
                    member.ClassId = 6;
                }
                gymContext.classes.Remove(gymClass);
                gymContext.SaveChanges();
                MessageBox.Show("Data Deleted successfully");

                LoadData();
                txt_name.Text = "";
                cb_schedule.SelectedIndex= 0;
                nud_capacity.Value = 0;
            }
            else
            {
                MessageBox.Show("Class not found");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}
