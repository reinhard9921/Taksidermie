namespace Taksidermie
{
    partial class frmPayment
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
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chbDeposit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(345, 55);
            this.label8.TabIndex = 34;
            this.label8.Text = "Make Payment";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(133, 262);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(88, 60);
            this.btnAddUser.TabIndex = 33;
            this.btnAddUser.Text = "Make Payment";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(126, 122);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Amount Paid";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker1.TabIndex = 35;
            this.dateTimePicker1.Value = new System.DateTime(2019, 7, 6, 0, 0, 0, 0);
            // 
            // chbDeposit
            // 
            this.chbDeposit.AutoSize = true;
            this.chbDeposit.Location = new System.Drawing.Point(126, 223);
            this.chbDeposit.Name = "chbDeposit";
            this.chbDeposit.Size = new System.Drawing.Size(78, 21);
            this.chbDeposit.TabIndex = 36;
            this.chbDeposit.Text = "Deposit";
            this.chbDeposit.UseVisualStyleBackColor = true;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 371);
            this.Controls.Add(this.chbDeposit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "frmPayment";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.FrmPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chbDeposit;
    }
}