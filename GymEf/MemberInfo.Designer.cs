namespace GymEf
{
    partial class MemberInfo
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
            txt_name = new TextBox();
            txt_phone = new TextBox();
            txt_oldpass = new TextBox();
            txt_email = new TextBox();
            cb_class = new ComboBox();
            label1 = new Label();
            lab_old = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txt_confirm = new TextBox();
            txt_newPass = new TextBox();
            lab_confirm = new Label();
            lab_new = new Label();
            button4 = new Button();
            btn_show = new Button();
            lab_check = new Label();
            lab_hi = new Label();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(754, 25);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(170, 34);
            txt_name.TabIndex = 1;
            // 
            // txt_phone
            // 
            txt_phone.Font = new Font("Segoe UI", 12F);
            txt_phone.Location = new Point(754, 148);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(170, 34);
            txt_phone.TabIndex = 3;
            // 
            // txt_oldpass
            // 
            txt_oldpass.Font = new Font("Segoe UI", 12F);
            txt_oldpass.Location = new Point(442, 88);
            txt_oldpass.Name = "txt_oldpass";
            txt_oldpass.PasswordChar = '*';
            txt_oldpass.Size = new Size(162, 34);
            txt_oldpass.TabIndex = 7;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 12F);
            txt_email.Location = new Point(754, 88);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(170, 34);
            txt_email.TabIndex = 2;
            // 
            // cb_class
            // 
            cb_class.Font = new Font("Segoe UI", 12F);
            cb_class.FormattingEnabled = true;
            cb_class.Location = new Point(754, 209);
            cb_class.Name = "cb_class";
            cb_class.Size = new Size(170, 36);
            cb_class.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(651, 25);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // lab_old
            // 
            lab_old.AutoSize = true;
            lab_old.Font = new Font("Segoe UI", 13.8F);
            lab_old.ForeColor = SystemColors.Control;
            lab_old.Location = new Point(281, 88);
            lab_old.Name = "lab_old";
            lab_old.Size = new Size(101, 31);
            lab_old.TabIndex = 7;
            lab_old.Text = "Old Pass";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(656, 206);
            label3.Name = "label3";
            label3.Size = new Size(66, 31);
            label3.TabIndex = 8;
            label3.Text = "Class";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(656, 148);
            label5.Name = "label5";
            label5.Size = new Size(78, 31);
            label5.TabIndex = 10;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(656, 84);
            label6.Name = "label6";
            label6.Size = new Size(70, 31);
            label6.TabIndex = 11;
            label6.Text = "Email";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(328, 270);
            button1.Name = "button1";
            button1.Size = new Size(104, 29);
            button1.TabIndex = 11;
            button1.Text = "Save ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(561, 345);
            button2.Name = "button2";
            button2.Size = new Size(195, 76);
            button2.TabIndex = 12;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(59, 345);
            button3.Name = "button3";
            button3.Size = new Size(195, 76);
            button3.TabIndex = 13;
            button3.Text = "Log out";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txt_confirm
            // 
            txt_confirm.Font = new Font("Segoe UI", 12F);
            txt_confirm.Location = new Point(442, 206);
            txt_confirm.Name = "txt_confirm";
            txt_confirm.PasswordChar = '*';
            txt_confirm.Size = new Size(162, 34);
            txt_confirm.TabIndex = 9;
            // 
            // txt_newPass
            // 
            txt_newPass.Font = new Font("Segoe UI", 12F);
            txt_newPass.Location = new Point(442, 144);
            txt_newPass.Name = "txt_newPass";
            txt_newPass.PasswordChar = '*';
            txt_newPass.Size = new Size(162, 34);
            txt_newPass.TabIndex = 8;
            // 
            // lab_confirm
            // 
            lab_confirm.AutoSize = true;
            lab_confirm.Font = new Font("Segoe UI", 13.8F);
            lab_confirm.ForeColor = SystemColors.Control;
            lab_confirm.Location = new Point(281, 203);
            lab_confirm.Name = "lab_confirm";
            lab_confirm.Size = new Size(145, 31);
            lab_confirm.TabIndex = 18;
            lab_confirm.Text = "Confirm Pass";
            // 
            // lab_new
            // 
            lab_new.AutoSize = true;
            lab_new.Font = new Font("Segoe UI", 13.8F);
            lab_new.ForeColor = SystemColors.Control;
            lab_new.Location = new Point(281, 148);
            lab_new.Name = "lab_new";
            lab_new.Size = new Size(110, 31);
            lab_new.TabIndex = 19;
            lab_new.Text = "New Pass";
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(328, 13);
            button4.Name = "button4";
            button4.Size = new Size(244, 43);
            button4.TabIndex = 5;
            button4.Text = "Change Password";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btn_show
            // 
            btn_show.BackColor = Color.Black;
            btn_show.FlatStyle = FlatStyle.Flat;
            btn_show.ForeColor = SystemColors.Control;
            btn_show.Location = new Point(529, 270);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(88, 29);
            btn_show.TabIndex = 10;
            btn_show.Text = "Show";
            btn_show.UseVisualStyleBackColor = false;
            btn_show.Click += btn_show_Click;
            // 
            // lab_check
            // 
            lab_check.AutoSize = true;
            lab_check.ForeColor = Color.Red;
            lab_check.Location = new Point(432, 243);
            lab_check.Name = "lab_check";
            lab_check.Size = new Size(38, 20);
            lab_check.TabIndex = 20;
            lab_check.Text = "labe";
            lab_check.Visible = false;
            // 
            // lab_hi
            // 
            lab_hi.AutoSize = true;
            lab_hi.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_hi.ForeColor = SystemColors.Control;
            lab_hi.Location = new Point(12, 9);
            lab_hi.Name = "lab_hi";
            lab_hi.Size = new Size(84, 60);
            lab_hi.TabIndex = 21;
            lab_hi.Text = "Hi ";
            // 
            // MemberInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(954, 450);
            Controls.Add(lab_hi);
            Controls.Add(lab_check);
            Controls.Add(btn_show);
            Controls.Add(button4);
            Controls.Add(lab_new);
            Controls.Add(lab_confirm);
            Controls.Add(txt_newPass);
            Controls.Add(txt_confirm);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(lab_old);
            Controls.Add(label1);
            Controls.Add(cb_class);
            Controls.Add(txt_email);
            Controls.Add(txt_oldpass);
            Controls.Add(txt_phone);
            Controls.Add(txt_name);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MemberInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberInfo";
            Load += MemberInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_phone;
        private TextBox txt_oldpass;
        private TextBox txt_email;
        private ComboBox cb_class;
        private Label label1;
        private Label lab_old;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txt_confirm;
        private TextBox txt_newPass;
        private Label lab_confirm;
        private Label lab_new;
        private Button button4;
        private Button btn_show;
        private Label lab_check;
        private Label lab_hi;
    }
}