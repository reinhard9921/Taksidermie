namespace Taksidermie
{
    partial class frmMainScreen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMountTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invetoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyIncreaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMounts = new System.Windows.Forms.DataGridView();
            this.txtSearchFaktuur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.txtClientDropoff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClientPickUp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSms = new System.Windows.Forms.TextBox();
            this.chbActive = new System.Windows.Forms.CheckBox();
            this.richtxtStatus = new System.Windows.Forms.RichTextBox();
            this.btnUpdateInvoice = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPickedUpNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpPDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtClientDropoffNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMounts)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.invetoryToolStripMenuItem,
            this.lookupToolStripMenuItem,
            this.priceListToolStripMenuItem,
            this.paymentHistoryToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1709, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.addMountTypeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.fileToolStripMenuItem.Text = "Client";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addUserToolStripMenuItem.Text = "Add Client";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.AddUserToolStripMenuItem_Click);
            // 
            // addMountTypeToolStripMenuItem
            // 
            this.addMountTypeToolStripMenuItem.Name = "addMountTypeToolStripMenuItem";
            this.addMountTypeToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addMountTypeToolStripMenuItem.Text = "Manage Clients";
            this.addMountTypeToolStripMenuItem.Click += new System.EventHandler(this.AddMountTypeToolStripMenuItem_Click);
            // 
            // invetoryToolStripMenuItem
            // 
            this.invetoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToInventoryToolStripMenuItem,
            this.manageInventoryToolStripMenuItem});
            this.invetoryToolStripMenuItem.Name = "invetoryToolStripMenuItem";
            this.invetoryToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.invetoryToolStripMenuItem.Text = "Invetory";
            this.invetoryToolStripMenuItem.Click += new System.EventHandler(this.InvetoryToolStripMenuItem_Click);
            // 
            // addToInventoryToolStripMenuItem
            // 
            this.addToInventoryToolStripMenuItem.Name = "addToInventoryToolStripMenuItem";
            this.addToInventoryToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.addToInventoryToolStripMenuItem.Text = "Add To Inventory";
            this.addToInventoryToolStripMenuItem.Click += new System.EventHandler(this.AddToInventoryToolStripMenuItem_Click);
            // 
            // manageInventoryToolStripMenuItem
            // 
            this.manageInventoryToolStripMenuItem.Name = "manageInventoryToolStripMenuItem";
            this.manageInventoryToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.manageInventoryToolStripMenuItem.Text = "Manage Inventory";
            this.manageInventoryToolStripMenuItem.Click += new System.EventHandler(this.ManageInventoryToolStripMenuItem_Click);
            // 
            // lookupToolStripMenuItem
            // 
            this.lookupToolStripMenuItem.Name = "lookupToolStripMenuItem";
            this.lookupToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.lookupToolStripMenuItem.Text = "Lists";
            this.lookupToolStripMenuItem.Click += new System.EventHandler(this.LookupToolStripMenuItem_Click);
            // 
            // priceListToolStripMenuItem
            // 
            this.priceListToolStripMenuItem.Name = "priceListToolStripMenuItem";
            this.priceListToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.priceListToolStripMenuItem.Text = "Price List";
            this.priceListToolStripMenuItem.Click += new System.EventHandler(this.PriceListToolStripMenuItem_Click);
            // 
            // paymentHistoryToolStripMenuItem
            // 
            this.paymentHistoryToolStripMenuItem.Name = "paymentHistoryToolStripMenuItem";
            this.paymentHistoryToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.paymentHistoryToolStripMenuItem.Text = "Payment History";
            this.paymentHistoryToolStripMenuItem.Click += new System.EventHandler(this.PaymentHistoryToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setConnectionToolStripMenuItem,
            this.yearlyIncreaseToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setConnectionToolStripMenuItem
            // 
            this.setConnectionToolStripMenuItem.Name = "setConnectionToolStripMenuItem";
            this.setConnectionToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.setConnectionToolStripMenuItem.Text = "Set Connection";
            // 
            // yearlyIncreaseToolStripMenuItem
            // 
            this.yearlyIncreaseToolStripMenuItem.Name = "yearlyIncreaseToolStripMenuItem";
            this.yearlyIncreaseToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.yearlyIncreaseToolStripMenuItem.Text = "Yearly Increase";
            // 
            // dgvMounts
            // 
            this.dgvMounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMounts.Location = new System.Drawing.Point(12, 103);
            this.dgvMounts.Name = "dgvMounts";
            this.dgvMounts.RowHeadersWidth = 51;
            this.dgvMounts.RowTemplate.Height = 24;
            this.dgvMounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMounts.Size = new System.Drawing.Size(1685, 688);
            this.dgvMounts.TabIndex = 1;
            this.dgvMounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMounts_CellContentClick);
            this.dgvMounts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMounts_CellDoubleClick);
            this.dgvMounts.SelectionChanged += new System.EventHandler(this.dgvMounts_SelectionChanged);
            this.dgvMounts.DoubleClick += new System.EventHandler(this.DgvMounts_DoubleClick);
            // 
            // txtSearchFaktuur
            // 
            this.txtSearchFaktuur.Location = new System.Drawing.Point(1330, 75);
            this.txtSearchFaktuur.Name = "txtSearchFaktuur";
            this.txtSearchFaktuur.Size = new System.Drawing.Size(138, 22);
            this.txtSearchFaktuur.TabIndex = 2;
            this.txtSearchFaktuur.TextChanged += new System.EventHandler(this.TxtSearchFaktuur_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1330, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Invoices";
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.Location = new System.Drawing.Point(15, 798);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(116, 30);
            this.btnNewInvoice.TabIndex = 5;
            this.btnNewInvoice.Text = "New Invoice";
            this.btnNewInvoice.UseVisualStyleBackColor = true;
            this.btnNewInvoice.Click += new System.EventHandler(this.BtnNewInvoice_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(15, 834);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(116, 31);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "Make Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // txtClientDropoff
            // 
            this.txtClientDropoff.Location = new System.Drawing.Point(187, 817);
            this.txtClientDropoff.Name = "txtClientDropoff";
            this.txtClientDropoff.Size = new System.Drawing.Size(165, 22);
            this.txtClientDropoff.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 794);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Client Dropped Off";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(912, 797);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status Report";
            // 
            // txtClientPickUp
            // 
            this.txtClientPickUp.Location = new System.Drawing.Point(389, 868);
            this.txtClientPickUp.Name = "txtClientPickUp";
            this.txtClientPickUp.Size = new System.Drawing.Size(165, 22);
            this.txtClientPickUp.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 848);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Client Picked up";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(759, 797);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "SMS";
            // 
            // txtSms
            // 
            this.txtSms.Location = new System.Drawing.Point(759, 820);
            this.txtSms.Name = "txtSms";
            this.txtSms.Size = new System.Drawing.Size(100, 22);
            this.txtSms.TabIndex = 13;
            // 
            // chbActive
            // 
            this.chbActive.AutoSize = true;
            this.chbActive.Location = new System.Drawing.Point(759, 868);
            this.chbActive.Name = "chbActive";
            this.chbActive.Size = new System.Drawing.Size(68, 21);
            this.chbActive.TabIndex = 19;
            this.chbActive.Text = "Active";
            this.chbActive.UseVisualStyleBackColor = true;
            // 
            // richtxtStatus
            // 
            this.richtxtStatus.Location = new System.Drawing.Point(915, 817);
            this.richtxtStatus.Name = "richtxtStatus";
            this.richtxtStatus.Size = new System.Drawing.Size(304, 74);
            this.richtxtStatus.TabIndex = 20;
            this.richtxtStatus.Text = "";
            // 
            // btnUpdateInvoice
            // 
            this.btnUpdateInvoice.Location = new System.Drawing.Point(1263, 825);
            this.btnUpdateInvoice.Name = "btnUpdateInvoice";
            this.btnUpdateInvoice.Size = new System.Drawing.Size(75, 48);
            this.btnUpdateInvoice.TabIndex = 21;
            this.btnUpdateInvoice.Text = "Update Invoice";
            this.btnUpdateInvoice.UseVisualStyleBackColor = true;
            this.btnUpdateInvoice.Click += new System.EventHandler(this.BtnUpdateInvoice_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 848);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Client Picked Up Number";
            // 
            // txtPickedUpNumber
            // 
            this.txtPickedUpNumber.Location = new System.Drawing.Point(575, 868);
            this.txtPickedUpNumber.Name = "txtPickedUpNumber";
            this.txtPickedUpNumber.Size = new System.Drawing.Size(155, 22);
            this.txtPickedUpNumber.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(572, 797);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Date Picked Up";
            // 
            // dtpPDate
            // 
            this.dtpPDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPDate.Location = new System.Drawing.Point(575, 820);
            this.dtpPDate.Name = "dtpPDate";
            this.dtpPDate.Size = new System.Drawing.Size(155, 22);
            this.dtpPDate.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(386, 794);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Client Dropped Off number";
            // 
            // txtClientDropoffNumber
            // 
            this.txtClientDropoffNumber.Location = new System.Drawing.Point(389, 817);
            this.txtClientDropoffNumber.Name = "txtClientDropoffNumber";
            this.txtClientDropoffNumber.Size = new System.Drawing.Size(165, 22);
            this.txtClientDropoffNumber.TabIndex = 26;
            this.txtClientDropoffNumber.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1415, 825);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 48);
            this.button1.TabIndex = 28;
            this.button1.Text = "Complete Invoice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1563, 825);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 48);
            this.button2.TabIndex = 29;
            this.button2.Text = "Cancel Invoice";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 900);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtClientDropoffNumber);
            this.Controls.Add(this.dtpPDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPickedUpNumber);
            this.Controls.Add(this.btnUpdateInvoice);
            this.Controls.Add(this.richtxtStatus);
            this.Controls.Add(this.chbActive);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClientPickUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClientDropoff);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnNewInvoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchFaktuur);
            this.Controls.Add(this.dgvMounts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainScreen";
            this.Text = "Taksidermie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMountTypeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvMounts;
        private System.Windows.Forms.TextBox txtSearchFaktuur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem invetoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.ToolStripMenuItem setConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyIncreaseToolStripMenuItem;
        private System.Windows.Forms.TextBox txtClientDropoff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClientPickUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSms;
        private System.Windows.Forms.CheckBox chbActive;
        private System.Windows.Forms.RichTextBox richtxtStatus;
        private System.Windows.Forms.Button btnUpdateInvoice;
        private System.Windows.Forms.ToolStripMenuItem paymentHistoryToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPickedUpNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpPDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtClientDropoffNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

