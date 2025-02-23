namespace GymEf
{
    partial class MemberPage
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
            dgv_member = new DataGridView();
            txt_name = new TextBox();
            txt_phone = new TextBox();
            txt_email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtp_date = new DateTimePicker();
            cb_membership = new ComboBox();
            cb_class = new ComboBox();
            btn_add = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_back = new Button();
            cb_gender = new ComboBox();
            label7 = new Label();
            txt_pass = new TextBox();
            label8 = new Label();
            txt_search = new TextBox();
            btn_clear = new Button();
            btn_search = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_member).BeginInit();
            SuspendLayout();
            // 
            // dgv_member
            // 
            dgv_member.BackgroundColor = SystemColors.ControlLightLight;
            dgv_member.BorderStyle = BorderStyle.None;
            dgv_member.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgv_member.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_member.Location = new Point(575, 78);
            dgv_member.Name = "dgv_member";
            dgv_member.RowHeadersWidth = 51;
            dgv_member.Size = new Size(742, 404);
            dgv_member.TabIndex = 0;
            dgv_member.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 10.8F);
            txt_name.Location = new Point(119, 19);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(136, 31);
            txt_name.TabIndex = 1;
            // 
            // txt_phone
            // 
            txt_phone.Font = new Font("Segoe UI", 10.8F);
            txt_phone.Location = new Point(119, 162);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(136, 31);
            txt_phone.TabIndex = 3;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 10.8F);
            txt_email.Location = new Point(119, 91);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(136, 31);
            txt_email.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(270, 241);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 7;
            label2.Text = "Class";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(270, 162);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 8;
            label3.Text = "MemberShip";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(270, 97);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 9;
            label4.Text = "JoinDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(16, 165);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 10;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(16, 94);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 11;
            label6.Text = "Email";
            // 
            // dtp_date
            // 
            dtp_date.CustomFormat = "dd MMM yyyy";
            dtp_date.Font = new Font("Segoe UI", 10.8F);
            dtp_date.Format = DateTimePickerFormat.Custom;
            dtp_date.Location = new Point(404, 91);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new Size(149, 31);
            dtp_date.TabIndex = 5;
            dtp_date.Value = new DateTime(2025, 2, 21, 21, 7, 31, 0);
            // 
            // cb_membership
            // 
            cb_membership.Font = new Font("Segoe UI", 10.8F);
            cb_membership.FormattingEnabled = true;
            cb_membership.Location = new Point(404, 162);
            cb_membership.Name = "cb_membership";
            cb_membership.Size = new Size(149, 33);
            cb_membership.TabIndex = 6;
            // 
            // cb_class
            // 
            cb_class.Font = new Font("Segoe UI", 10.8F);
            cb_class.FormattingEnabled = true;
            cb_class.Location = new Point(404, 241);
            cb_class.Name = "cb_class";
            cb_class.Size = new Size(149, 33);
            cb_class.TabIndex = 7;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Transparent;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 13.8F);
            btn_add.ForeColor = SystemColors.Control;
            btn_add.Location = new Point(68, 330);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(153, 43);
            btn_add.TabIndex = 12;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Transparent;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 13.8F);
            btn_delete.ForeColor = SystemColors.Control;
            btn_delete.Location = new Point(334, 408);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(153, 43);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Transparent;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 13.8F);
            btn_update.ForeColor = SystemColors.Control;
            btn_update.Location = new Point(334, 330);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(153, 47);
            btn_update.TabIndex = 14;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_back
            // 
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 13.8F);
            btn_back.ForeColor = SystemColors.Control;
            btn_back.Location = new Point(68, 408);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(153, 43);
            btn_back.TabIndex = 15;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += button4_Click;
            // 
            // cb_gender
            // 
            cb_gender.DisplayMember = "0";
            cb_gender.Font = new Font("Segoe UI", 10.8F);
            cb_gender.FormattingEnabled = true;
            cb_gender.Location = new Point(119, 241);
            cb_gender.Name = "cb_gender";
            cb_gender.Size = new Size(136, 33);
            cb_gender.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(16, 244);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 17;
            label7.Text = "Gender";
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 10.8F);
            txt_pass.Location = new Point(404, 19);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(149, 31);
            txt_pass.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(270, 25);
            label8.Name = "label8";
            label8.Size = new Size(87, 25);
            label8.TabIndex = 19;
            label8.Text = "Password";
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI", 10.8F);
            txt_search.Location = new Point(641, 25);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(163, 31);
            txt_search.TabIndex = 20;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Transparent;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Segoe UI", 13.8F);
            btn_clear.ForeColor = SystemColors.Control;
            btn_clear.Location = new Point(1053, 19);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(132, 40);
            btn_clear.TabIndex = 21;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.Transparent;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 13.8F);
            btn_search.ForeColor = SystemColors.Control;
            btn_search.Location = new Point(869, 19);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(132, 40);
            btn_search.TabIndex = 22;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // MemberPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1324, 500);
            Controls.Add(btn_search);
            Controls.Add(btn_clear);
            Controls.Add(txt_search);
            Controls.Add(label8);
            Controls.Add(txt_pass);
            Controls.Add(label7);
            Controls.Add(cb_gender);
            Controls.Add(btn_back);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(cb_class);
            Controls.Add(cb_membership);
            Controls.Add(dtp_date);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_email);
            Controls.Add(txt_phone);
            Controls.Add(txt_name);
            Controls.Add(dgv_member);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MemberPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberPage";
            Load += MemberPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_member).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_member;
        private TextBox txt_name;
        private TextBox txt_phone;
        private TextBox txt_email;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtp_date;
        private ComboBox cb_membership;
        private ComboBox cb_class;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_back;
        private ComboBox cb_gender;
        private Label label7;
        private TextBox txt_pass;
        private Label label8;
        private TextBox txt_search;
        private Button btn_clear;
        private Button btn_search;
    }
}