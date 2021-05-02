namespace University12.Forms.Add
{
    partial class FormАddSpecialities
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
            this.gBoxFormAddSpeciality = new System.Windows.Forms.GroupBox();
            this.tBoxFormAddSpeciality = new System.Windows.Forms.TextBox();
            this.gBoxFaculty = new System.Windows.Forms.GroupBox();
            this.cBoxFaculty = new System.Windows.Forms.ComboBox();
            this.bsSpeciality = new System.Windows.Forms.BindingSource(this.components);
            this.tFacultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxFormAddSpeciality.SuspendLayout();
            this.gBoxFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpeciality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFacultyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFormRegistrationLectureSave
            // 
            this.btnFormRegistrationLectureSave.BackColor = System.Drawing.Color.White;
            this.btnFormRegistrationLectureSave.Location = new System.Drawing.Point(140, 66);
            this.btnFormRegistrationLectureSave.Name = "btnFormRegistrationLectureSave";
            this.btnFormRegistrationLectureSave.Size = new System.Drawing.Size(91, 35);
            this.btnFormRegistrationLectureSave.TabIndex = 34;
            this.btnFormRegistrationLectureSave.Text = "Запис";
            this.btnFormRegistrationLectureSave.UseVisualStyleBackColor = false;
            this.btnFormRegistrationLectureSave.Click += new System.EventHandler(this.BtnFormRegistrationLectureSave_Click);
            // 
            // gBoxFormAddSpeciality
            // 
            this.gBoxFormAddSpeciality.Controls.Add(this.tBoxFormAddSpeciality);
            this.gBoxFormAddSpeciality.Location = new System.Drawing.Point(12, 12);
            this.gBoxFormAddSpeciality.Name = "gBoxFormAddSpeciality";
            this.gBoxFormAddSpeciality.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormAddSpeciality.TabIndex = 33;
            this.gBoxFormAddSpeciality.TabStop = false;
            this.gBoxFormAddSpeciality.Text = "Специалност";
            // 
            // tBoxFormAddSpeciality
            // 
            this.tBoxFormAddSpeciality.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tBoxFormAddSpeciality.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSpeciality, "NameSpeciality", true));
            this.tBoxFormAddSpeciality.Location = new System.Drawing.Point(6, 19);
            this.tBoxFormAddSpeciality.Name = "tBoxFormAddSpeciality";
            this.tBoxFormAddSpeciality.Size = new System.Drawing.Size(160, 20);
            this.tBoxFormAddSpeciality.TabIndex = 0;
            // 
            // gBoxFaculty
            // 
            this.gBoxFaculty.Controls.Add(this.cBoxFaculty);
            this.gBoxFaculty.Location = new System.Drawing.Point(190, 12);
            this.gBoxFaculty.Name = "gBoxFaculty";
            this.gBoxFaculty.Size = new System.Drawing.Size(187, 48);
            this.gBoxFaculty.TabIndex = 38;
            this.gBoxFaculty.TabStop = false;
            this.gBoxFaculty.Text = "Факултет";
            // 
            // cBoxFaculty
            // 
            this.cBoxFaculty.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxFaculty.FormattingEnabled = true;
            this.cBoxFaculty.Location = new System.Drawing.Point(6, 18);
            this.cBoxFaculty.Name = "cBoxFaculty";
            this.cBoxFaculty.Size = new System.Drawing.Size(171, 21);
            this.cBoxFaculty.TabIndex = 1;
            // 
            // bsSpeciality
            // 
            this.bsSpeciality.AllowNew = false;
            this.bsSpeciality.DataSource = typeof(University12.Classes.TSpeciality);
            // 
            // tFacultyBindingSource
            // 
            this.tFacultyBindingSource.DataSource = typeof(University12.Classes.TFaculty);
            // 
            // FormАddSpecialities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 123);
            this.Controls.Add(this.gBoxFaculty);
            this.Controls.Add(this.btnFormRegistrationLectureSave);
            this.Controls.Add(this.gBoxFormAddSpeciality);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tFacultyBindingSource, "FacultyName", true));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormАddSpecialities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Специалности";
            this.Load += new System.EventHandler(this.FormАddSpecialities_Load);
            this.gBoxFormAddSpeciality.ResumeLayout(false);
            this.gBoxFormAddSpeciality.PerformLayout();
            this.gBoxFaculty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsSpeciality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFacultyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormRegistrationLectureSave;
        private System.Windows.Forms.GroupBox gBoxFormAddSpeciality;
        private System.Windows.Forms.TextBox tBoxFormAddSpeciality;
        public System.Windows.Forms.BindingSource bsSpeciality;
        private System.Windows.Forms.GroupBox gBoxFaculty;
        private System.Windows.Forms.ComboBox cBoxFaculty;
        private System.Windows.Forms.BindingSource tFacultyBindingSource;
    }
}