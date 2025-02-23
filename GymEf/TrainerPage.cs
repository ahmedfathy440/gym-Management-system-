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
    public partial class TrainerPage : Form
    {
        GymContext gymContext = new GymContext();
        public TrainerPage()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var trainer = gymContext.Trainers.Select(t => new
            {
                Id = t.TrainerID,
                Name = t.Name,
                Specialization = t.Specialization,
                Phone = t.Phone,
                Salary = t.Salary,
            }).ToList();
            dgv_trainer.DataSource = trainer;
            dgv_trainer.Columns["Id"].Visible = false;
            btn_add.Enabled = true;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }
        private void TrainerPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var gymTrainer = new Trainer()
            {
                Name = txt_name.Text,
                Specialization = txt_spec.Text,
                Phone = txt_phone.Text,
                Salary = nud_salary.Value,
            };

            gymContext.Trainers.Add(gymTrainer);
            gymContext.SaveChanges();
            MessageBox.Show("Data Inserted");
            LoadData();
        }
        int selectedId = 0;
        private void dgv_trainer_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_trainer.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);

                txt_name.Text = row.Cells["Name"].Value.ToString();
                txt_spec.Text = row.Cells["Specialization"].Value.ToString();
                txt_phone.Text = row.Cells["Phone"].Value.ToString();
                nud_salary.Value = Convert.ToInt32(row.Cells["Salary"].Value);
                
                btn_add.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a Trainer to Update");
                return;
            }
            var gymTrainer = gymContext.Trainers.FirstOrDefault(t => t.TrainerID == selectedId);

            if (gymTrainer != null)
            {
                gymTrainer.Name = txt_name.Text;
                gymTrainer.Specialization = txt_spec.Text;
                gymTrainer.Salary = (int)nud_salary.Value;
                gymTrainer.Phone = txt_phone.Text;

                gymContext.SaveChanges();
                MessageBox.Show("Data updated successfully");

                LoadData();

                txt_name.Text = "";
                txt_spec.Text = "";
                txt_phone.Text = "";
                nud_salary.Value = 1000;
            }
            else
            {
                MessageBox.Show("Trainer not found");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a Trainer to Delete");
                return;
            }
            var gymTrainer = gymContext.Trainers.FirstOrDefault(t => t.TrainerID == selectedId);

            if (gymTrainer != null)
            {
                var classes = gymContext.classes.Where(c => c.TrainerID == selectedId).ToList();

                foreach (var c in classes)
                {
                    c.TrainerID = 5;
                }

                gymContext.Trainers.Remove(gymTrainer);
                gymContext.SaveChanges();
                MessageBox.Show("Data Deleted successfully");

                LoadData();
                txt_name.Text = "";
                txt_spec.Text = "";
                txt_phone.Text = "";
                nud_salary.Value = 1000;
            }
            else
            {
                MessageBox.Show("Trainer not found");
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
