namespace Taksidermie
{
    partial class frmLists
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
            this.dgvAnimals = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnimals = new System.Windows.Forms.TextBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnUpdateAnimal = new System.Windows.Forms.Button();
            this.btnDeleteAnimal = new System.Windows.Forms.Button();
            this.btnDeleteMount = new System.Windows.Forms.Button();
            this.btnUpdateMount = new System.Windows.Forms.Button();
            this.btnAddMount = new System.Windows.Forms.Button();
            this.txtMountType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMountType = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMountType)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnimals
            // 
            this.dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimals.Location = new System.Drawing.Point(12, 59);
            this.dgvAnimals.Name = "dgvAnimals";
            this.dgvAnimals.RowHeadersWidth = 51;
            this.dgvAnimals.RowTemplate.Height = 24;
            this.dgvAnimals.Size = new System.Drawing.Size(584, 543);
            this.dgvAnimals.TabIndex = 0;
            this.dgvAnimals.SelectionChanged += new System.EventHandler(this.DgvAnimals_SelectionChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1280, 703);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 33);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Animals";
            // 
            // txtAnimals
            // 
            this.txtAnimals.Location = new System.Drawing.Point(152, 617);
            this.txtAnimals.Name = "txtAnimals";
            this.txtAnimals.Size = new System.Drawing.Size(308, 22);
            this.txtAnimals.TabIndex = 12;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(34, 652);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(75, 31);
            this.btnAddAnimal.TabIndex = 13;
            this.btnAddAnimal.Text = "Add";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.BtnAddAnimal_Click);
            // 
            // btnUpdateAnimal
            // 
            this.btnUpdateAnimal.Location = new System.Drawing.Point(254, 652);
            this.btnUpdateAnimal.Name = "btnUpdateAnimal";
            this.btnUpdateAnimal.Size = new System.Drawing.Size(75, 31);
            this.btnUpdateAnimal.TabIndex = 14;
            this.btnUpdateAnimal.Text = "Update";
            this.btnUpdateAnimal.UseVisualStyleBackColor = true;
            this.btnUpdateAnimal.Click += new System.EventHandler(this.BtnUpdateAnimal_Click);
            // 
            // btnDeleteAnimal
            // 
            this.btnDeleteAnimal.Location = new System.Drawing.Point(502, 652);
            this.btnDeleteAnimal.Name = "btnDeleteAnimal";
            this.btnDeleteAnimal.Size = new System.Drawing.Size(75, 31);
            this.btnDeleteAnimal.TabIndex = 15;
            this.btnDeleteAnimal.Text = "Delete";
            this.btnDeleteAnimal.UseVisualStyleBackColor = true;
            this.btnDeleteAnimal.Click += new System.EventHandler(this.BtnDeleteAnimal_Click);
            // 
            // btnDeleteMount
            // 
            this.btnDeleteMount.Location = new System.Drawing.Point(1250, 652);
            this.btnDeleteMount.Name = "btnDeleteMount";
            this.btnDeleteMount.Size = new System.Drawing.Size(75, 31);
            this.btnDeleteMount.TabIndex = 21;
            this.btnDeleteMount.Text = "Delete";
            this.btnDeleteMount.UseVisualStyleBackColor = true;
            this.btnDeleteMount.Click += new System.EventHandler(this.BtnDeleteMount_Click);
            // 
            // btnUpdateMount
            // 
            this.btnUpdateMount.Location = new System.Drawing.Point(1018, 652);
            this.btnUpdateMount.Name = "btnUpdateMount";
            this.btnUpdateMount.Size = new System.Drawing.Size(75, 31);
            this.btnUpdateMount.TabIndex = 20;
            this.btnUpdateMount.Text = "Update";
            this.btnUpdateMount.UseVisualStyleBackColor = true;
            this.btnUpdateMount.Click += new System.EventHandler(this.BtnUpdateMount_Click);
            // 
            // btnAddMount
            // 
            this.btnAddMount.Location = new System.Drawing.Point(782, 652);
            this.btnAddMount.Name = "btnAddMount";
            this.btnAddMount.Size = new System.Drawing.Size(75, 31);
            this.btnAddMount.TabIndex = 19;
            this.btnAddMount.Text = "Add";
            this.btnAddMount.UseVisualStyleBackColor = true;
            this.btnAddMount.Click += new System.EventHandler(this.BtnAddMount_Click);
            // 
            // txtMountType
            // 
            this.txtMountType.Location = new System.Drawing.Point(906, 617);
            this.txtMountType.Name = "txtMountType";
            this.txtMountType.Size = new System.Drawing.Size(308, 22);
            this.txtMountType.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(978, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mount Types";
            // 
            // dgvMountType
            // 
            this.dgvMountType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMountType.Location = new System.Drawing.Point(760, 59);
            this.dgvMountType.Name = "dgvMountType";
            this.dgvMountType.RowHeadersWidth = 51;
            this.dgvMountType.RowTemplate.Height = 24;
            this.dgvMountType.Size = new System.Drawing.Size(584, 543);
            this.dgvMountType.TabIndex = 16;
            this.dgvMountType.SelectionChanged += new System.EventHandler(this.DgvMountType_SelectionChanged);
            // 
            // frmLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 748);
            this.Controls.Add(this.btnDeleteMount);
            this.Controls.Add(this.btnUpdateMount);
            this.Controls.Add(this.btnAddMount);
            this.Controls.Add(this.txtMountType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMountType);
            this.Controls.Add(this.btnDeleteAnimal);
            this.Controls.Add(this.btnUpdateAnimal);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.txtAnimals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvAnimals);
            this.Name = "frmLists";
            this.Text = "Lists";
            this.Load += new System.EventHandler(this.FrmLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMountType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnimals;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnimals;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnUpdateAnimal;
        private System.Windows.Forms.Button btnDeleteAnimal;
        private System.Windows.Forms.Button btnDeleteMount;
        private System.Windows.Forms.Button btnUpdateMount;
        private System.Windows.Forms.Button btnAddMount;
        private System.Windows.Forms.TextBox txtMountType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMountType;
    }
}