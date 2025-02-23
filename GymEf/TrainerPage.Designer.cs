namespace GymEf
{
    partial class TrainerPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_trainer = new DataGridView();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_back = new Button();
            txt_name = new TextBox();
            txt_spec = new TextBox();
            txt_phone = new TextBox();
            nud_salary = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_trainer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_salary).BeginInit();
            SuspendLayout();
            // 
            // dgv_trainer
            // 
            dgv_trainer.BackgroundColor = SystemColors.ControlLightLight;
            dgv_trainer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_trainer.Location = new Point(454, 12);
            dgv_trainer.Name = "dgv_trainer";
            dgv_trainer.RowHeadersWidth = 51;
            dgv_trainer.Size = new Size(632, 520);
            dgv_trainer.TabIndex = 0;
            dgv_trainer.RowHeaderMouseDoubleClick += dgv_trainer_RowHeaderMouseDoubleClick;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Transparent;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn_add.ForeColor = SystemColors.Control;
            btn_add.Location = new Point(39, 377);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(148, 55);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Transparent;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn_update.ForeColor = SystemColors.Control;
            btn_update.Location = new Point(261, 377);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(148, 55);
            btn_update.TabIndex = 2;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Transparent;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn_delete.ForeColor = SystemColors.Control;
            btn_delete.Location = new Point(261, 464);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(148, 55);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_back
            // 
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn_back.ForeColor = SystemColors.Control;
            btn_back.Location = new Point(39, 464);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(148, 55);
            btn_back.TabIndex = 4;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 12F);
            txt_name.Location = new Point(221, 47);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(165, 34);
            txt_name.TabIndex = 5;
            // 
            // txt_spec
            // 
            txt_spec.Font = new Font("Segoe UI", 12F);
            txt_spec.Location = new Point(221, 137);
            txt_spec.Name = "txt_spec";
            txt_spec.Size = new Size(165, 34);
            txt_spec.TabIndex = 6;
            // 
            // txt_phone
            // 
            txt_phone.Font = new Font("Segoe UI", 12F);
            txt_phone.Location = new Point(221, 207);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(165, 34);
            txt_phone.TabIndex = 7;
            // 
            // nud_salary
            // 
            nud_salary.Font = new Font("Segoe UI", 12F);
            nud_salary.Location = new Point(221, 284);
            nud_salary.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nud_salary.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_salary.Name = "nud_salary";
            nud_salary.Size = new Size(165, 34);
            nud_salary.TabIndex = 8;
            nud_salary.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(39, 53);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 9;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(38, 284);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 10;
            label2.Text = "Salary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(39, 213);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 11;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(38, 137);
            label4.Name = "label4";
            label4.Size = new Size(133, 28);
            label4.TabIndex = 12;
            label4.Text = "Specialization";
            // 
            // TrainerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1098, 544);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nud_salary);
            Controls.Add(txt_phone);
            Controls.Add(txt_spec);
            Controls.Add(txt_name);
            Controls.Add(btn_back);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(dgv_trainer);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TrainerPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrainerPage";
            Load += TrainerPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_trainer).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_salary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_trainer;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_back;
        private TextBox txt_name;
        private TextBox txt_spec;
        private TextBox txt_phone;
        private NumericUpDown nud_salary;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}