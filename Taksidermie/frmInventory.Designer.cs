﻿namespace Taksidermie
{
    partial class frmInventory
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchFaktuur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.txtAmountInStock = new System.Windows.Forms.TextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbAnimalType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1276, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Search";
            // 
            // txtSearchFaktuur
            // 
            this.txtSearchFaktuur.Location = new System.Drawing.Point(1276, 33);
            this.txtSearchFaktuur.Name = "txtSearchFaktuur";
            this.txtSearchFaktuur.Size = new System.Drawing.Size(138, 22);
            this.txtSearchFaktuur.TabIndex = 37;
            this.txtSearchFaktuur.TextChanged += new System.EventHandler(this.TxtSearchFaktuur_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(762, 626);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Amount In Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 32);
            this.label2.TabIndex = 35;
            this.label2.Text = "Inventory";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(765, 686);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 31);
            this.btnDeleteItem.TabIndex = 34;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.BtnDeleteItem_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(479, 686);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(75, 31);
            this.btnUpdateItem.TabIndex = 33;
            this.btnUpdateItem.Text = "Update";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.BtnUpdateItem_Click);
            // 
            // txtAmountInStock
            // 
            this.txtAmountInStock.Location = new System.Drawing.Point(765, 646);
            this.txtAmountInStock.Name = "txtAmountInStock";
            this.txtAmountInStock.Size = new System.Drawing.Size(257, 22);
            this.txtAmountInStock.TabIndex = 31;
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(34, 61);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(1380, 531);
            this.dgvInventory.TabIndex = 30;
            this.dgvInventory.SelectionChanged += new System.EventHandler(this.DgvInventory_SelectionChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1342, 709);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 26);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // cmbAnimalType
            // 
            this.cmbAnimalType.FormattingEnabled = true;
            this.cmbAnimalType.Location = new System.Drawing.Point(532, 646);
            this.cmbAnimalType.Name = "cmbAnimalType";
            this.cmbAnimalType.Size = new System.Drawing.Size(121, 24);
            this.cmbAnimalType.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 626);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Animal Type";
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Items.AddRange(new object[] {
            "Cape",
            "Full Skin",
            "Back Skin",
            "Pote",
            "Stert"});
            this.cmbItem.Location = new System.Drawing.Point(348, 646);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(121, 24);
            this.cmbItem.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 626);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Item";
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 745);
            this.Controls.Add(this.cmbAnimalType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearchFaktuur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.txtAmountInStock);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.btnBack);
            this.Name = "frmInventory";
            this.Text = "frmInventory";
            this.Load += new System.EventHandler(this.FrmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchFaktuur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.TextBox txtAmountInStock;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbAnimalType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label label6;
    }
}