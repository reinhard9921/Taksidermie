namespace Taksidermie
{
    partial class frmPricelist
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteAnimal = new System.Windows.Forms.Button();
            this.btnUpdateAnimal = new System.Windows.Forms.Button();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dgvMounts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMountType = new System.Windows.Forms.ComboBox();
            this.cmbAnimalType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchFaktuur = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMounts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1317, 698);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 36);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnDeleteAnimal
            // 
            this.btnDeleteAnimal.Location = new System.Drawing.Point(922, 693);
            this.btnDeleteAnimal.Name = "btnDeleteAnimal";
            this.btnDeleteAnimal.Size = new System.Drawing.Size(75, 31);
            this.btnDeleteAnimal.TabIndex = 20;
            this.btnDeleteAnimal.Text = "Delete";
            this.btnDeleteAnimal.UseVisualStyleBackColor = true;
            this.btnDeleteAnimal.Click += new System.EventHandler(this.BtnDeleteAnimal_Click);
            // 
            // btnUpdateAnimal
            // 
            this.btnUpdateAnimal.Location = new System.Drawing.Point(674, 693);
            this.btnUpdateAnimal.Name = "btnUpdateAnimal";
            this.btnUpdateAnimal.Size = new System.Drawing.Size(75, 31);
            this.btnUpdateAnimal.TabIndex = 19;
            this.btnUpdateAnimal.Text = "Update";
            this.btnUpdateAnimal.UseVisualStyleBackColor = true;
            this.btnUpdateAnimal.Click += new System.EventHandler(this.BtnUpdateAnimal_Click);
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(454, 693);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(75, 31);
            this.btnAddAnimal.TabIndex = 18;
            this.btnAddAnimal.Text = "Add";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.BtnAddAnimal_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(1047, 652);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(257, 22);
            this.txtPrice.TabIndex = 17;
            this.txtPrice.Text = "txtPrice";
            // 
            // dgvMounts
            // 
            this.dgvMounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMounts.Location = new System.Drawing.Point(9, 60);
            this.dgvMounts.Name = "dgvMounts";
            this.dgvMounts.RowHeadersWidth = 51;
            this.dgvMounts.RowTemplate.Height = 24;
            this.dgvMounts.Size = new System.Drawing.Size(1380, 531);
            this.dgvMounts.TabIndex = 16;
            this.dgvMounts.SelectionChanged += new System.EventHandler(this.DgvMounts_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Price List";
            // 
            // cmbMountType
            // 
            this.cmbMountType.FormattingEnabled = true;
            this.cmbMountType.Location = new System.Drawing.Point(598, 650);
            this.cmbMountType.Name = "cmbMountType";
            this.cmbMountType.Size = new System.Drawing.Size(257, 24);
            this.cmbMountType.TabIndex = 22;
            // 
            // cmbAnimalType
            // 
            this.cmbAnimalType.FormattingEnabled = true;
            this.cmbAnimalType.Location = new System.Drawing.Point(118, 652);
            this.cmbAnimalType.Name = "cmbAnimalType";
            this.cmbAnimalType.Size = new System.Drawing.Size(257, 24);
            this.cmbAnimalType.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 632);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Animal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mount Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1044, 632);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1251, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Search";
            // 
            // txtSearchFaktuur
            // 
            this.txtSearchFaktuur.Location = new System.Drawing.Point(1251, 32);
            this.txtSearchFaktuur.Name = "txtSearchFaktuur";
            this.txtSearchFaktuur.Size = new System.Drawing.Size(138, 22);
            this.txtSearchFaktuur.TabIndex = 27;
            // 
            // frmPricelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 746);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearchFaktuur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAnimalType);
            this.Controls.Add(this.cmbMountType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteAnimal);
            this.Controls.Add(this.btnUpdateAnimal);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.dgvMounts);
            this.Controls.Add(this.btnBack);
            this.Name = "frmPricelist";
            this.Text = "frmPricelist";
            this.Load += new System.EventHandler(this.FrmPricelist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteAnimal;
        private System.Windows.Forms.Button btnUpdateAnimal;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridView dgvMounts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMountType;
        private System.Windows.Forms.ComboBox cmbAnimalType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchFaktuur;
    }
}