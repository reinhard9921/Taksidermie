namespace Taksidermie
{
    partial class frmUpdateClient
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
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 55);
            this.label8.TabIndex = 32;
            this.label8.Text = "Edit Client";
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(85, 398);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(109, 40);
            this.btnUpdateClient.TabIndex = 31;
            this.btnUpdateClient.Text = "Edit Client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.BtnUpdateClient_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Name";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(85, 183);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Surname";
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(85, 310);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(100, 22);
            this.txtCell.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cell Number";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 246);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Email Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(85, 370);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Phone Number";
            // 
            // frmUpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Name = "frmUpdateClient";
            this.Text = "frmUpdateClient";
            this.Load += new System.EventHandler(this.FrmUpdateClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
    }
}