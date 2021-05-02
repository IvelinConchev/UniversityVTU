namespace University12.Forms
{
    partial class FormDepartments
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
            this.dgDepartments = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HeadОfDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDepartments = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.gBoxFormDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxFormDepartment
            // 
            this.gBoxFormDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxFormDepartment.Controls.Add(this.dgDepartments);
            this.gBoxFormDepartment.Location = new System.Drawing.Point(3, 53);
            this.gBoxFormDepartment.Name = "gBoxFormDepartment";
            this.gBoxFormDepartment.Size = new System.Drawing.Size(445, 354);
            this.gBoxFormDepartment.TabIndex = 0;
            this.gBoxFormDepartment.TabStop = false;
            this.gBoxFormDepartment.Text = "Катедри";
            // 
            // dgDepartments
            // 
            this.dgDepartments.AllowUserToAddRows = false;
            this.dgDepartments.AllowUserToDeleteRows = false;
            this.dgDepartments.AutoGenerateColumns = false;
            this.dgDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nameDataGridViewTextBoxColumn,
            this.Column1,
            this.HeadОfDepartmentName});
            this.dgDepartments.DataSource = this.bsDepartments;
            this.dgDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDepartments.Location = new System.Drawing.Point(3, 16);
            this.dgDepartments.Name = "dgDepartments";
            this.dgDepartments.ReadOnly = true;
            this.dgDepartments.RowHeadersWidth = 10;
            this.dgDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDepartments.Size = new System.Drawing.Size(439, 335);
            this.dgDepartments.TabIndex = 0;
            this.dgDepartments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFormDepartments_CellClick);
            this.dgDepartments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewFormDepartments_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "№";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 20;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Име";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Информация";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // HeadОfDepartmentName
            // 
            this.HeadОfDepartmentName.DataPropertyName = "HeadОfDepartmentName";
            this.HeadОfDepartmentName.HeaderText = "Ръководител катедра";
            this.HeadОfDepartmentName.Name = "HeadОfDepartmentName";
            this.HeadОfDepartmentName.ReadOnly = true;
            // 
            // bsDepartments
            // 
            this.bsDepartments.AllowNew = false;
            this.bsDepartments.DataSource = typeof(University12.Classes.TDepartments);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(354, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добави";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gBoxFormDepartment);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDepartments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Катедри";
            this.Load += new System.EventHandler(this.FormDepartments_Load);
            this.gBoxFormDepartment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepartments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxFormDepartment;
        private System.Windows.Forms.DataGridView dgDepartments;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.BindingSource bsDepartments;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeadОfDepartmentName;
    }
}