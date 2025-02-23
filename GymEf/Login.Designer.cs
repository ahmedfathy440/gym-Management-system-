namespace GymEf
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btn_login = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_username = new TextBox();
            txt_pass = new TextBox();
            btn_reset = new Button();
            cb_show = new CheckBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Black;
            btn_login.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn_login.Location = new Point(10, 258);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(151, 53);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1, 60);
            label1.Name = "label1";
            label1.Size = new Size(114, 31);
            label1.TabIndex = 1;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(5, 151);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 13.8F);
            txt_username.Location = new Point(149, 60);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(209, 38);
            txt_username.TabIndex = 3;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 13.8F);
            txt_pass.Location = new Point(149, 151);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(209, 38);
            txt_pass.TabIndex = 4;
            // 
            // btn_reset
            // 
            btn_reset.BackColor = Color.Black;
            btn_reset.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btn_reset.Location = new Point(207, 258);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(151, 53);
            btn_reset.TabIndex = 5;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = false;
            btn_reset.Click += btn_reset_Click;
            // 
            // cb_show
            // 
            cb_show.AutoSize = true;
            cb_show.BackColor = Color.Transparent;
            cb_show.ForeColor = SystemColors.ControlLightLight;
            cb_show.Location = new Point(149, 195);
            cb_show.Name = "cb_show";
            cb_show.Size = new Size(168, 32);
            cb_show.TabIndex = 6;
            cb_show.Text = "Show Password";
            cb_show.UseVisualStyleBackColor = false;
            cb_show.CheckedChanged += cb_show_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(btn_login);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cb_show);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btn_reset);
            groupBox1.Controls.Add(txt_pass);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(146, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 349);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(170, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 199);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(716, 571);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_login;
        private Label label1;
        private Label label2;
        private TextBox txt_username;
        private TextBox txt_pass;
        private Button btn_reset;
        private CheckBox cb_show;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}
