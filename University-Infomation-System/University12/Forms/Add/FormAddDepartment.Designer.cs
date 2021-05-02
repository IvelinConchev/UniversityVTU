namespace University12.Forms.Add
{
    partial class FormAddDepartment
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
            this.btnFormRegistrationLectureSave = new System.Windows.Forms.Button();
            this.gBoxFormAddDepartment = new System.Windows.Forms.GroupBox();
            this.tbDepartament = new System.Windows.Forms.TextBox();
            this.gBoxFaculty = new System.Windows.Forms.GroupBox();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.bsDepartament = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxFormAddDepartment.SuspendLayout();
            this.gBoxFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepartament)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFormRegistrationLectureSave
            // 
            this.btnFormRegistrationLectureSave.BackColor = System.Drawing.Color.White;
            this.btnFormRegistrationLectureSave.Location = new System.Drawing.Point(145, 78);
            this.btnFormRegistrationLectureSave.Name = "btnFormRegistrationLectureSave";
            this.btnFormRegistrationLectureSave.Size = new System.Drawing.Size(91, 35);
            this.btnFormRegistrationLectureSave.TabIndex = 36;
            this.btnFormRegistrationLectureSave.Text = "Запис";
            this.btnFormRegistrationLectureSave.UseVisualStyleBackColor = false;
            this.btnFormRegistrationLectureSave.Click += new System.EventHandler(this.btnFormRegistrationLectureSave_Click);
            // 
            // gBoxFormAddDepartment
            // 
            this.gBoxFormAddDepartment.Controls.Add(this.tbDepartament);
            this.gBoxFormAddDepartment.Location = new System.Drawing.Point(12, 12);
            this.gBoxFormAddDepartment.Name = "gBoxFormAddDepartment";
            this.gBoxFormAddDepartment.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormAddDepartment.TabIndex = 35;
            this.gBoxFormAddDepartment.TabStop = false;
            this.gBoxFormAddDepartment.Text = "Име на катедра";
            // 
            // tbDepartament
            // 
            this.tbDepartament.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tbDepartament.Location = new System.Drawing.Point(6, 19);
            this.tbDepartament.Name = "tbDepartament";
            this.tbDepartament.Size = new System.Drawing.Size(160, 20);
            this.tbDepartament.TabIndex = 0;
            // 
            // gBoxFaculty
            // 
            this.gBoxFaculty.Controls.Add(this.cbFaculty);
            this.gBoxFaculty.Location = new System.Drawing.Point(190, 12);
            this.gBoxFaculty.Name = "gBoxFaculty";
            this.gBoxFaculty.Size = new System.Drawing.Size(187, 48);
            this.gBoxFaculty.TabIndex = 37;
            this.gBoxFaculty.TabStop = false;
            this.gBoxFaculty.Text = "Факултет";
            // 
            // cbFaculty
            // 
            this.cbFaculty.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbFaculty.FormattingEnabled = true;
            this.cbFaculty.Location = new System.Drawing.Point(6, 18);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(171, 21);
            this.cbFaculty.TabIndex = 1;
            // 
            // bsDepartament
            // 
            this.bsDepartament.AllowNew = false;
            this.bsDepartament.DataSource = typeof(University12.Classes.TDepartments);
            // 
            // FormAddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 132);
            this.Controls.Add(this.gBoxFaculty);
            this.Controls.Add(this.btnFormRegistrationLectureSave);
            this.Controls.Add(this.gBoxFormAddDepartment);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Катедра";
            this.Load += new System.EventHandler(this.FormAddDepartment_Load);
            this.gBoxFormAddDepartment.ResumeLayout(false);
            this.gBoxFormAddDepartment.PerformLayout();
            this.gBoxFaculty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsDepartament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormRegistrationLectureSave;
        private System.Windows.Forms.GroupBox gBoxFormAddDepartment;
        private System.Windows.Forms.TextBox tbDepartament;
        private System.Windows.Forms.GroupBox gBoxFaculty;
        private System.Windows.Forms.ComboBox cbFaculty;
        public System.Windows.Forms.BindingSource bsDepartament;
    }
}