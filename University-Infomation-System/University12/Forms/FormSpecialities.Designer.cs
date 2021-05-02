namespace University12.Forms
{
    partial class FormSpecialities
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
            this.components = new System.ComponentModel.Container();
            this.dgSpecialities = new System.Windows.Forms.DataGridView();
            this.gBoxSpecialities = new System.Windows.Forms.GroupBox();
            this.btnFormSpecialityAdd = new System.Windows.Forms.Button();
            this.bsSpecialities = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSpecialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgSpecialities)).BeginInit();
            this.gBoxSpecialities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpecialities)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSpecialities
            // 
            this.dgSpecialities.AllowUserToAddRows = false;
            this.dgSpecialities.AllowUserToDeleteRows = false;
            this.dgSpecialities.AutoGenerateColumns = false;
            this.dgSpecialities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSpecialities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameSpecialityDataGridViewTextBoxColumn,
            this.Column1});
            this.dgSpecialities.DataSource = this.bsSpecialities;
            this.dgSpecialities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSpecialities.Location = new System.Drawing.Point(3, 16);
            this.dgSpecialities.Name = "dgSpecialities";
            this.dgSpecialities.ReadOnly = true;
            this.dgSpecialities.RowHeadersWidth = 10;
            this.dgSpecialities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSpecialities.Size = new System.Drawing.Size(304, 277);
            this.dgSpecialities.TabIndex = 0;
            this.dgSpecialities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgSpecialities_CellClick);
            this.dgSpecialities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgSpecialities_CellContentClick);
            this.dgSpecialities.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // gBoxSpecialities
            // 
            this.gBoxSpecialities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxSpecialities.Controls.Add(this.dgSpecialities);
            this.gBoxSpecialities.Location = new System.Drawing.Point(1, 64);
            this.gBoxSpecialities.Name = "gBoxSpecialities";
            this.gBoxSpecialities.Size = new System.Drawing.Size(310, 296);
            this.gBoxSpecialities.TabIndex = 1;
            this.gBoxSpecialities.TabStop = false;
            this.gBoxSpecialities.Text = "Специалности";
            // 
            // btnFormSpecialityAdd
            // 
            this.btnFormSpecialityAdd.BackColor = System.Drawing.Color.White;
            this.btnFormSpecialityAdd.Location = new System.Drawing.Point(217, 23);
            this.btnFormSpecialityAdd.Name = "btnFormSpecialityAdd";
            this.btnFormSpecialityAdd.Size = new System.Drawing.Size(91, 35);
            this.btnFormSpecialityAdd.TabIndex = 2;
            this.btnFormSpecialityAdd.Text = "Добави";
            this.btnFormSpecialityAdd.UseVisualStyleBackColor = false;
            this.btnFormSpecialityAdd.Click += new System.EventHandler(this.BtnFormSpecialityAdd_Click);
            // 
            // bsSpecialities
            // 
            this.bsSpecialities.AllowNew = false;
            this.bsSpecialities.DataSource = typeof(University12.Classes.TSpeciality);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "№";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 20;
            // 
            // nameSpecialityDataGridViewTextBoxColumn
            // 
            this.nameSpecialityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameSpecialityDataGridViewTextBoxColumn.DataPropertyName = "NameSpeciality";
            this.nameSpecialityDataGridViewTextBoxColumn.HeaderText = "Име";
            this.nameSpecialityDataGridViewTextBoxColumn.Name = "nameSpecialityDataGridViewTextBoxColumn";
            this.nameSpecialityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дисциплини";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FormSpecialities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 363);
            this.Controls.Add(this.btnFormSpecialityAdd);
            this.Controls.Add(this.gBoxSpecialities);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSpecialities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Специалности";
            this.Load += new System.EventHandler(this.FormSpecialities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSpecialities)).EndInit();
            this.gBoxSpecialities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsSpecialities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSpecialities;
        private System.Windows.Forms.GroupBox gBoxSpecialities;
        private System.Windows.Forms.Button btnFormSpecialityAdd;
        public System.Windows.Forms.BindingSource bsSpecialities;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSpecialityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}