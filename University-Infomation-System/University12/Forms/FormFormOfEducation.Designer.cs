namespace University12.Forms.List
{
    partial class FormFormOfEducation
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
            this.gBoxFormDepartment = new System.Windows.Forms.GroupBox();
            this.dwFormOfEducation = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFormOfEducation = new System.Windows.Forms.BindingSource(this.components);
            this.btnFormOfEducation = new System.Windows.Forms.Button();
            this.gBoxFormDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwFormOfEducation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFormOfEducation)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxFormDepartment
            // 
            this.gBoxFormDepartment.Controls.Add(this.dwFormOfEducation);
            this.gBoxFormDepartment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gBoxFormDepartment.Location = new System.Drawing.Point(0, 57);
            this.gBoxFormDepartment.Name = "gBoxFormDepartment";
            this.gBoxFormDepartment.Size = new System.Drawing.Size(364, 352);
            this.gBoxFormDepartment.TabIndex = 1;
            this.gBoxFormDepartment.TabStop = false;
            this.gBoxFormDepartment.Text = "Форма";
            // 
            // dwFormOfEducation
            // 
            this.dwFormOfEducation.AllowUserToAddRows = false;
            this.dwFormOfEducation.AllowUserToDeleteRows = false;
            this.dwFormOfEducation.AutoGenerateColumns = false;
            this.dwFormOfEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwFormOfEducation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dwFormOfEducation.DataSource = this.bsFormOfEducation;
            this.dwFormOfEducation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dwFormOfEducation.Location = new System.Drawing.Point(3, 16);
            this.dwFormOfEducation.Name = "dwFormOfEducation";
            this.dwFormOfEducation.ReadOnly = true;
            this.dwFormOfEducation.RowHeadersWidth = 10;
            this.dwFormOfEducation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dwFormOfEducation.Size = new System.Drawing.Size(358, 333);
            this.dwFormOfEducation.TabIndex = 0;
            this.dwFormOfEducation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DwFormOfEducation_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "№";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 20;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Форма на обучение";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsFormOfEducation
            // 
            this.bsFormOfEducation.AllowNew = false;
            this.bsFormOfEducation.DataSource = typeof(University12.Classes.TFormOfEducation);
            // 
            // btnFormOfEducation
            // 
            this.btnFormOfEducation.BackColor = System.Drawing.Color.White;
            this.btnFormOfEducation.Location = new System.Drawing.Point(261, 22);
            this.btnFormOfEducation.Name = "btnFormOfEducation";
            this.btnFormOfEducation.Size = new System.Drawing.Size(91, 35);
            this.btnFormOfEducation.TabIndex = 38;
            this.btnFormOfEducation.Text = "Добави";
            this.btnFormOfEducation.UseVisualStyleBackColor = false;
            this.btnFormOfEducation.Click += new System.EventHandler(this.BtnFormOfEducation_Click);
            // 
            // FormFormOfEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 409);
            this.Controls.Add(this.btnFormOfEducation);
            this.Controls.Add(this.gBoxFormDepartment);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFormOfEducation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма на обучение";
            this.Load += new System.EventHandler(this.FormFormOfEducation_Load);
            this.gBoxFormDepartment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dwFormOfEducation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFormOfEducation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxFormDepartment;
        private System.Windows.Forms.DataGridView dwFormOfEducation;
        private System.Windows.Forms.Button btnFormOfEducation;
        public System.Windows.Forms.BindingSource bsFormOfEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}