namespace GymEf
{
    partial class ClassPage
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
            dgv_class = new DataGridView();
            txt_name = new TextBox();
            nud_capacity = new NumericUpDown();
            cb_trainer = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_add = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_back = new Button();
            cb_schedule = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_class).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_capacity).BeginInit();
            SuspendLayout();
            // 
            // dgv_class
            // 
            dgv_class.BackgroundColor = SystemColors.ControlLightLight;
            dgv_class.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_class.Location = new Point(448, 14);
            dgv_class.Name = "dgv_class";
            dgv_class.RowHeadersWidth = 51;
            dgv_class.Size = new Size(608, 518);
            dgv_class.TabIndex = 0;
            dgv_class.RowHeaderMouseDoubleClick += dgv_class_RowHeaderMouseDoubleClick;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 12F);
            txt_name.Location = new Point(155, 34);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(169, 34);
            txt_name.TabIndex = 1;
            // 
            // nud_capacity
            // 
            nud_capacity.Font = new Font("Segoe UI", 12F);
            nud_capacity.Location = new Point(155, 196);
            nud_capacity.Margin = new Padding(2);
            nud_capacity.Name = "nud_capacity";
            nud_capacity.Size = new Size(169, 34);
            nud_capacity.TabIndex = 3;
            // 
            // cb_trainer
            // 
            cb_trainer.Font = new Font("Segoe UI", 12F);
            cb_trainer.FormattingEnabled = true;
            cb_trainer.Location = new Point(155, 275);
            cb_trainer.Name = "cb_trainer";
            cb_trainer.Size = new Size(169, 36);
            cb_trainer.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(29, 38);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 5;
            label1.Text = "class name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(29, 117);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 6;
            label2.Text = "Schedule";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(29, 196);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 7;
            label3.Text = "Capacity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(29, 283);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 8;
            label4.Text = "Trainer";
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Transparent;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 12F);
            btn_add.ForeColor = SystemColors.Control;
            btn_add.Location = new Point(49, 372);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(115, 44);
            btn_add.TabIndex = 5;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Transparent;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 12F);
            btn_delete.ForeColor = SystemColors.Control;
            btn_delete.Location = new Point(249, 456);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(115, 44);
            btn_delete.TabIndex = 10;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Transparent;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 12F);
            btn_update.ForeColor = SystemColors.Control;
            btn_update.Location = new Point(249, 372);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(115, 44);
            btn_update.TabIndex = 11;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 12F);
            btn_back.ForeColor = SystemColors.Control;
            btn_back.Location = new Point(49, 456);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(115, 44);
            btn_back.TabIndex = 12;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // cb_schedule
            // 
            cb_schedule.Font = new Font("Segoe UI", 12F);
            cb_schedule.FormattingEnabled = true;
            cb_schedule.Location = new Point(155, 117);
            cb_schedule.Name = "cb_schedule";
            cb_schedule.Size = new Size(169, 36);
            cb_schedule.TabIndex = 2;
            // 
            // ClassPage
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1068, 544);
            Controls.Add(cb_schedule);
            Controls.Add(btn_back);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_trainer);
            Controls.Add(nud_capacity);
            Controls.Add(txt_name);
            Controls.Add(dgv_class);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClassPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClassPage";
            Load += ClassPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_class).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_capacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_class;
        private TextBox txt_name;
        private NumericUpDown nud_capacity;
        private ComboBox cb_trainer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_back;
        private ComboBox cb_schedule;
    }
}