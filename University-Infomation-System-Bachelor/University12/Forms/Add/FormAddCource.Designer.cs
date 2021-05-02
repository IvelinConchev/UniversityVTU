namespace University12.Forms.Add
{
    partial class FormCourceAdd
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
            this.gBoxFormAddCourse = new System.Windows.Forms.GroupBox();
            this.tBoxFormAddCourse = new System.Windows.Forms.TextBox();
            this.bsCourse = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxFormAddCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFormRegistrationLectureSave
            // 
            this.btnFormRegistrationLectureSave.BackColor = System.Drawing.Color.White;
            this.btnFormRegistrationLectureSave.Location = new System.Drawing.Point(43, 75);
            this.btnFormRegistrationLectureSave.Name = "btnFormRegistrationLectureSave";
            this.btnFormRegistrationLectureSave.Size = new System.Drawing.Size(104, 39);
            this.btnFormRegistrationLectureSave.TabIndex = 34;
            this.btnFormRegistrationLectureSave.Text = "Запис";
            this.btnFormRegistrationLectureSave.UseVisualStyleBackColor = false;
            this.btnFormRegistrationLectureSave.Click += new System.EventHandler(this.btnFormRegistrationLectureSave_Click);
            // 
            // gBoxFormAddCourse
            // 
            this.gBoxFormAddCourse.Controls.Add(this.tBoxFormAddCourse);
            this.gBoxFormAddCourse.Location = new System.Drawing.Point(12, 12);
            this.gBoxFormAddCourse.Name = "gBoxFormAddCourse";
            this.gBoxFormAddCourse.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormAddCourse.TabIndex = 33;
            this.gBoxFormAddCourse.TabStop = false;
            this.gBoxFormAddCourse.Text = "Име на курс";
            // 
            // tBoxFormAddCourse
            // 
            this.tBoxFormAddCourse.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tBoxFormAddCourse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCourse, "NameCourse", true));
            this.tBoxFormAddCourse.Location = new System.Drawing.Point(6, 19);
            this.tBoxFormAddCourse.Name = "tBoxFormAddCourse";
            this.tBoxFormAddCourse.Size = new System.Drawing.Size(160, 20);
            this.tBoxFormAddCourse.TabIndex = 0;
            // 
            // bsCourse
            // 
            this.bsCourse.AllowNew = false;
            this.bsCourse.DataSource = typeof(University12.Classes.TCourse);
            // 
            // FormCourceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 131);
            this.Controls.Add(this.btnFormRegistrationLectureSave);
            this.Controls.Add(this.gBoxFormAddCourse);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCourceAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курс";
            this.Load += new System.EventHandler(this.FormAddCourse_Load);
            this.gBoxFormAddCourse.ResumeLayout(false);
            this.gBoxFormAddCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormRegistrationLectureSave;
        private System.Windows.Forms.GroupBox gBoxFormAddCourse;
        private System.Windows.Forms.TextBox tBoxFormAddCourse;
        public System.Windows.Forms.BindingSource bsCourse;
    }
}