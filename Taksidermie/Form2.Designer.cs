namespace Taksidermie
{
    partial class frmInvoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richeditRemarks = new System.Windows.Forms.RichTextBox();
            this.btnAddTrophree = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.dgvTrophees = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPhoneNumber = new System.Windows.Forms.ComboBox();
            this.cmbNameSurname = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMountType = new System.Windows.Forms.ComboBox();
            this.cmbAnimalType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCell = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrophees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Number";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(316, 591);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 652);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mount Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Remarks";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(166, 591);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNumber.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Added Number";
            // 
            // richeditRemarks
            // 
            this.richeditRemarks.Location = new System.Drawing.Point(598, 591);
            this.richeditRemarks.Name = "richeditRemarks";
            this.richeditRemarks.Size = new System.Drawing.Size(425, 99);
            this.richeditRemarks.TabIndex = 7;
            this.richeditRemarks.Text = "";
            // 
            // btnAddTrophree
            // 
            this.btnAddTrophree.Location = new System.Drawing.Point(798, 709);
            this.btnAddTrophree.Name = "btnAddTrophree";
            this.btnAddTrophree.Size = new System.Drawing.Size(144, 35);
            this.btnAddTrophree.TabIndex = 8;
            this.btnAddTrophree.Text = "Add Throphee";
            this.btnAddTrophree.UseVisualStyleBackColor = true;
            this.btnAddTrophree.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(948, 709);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 35);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // dgvTrophees
            // 
            this.dgvTrophees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrophees.Location = new System.Drawing.Point(12, 187);
            this.dgvTrophees.Name = "dgvTrophees";
            this.dgvTrophees.RowHeadersWidth = 51;
            this.dgvTrophees.RowTemplate.Height = 24;
            this.dgvTrophees.Size = new System.Drawing.Size(1011, 358);
            this.dgvTrophees.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(417, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 55);
            this.label8.TabIndex = 18;
            this.label8.Text = "Invoice";
            // 
            // cmbPhoneNumber
            // 
            this.cmbPhoneNumber.FormattingEnabled = true;
            this.cmbPhoneNumber.Location = new System.Drawing.Point(16, 80);
            this.cmbPhoneNumber.Name = "cmbPhoneNumber";
            this.cmbPhoneNumber.Size = new System.Drawing.Size(121, 24);
            this.cmbPhoneNumber.TabIndex = 23;
            this.cmbPhoneNumber.SelectedIndexChanged += new System.EventHandler(this.CmbPhoneNumber_SelectedIndexChanged);
            // 
            // cmbNameSurname
            // 
            this.cmbNameSurname.FormattingEnabled = true;
            this.cmbNameSurname.Location = new System.Drawing.Point(15, 29);
            this.cmbNameSurname.Name = "cmbNameSurname";
            this.cmbNameSurname.Size = new System.Drawing.Size(121, 24);
            this.cmbNameSurname.TabIndex = 22;
            this.cmbNameSurname.SelectedIndexChanged += new System.EventHandler(this.CmbNameSurname_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Name And Surname";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cell Number";
            // 
            // cmbMountType
            // 
            this.cmbMountType.FormattingEnabled = true;
            this.cmbMountType.Location = new System.Drawing.Point(16, 672);
            this.cmbMountType.Name = "cmbMountType";
            this.cmbMountType.Size = new System.Drawing.Size(121, 24);
            this.cmbMountType.TabIndex = 24;
            this.cmbMountType.SelectedIndexChanged += new System.EventHandler(this.CmbMountType_SelectedIndexChanged);
            // 
            // cmbAnimalType
            // 
            this.cmbAnimalType.FormattingEnabled = true;
            this.cmbAnimalType.Location = new System.Drawing.Point(166, 672);
            this.cmbAnimalType.Name = "cmbAnimalType";
            this.cmbAnimalType.Size = new System.Drawing.Size(121, 24);
            this.cmbAnimalType.TabIndex = 26;
            this.cmbAnimalType.SelectedIndexChanged += new System.EventHandler(this.CmbAnimalType_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(163, 652);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Animal Type";
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Location = new System.Drawing.Point(13, 596);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(58, 17);
            this.lblInvoice.TabIndex = 27;
            this.lblInvoice.Text = "Number";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(316, 674);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 22);
            this.txtDiscount.TabIndex = 28;
            this.txtDiscount.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(313, 654);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Discount";
            // 
            // cmbCell
            // 
            this.cmbCell.FormattingEnabled = true;
            this.cmbCell.Location = new System.Drawing.Point(16, 135);
            this.cmbCell.Name = "cmbCell";
            this.cmbCell.Size = new System.Drawing.Size(121, 24);
            this.cmbCell.TabIndex = 33;
            this.cmbCell.SelectedIndexChanged += new System.EventHandler(this.CmbCell_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Phone Number";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 750);
            this.Controls.Add(this.cmbCell);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblInvoice);
            this.Controls.Add(this.cmbAnimalType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbMountType);
            this.Controls.Add(this.cmbPhoneNumber);
            this.Controls.Add(this.cmbNameSurname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvTrophees);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnAddTrophree);
            this.Controls.Add(this.richeditRemarks);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInvoice";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrophees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richeditRemarks;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnAddTrophree;
        private System.Windows.Forms.DataGridView dgvTrophees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPhoneNumber;
        private System.Windows.Forms.ComboBox cmbNameSurname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMountType;
        private System.Windows.Forms.ComboBox cmbAnimalType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCell;
        private System.Windows.Forms.Label label11;
    }
}