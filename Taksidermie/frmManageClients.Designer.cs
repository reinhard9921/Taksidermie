namespace Taksidermie
{
    partial class frmManageClients
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMounts = new System.Windows.Forms.DataGridView();
            this.btnClientUpdate = new System.Windows.Forms.Button();
            this.btnClientDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchFaktuur = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMounts)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clients";
            // 
            // dgvMounts
            // 
            this.dgvMounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMounts.Location = new System.Drawing.Point(20, 60);
            this.dgvMounts.Name = "dgvMounts";
            this.dgvMounts.RowHeadersWidth = 51;
            this.dgvMounts.RowTemplate.Height = 24;
            this.dgvMounts.Size = new System.Drawing.Size(1403, 606);
            this.dgvMounts.TabIndex = 5;
            this.dgvMounts.SelectionChanged += new System.EventHandler(this.DgvMounts_SelectionChanged);
            // 
            // btnClientUpdate
            // 
            this.btnClientUpdate.Location = new System.Drawing.Point(20, 672);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnClientUpdate.TabIndex = 7;
            this.btnClientUpdate.Text = "Edit";
            this.btnClientUpdate.UseVisualStyleBackColor = true;
            this.btnClientUpdate.Click += new System.EventHandler(this.BtnClientUpdate_Click);
            // 
            // btnClientDelete
            // 
            this.btnClientDelete.Location = new System.Drawing.Point(123, 672);
            this.btnClientDelete.Name = "btnClientDelete";
            this.btnClientDelete.Size = new System.Drawing.Size(75, 35);
            this.btnClientDelete.TabIndex = 8;
            this.btnClientDelete.Text = "Delete";
            this.btnClientDelete.UseVisualStyleBackColor = true;
            this.btnClientDelete.Click += new System.EventHandler(this.BtnClientDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1349, 672);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 35);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search";
            // 
            // txtSearchFaktuur
            // 
            this.txtSearchFaktuur.Location = new System.Drawing.Point(1286, 32);
            this.txtSearchFaktuur.Name = "txtSearchFaktuur";
            this.txtSearchFaktuur.Size = new System.Drawing.Size(138, 22);
            this.txtSearchFaktuur.TabIndex = 10;
            // 
            // frmManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 716);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchFaktuur);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClientDelete);
            this.Controls.Add(this.btnClientUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMounts);
            this.Name = "frmManageClients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.FrmManageClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMounts;
        private System.Windows.Forms.Button btnClientUpdate;
        private System.Windows.Forms.Button btnClientDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchFaktuur;
    }
}