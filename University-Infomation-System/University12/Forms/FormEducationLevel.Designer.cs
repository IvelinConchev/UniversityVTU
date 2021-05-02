namespace University12.Forms
{
    partial class FormEducationLevel
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
            this.gBoxEducation = new System.Windows.Forms.GroupBox();
            this.btnEducationAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gBoxEducation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxEducation
            // 
            this.gBoxEducation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxEducation.Controls.Add(this.dataGridView1);
            this.gBoxEducation.Location = new System.Drawing.Point(3, 53);
            this.gBoxEducation.Name = "gBoxEducation";
            this.gBoxEducation.Size = new System.Drawing.Size(422, 374);
            this.gBoxEducation.TabIndex = 4;
            this.gBoxEducation.TabStop = false;
            this.gBoxEducation.Text = "Oбразувателна степен";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(416, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormEducationLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 431);
            this.Controls.Add(this.btnEducationAdd);
            this.Controls.Add(this.gBoxEducation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEducationLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oбразувателна степен";
            this.Load += new System.EventHandler(this.FormEducation_Load);
            this.gBoxEducation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gBoxEducation;
        private System.Windows.Forms.Button btnEducationAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}