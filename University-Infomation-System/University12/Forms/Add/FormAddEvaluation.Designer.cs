namespace University12.Forms.Add
{
    partial class FormAddEvaluation
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
            this.gBoxFormAddEvaluation = new System.Windows.Forms.GroupBox();
            this.tBoxFormAddEvaluation = new System.Windows.Forms.TextBox();
            this.bsEvaluation = new System.Windows.Forms.BindingSource(this.components);
            this.tSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxFormAddEvaluation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvaluation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSubjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFormRegistrationLectureSave
            // 
            this.btnFormRegistrationLectureSave.BackColor = System.Drawing.Color.White;
            this.btnFormRegistrationLectureSave.Location = new System.Drawing.Point(53, 85);
            this.btnFormRegistrationLectureSave.Name = "btnFormRegistrationLectureSave";
            this.btnFormRegistrationLectureSave.Size = new System.Drawing.Size(91, 35);
            this.btnFormRegistrationLectureSave.TabIndex = 38;
            this.btnFormRegistrationLectureSave.Text = "Запис";
            this.btnFormRegistrationLectureSave.UseVisualStyleBackColor = false;
            this.btnFormRegistrationLectureSave.Click += new System.EventHandler(this.btnFormRegistrationLectureSave_Click);
            // 
            // gBoxFormAddEvaluation
            // 
            this.gBoxFormAddEvaluation.Controls.Add(this.tBoxFormAddEvaluation);
            this.gBoxFormAddEvaluation.Location = new System.Drawing.Point(12, 12);
            this.gBoxFormAddEvaluation.Name = "gBoxFormAddEvaluation";
            this.gBoxFormAddEvaluation.Size = new System.Drawing.Size(186, 48);
            this.gBoxFormAddEvaluation.TabIndex = 37;
            this.gBoxFormAddEvaluation.TabStop = false;
            this.gBoxFormAddEvaluation.Text = "Оценка";
            // 
            // tBoxFormAddEvaluation
            // 
            this.tBoxFormAddEvaluation.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tBoxFormAddEvaluation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEvaluation, "Number", true));
            this.tBoxFormAddEvaluation.Location = new System.Drawing.Point(6, 19);
            this.tBoxFormAddEvaluation.Name = "tBoxFormAddEvaluation";
            this.tBoxFormAddEvaluation.Size = new System.Drawing.Size(174, 20);
            this.tBoxFormAddEvaluation.TabIndex = 0;
            // 
            // bsEvaluation
            // 
            this.bsEvaluation.DataSource = typeof(University12.Classes.TEvaluation);
            // 
            // tSubjectBindingSource
            // 
            this.tSubjectBindingSource.DataSource = typeof(University12.Classes.TSubject);
            // 
            // FormAddEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 130);
            this.Controls.Add(this.btnFormRegistrationLectureSave);
            this.Controls.Add(this.gBoxFormAddEvaluation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEvaluation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оценяване";
            this.Load += new System.EventHandler(this.FormAddEvaluation_Load);
            this.gBoxFormAddEvaluation.ResumeLayout(false);
            this.gBoxFormAddEvaluation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvaluation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSubjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormRegistrationLectureSave;
        private System.Windows.Forms.GroupBox gBoxFormAddEvaluation;
        private System.Windows.Forms.TextBox tBoxFormAddEvaluation;
        public System.Windows.Forms.BindingSource bsEvaluation;
        private System.Windows.Forms.BindingSource tSubjectBindingSource;
    }
}