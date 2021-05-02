namespace University12.Forms.Add
{
    partial class FormAddFormOfEducations
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
            this.gBoxFormAddEducations = new System.Windows.Forms.GroupBox();
            this.tBoxFormAddEducations = new System.Windows.Forms.TextBox();
            this.bsFormOfEducation = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxFormAddEducations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFormOfEducation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFormRegistrationLectureSave
            // 
            this.btnFormRegistrationLectureSave.BackColor = System.Drawing.Color.White;
            this.btnFormRegistrationLectureSave.Location = new System.Drawing.Point(52, 76);
            this.btnFormRegistrationLectureSave.Name = "btnFormRegistrationLectureSave";
            this.btnFormRegistrationLectureSave.Size = new System.Drawing.Size(91, 35);
            this.btnFormRegistrationLectureSave.TabIndex = 36;
            this.btnFormRegistrationLectureSave.Text = "Запис";
            this.btnFormRegistrationLectureSave.UseVisualStyleBackColor = false;
            this.btnFormRegistrationLectureSave.Click += new System.EventHandler(this.btnFormRegistrationLectureSave_Click);
            // 
            // gBoxFormAddEducations
            // 
            this.gBoxFormAddEducations.Controls.Add(this.tBoxFormAddEducations);
            this.gBoxFormAddEducations.Location = new System.Drawing.Point(12, 12);
            this.gBoxFormAddEducations.Name = "gBoxFormAddEducations";
            this.gBoxFormAddEducations.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormAddEducations.TabIndex = 35;
            this.gBoxFormAddEducations.TabStop = false;
            this.gBoxFormAddEducations.Text = "Форма на обучение";
            // 
            // tBoxFormAddEducations
            // 
            this.tBoxFormAddEducations.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tBoxFormAddEducations.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFormOfEducation, "Name", true));
            this.tBoxFormAddEducations.Location = new System.Drawing.Point(6, 19);
            this.tBoxFormAddEducations.Name = "tBoxFormAddEducations";
            this.tBoxFormAddEducations.Size = new System.Drawing.Size(160, 20);
            this.tBoxFormAddEducations.TabIndex = 0;
            // 
            // bsFormOfEducation
            // 
            this.bsFormOfEducation.AllowNew = false;
            this.bsFormOfEducation.DataSource = typeof(University12.Classes.TFormOfEducation);
            // 
            // FormAddFormOfEducations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 125);
            this.Controls.Add(this.btnFormRegistrationLectureSave);
            this.Controls.Add(this.gBoxFormAddEducations);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddFormOfEducations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обучение";
            this.Load += new System.EventHandler(this.FormAddFormOfEducations_Load);
            this.gBoxFormAddEducations.ResumeLayout(false);
            this.gBoxFormAddEducations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFormOfEducation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormRegistrationLectureSave;
        private System.Windows.Forms.GroupBox gBoxFormAddEducations;
        private System.Windows.Forms.TextBox tBoxFormAddEducations;
        public System.Windows.Forms.BindingSource bsFormOfEducation;
    }
}