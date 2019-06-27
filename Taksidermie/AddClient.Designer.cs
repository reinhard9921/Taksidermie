namespace Taksidermie
{
    partial class AddClient
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 148);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Name";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(115, 210);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Surname";
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(115, 337);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(100, 22);
            this.txtCell.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cell Number";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 273);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Email Address";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(115, 438);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(88, 40);
            this.btnAddUser.TabIndex = 21;
            this.btnAddUser.Text = "Add Client";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 55);
            this.label8.TabIndex = 22;
            this.label8.Text = "Add Client";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(115, 391);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Phone Number";
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 490);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
    }
}