namespace University12.Forms.Add
{
    partial class FormAddExam
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
            this.gBoxFormAddExam = new System.Windows.Forms.GroupBox();
            this.tBoxFormAddExam = new System.Windows.Forms.TextBox();
            this.bsExam = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxFormAddExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsExam)).BeginInit();
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
            // 
            // gBoxFormAddExam
            // 
            this.gBoxFormAddExam.Controls.Add(this.tBoxFormAddExam);
            this.gBoxFormAddExam.Location = new System.Drawing.Point(12, 12);
            this.gBoxFormAddExam.Name = "gBoxFormAddExam";
            this.gBoxFormAddExam.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormAddExam.TabIndex = 35;
            this.gBoxFormAddExam.TabStop = false;
            this.gBoxFormAddExam.Text = "Изпити";
            // 
            // tBoxFormAddExam
            // 
            this.tBoxFormAddExam.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tBoxFormAddExam.Location = new System.Drawing.Point(6, 19);
            this.tBoxFormAddExam.Name = "tBoxFormAddExam";
            this.tBoxFormAddExam.Size = new System.Drawing.Size(160, 20);
            this.tBoxFormAddExam.TabIndex = 0;
            // 
            // bsExam
            // 
            this.bsExam.AllowNew = false;
            // 
            // FormAddExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 117);
            this.Controls.Add(this.btnFormRegistrationLectureSave);
            this.Controls.Add(this.gBoxFormAddExam);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изпити";
            this.gBoxFormAddExam.ResumeLayout(false);
            this.gBoxFormAddExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsExam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormRegistrationLectureSave;
        private System.Windows.Forms.GroupBox gBoxFormAddExam;
        private System.Windows.Forms.TextBox tBoxFormAddExam;
        public System.Windows.Forms.BindingSource bsExam;
    }
}