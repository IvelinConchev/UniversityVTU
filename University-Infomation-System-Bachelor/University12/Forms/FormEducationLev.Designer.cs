namespace University12.Forms
{
    partial class FormEducationLev
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
            this.dgLevelEducation = new System.Windows.Forms.DataGridView();
            this.gBoxEducation = new System.Windows.Forms.GroupBox();
            this.btnEducationAdd = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLevelEducation = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgLevelEducation)).BeginInit();
            this.gBoxEducation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLevelEducation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLevelEducation
            // 
            this.dgLevelEducation.AllowUserToAddRows = false;
            this.dgLevelEducation.AllowUserToDeleteRows = false;
            this.dgLevelEducation.AutoGenerateColumns = false;
            this.dgLevelEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLevelEducation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.levelNameDataGridViewTextBoxColumn});
            this.dgLevelEducation.DataSource = this.bsLevelEducation;
            this.dgLevelEducation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLevelEducation.Location = new System.Drawing.Point(3, 16);
            this.dgLevelEducation.Name = "dgLevelEducation";
            this.dgLevelEducation.ReadOnly = true;
            this.dgLevelEducation.RowHeadersWidth = 10;
            this.dgLevelEducation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLevelEducation.Size = new System.Drawing.Size(416, 355);
            this.dgLevelEducation.TabIndex = 1;
            this.dgLevelEducation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dgLevelEducation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLevelEducation_CellDoubleClick);
            // 
            // gBoxEducation
            // 
            this.gBoxEducation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxEducation.Controls.Add(this.dgLevelEducation);
            this.gBoxEducation.Location = new System.Drawing.Point(3, 53);
            this.gBoxEducation.Name = "gBoxEducation";
            this.gBoxEducation.Size = new System.Drawing.Size(422, 374);
            this.gBoxEducation.TabIndex = 4;
            this.gBoxEducation.TabStop = false;
            this.gBoxEducation.Text = "Образователна степен";
            // 
            // btnEducationAdd
            // 
            this.btnEducationAdd.BackColor = System.Drawing.Color.White;
            this.btnEducationAdd.Location = new System.Drawing.Point(329, 12);
            this.btnEducationAdd.Name = "btnEducationAdd";
            this.btnEducationAdd.Size = new System.Drawing.Size(91, 35);
            this.btnEducationAdd.TabIndex = 5;
            this.btnEducationAdd.Text = "Добави";
            this.btnEducationAdd.UseVisualStyleBackColor = false;
            this.btnEducationAdd.Click += new System.EventHandler(this.btnEducationAdd_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "№";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 40;
            // 
            // levelNameDataGridViewTextBoxColumn
            // 
            this.levelNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.levelNameDataGridViewTextBoxColumn.DataPropertyName = "LevelName";
            this.levelNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.levelNameDataGridViewTextBoxColumn.Name = "levelNameDataGridViewTextBoxColumn";
            this.levelNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsLevelEducation
            // 
            this.bsLevelEducation.AllowNew = false;
            this.bsLevelEducation.DataSource = typeof(University12.Classes.TEducationLevel);
            // 
            // FormEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 431);
            this.Controls.Add(this.btnEducationAdd);
            this.Controls.Add(this.gBoxEducation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEducation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Образователна степен";
            this.Load += new System.EventHandler(this.FormEducation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLevelEducation)).EndInit();
            this.gBoxEducation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsLevelEducation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgLevelEducation;
        private System.Windows.Forms.GroupBox gBoxEducation;
        private System.Windows.Forms.Button btnEducationAdd;
        public System.Windows.Forms.BindingSource bsLevelEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelNameDataGridViewTextBoxColumn;
    }
}