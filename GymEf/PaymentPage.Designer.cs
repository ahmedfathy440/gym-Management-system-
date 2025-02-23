namespace GymEf
{
    partial class PaymentPage
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
            dgv_payment = new DataGridView();
            btn_add = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_back = new Button();
            label1 = new Label();
            nud_amount = new NumericUpDown();
            dtp_date = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            cb_member = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_payment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_amount).BeginInit();
            SuspendLayout();
            // 
            // dgv_payment
            // 
            dgv_payment.BackgroundColor = SystemColors.ControlLightLight;
            dgv_payment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_payment.Location = new Point(410, 12);
            dgv_payment.Name = "dgv_payment";
            dgv_payment.RowHeadersWidth = 51;
            dgv_payment.Size = new Size(638, 426);
            dgv_payment.TabIndex = 0;
            dgv_payment.RowHeaderMouseDoubleClick += dgv_payment_RowHeaderMouseDoubleClick;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Transparent;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.ForeColor = SystemColors.Control;
            btn_add.Location = new Point(29, 305);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(117, 44);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Transparent;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.ForeColor = SystemColors.Control;
            btn_delete.Location = new Point(230, 381);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(117, 44);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Transparent;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.ForeColor = SystemColors.Control;
            btn_update.Location = new Point(230, 305);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(117, 44);
            btn_update.TabIndex = 5;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = SystemColors.Control;
            btn_back.Location = new Point(29, 381);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(117, 44);
            btn_back.TabIndex = 7;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(15, 58);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 8;
            label1.Text = "Amount";
            // 
            // nud_amount
            // 
            nud_amount.Font = new Font("Segoe UI", 12F);
            nud_amount.Location = new Point(197, 58);
            nud_amount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_amount.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            nud_amount.Name = "nud_amount";
            nud_amount.Size = new Size(159, 34);
            nud_amount.TabIndex = 1;
            nud_amount.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // dtp_date
            // 
            dtp_date.CustomFormat = "dd MMM yyyy";
            dtp_date.Font = new Font("Segoe UI", 12F);
            dtp_date.Format = DateTimePickerFormat.Custom;
            dtp_date.Location = new Point(196, 138);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new Size(159, 34);
            dtp_date.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 209);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 11;
            label2.Text = "Member";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 138);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 12;
            label3.Text = "Payment Date";
            // 
            // cb_member
            // 
            cb_member.Font = new Font("Segoe UI", 12F);
            cb_member.FormattingEnabled = true;
            cb_member.Location = new Point(197, 209);
            cb_member.Name = "cb_member";
            cb_member.Size = new Size(159, 36);
            cb_member.TabIndex = 3;
            // 
            // PaymentPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1062, 450);
            Controls.Add(cb_member);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtp_date);
            Controls.Add(nud_amount);
            Controls.Add(label1);
            Controls.Add(btn_back);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(dgv_payment);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PaymentPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentPage";
            Load += PaymentPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_payment).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_amount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_payment;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_back;
        private Label label1;
        private NumericUpDown nud_amount;
        private DateTimePicker dtp_date;
        private Label label2;
        private Label label3;
        private ComboBox cb_member;
    }
}