namespace University12.Forms
{
    partial class FormExam
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
            this.btnExamAdd = new System.Windows.Forms.Button();
            this.gBoxExam = new System.Windows.Forms.GroupBox();
            this.dataGridViewExam = new System.Windows.Forms.DataGridView();
            this.gBoxExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExamAdd
            // 
            this.btnExamAdd.BackColor = System.Drawing.Color.White;
            this.btnExamAdd.Location = new System.Drawing.Point(361, 17);
            this.btnExamAdd.Name = "btnExamAdd";
            this.btnExamAdd.Size = new System.Drawing.Size(91, 35);
            this.btnExamAdd.TabIndex = 0;
            this.btnExamAdd.Text = "Добави";
            this.btnExamAdd.UseVisualStyleBackColor = false;
            this.btnExamAdd.Click += new System.EventHandler(this.btnExamAdd_Click);
            // 
            // gBoxExam
            // 
            this.gBoxExam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxExam.Controls.Add(this.dataGridViewExam);
            this.gBoxExam.Location = new System.Drawing.Point(6, 58);
            this.gBoxExam.Name = "gBoxExam";
            this.gBoxExam.Size = new System.Drawing.Size(459, 351);
            this.gBoxExam.TabIndex = 1;
            this.gBoxExam.TabStop = false;
            this.gBoxExam.Text = "Изпити";
            // 
            // dataGridViewExam
            // 
            this.dataGridViewExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExam.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewExam.Name = "dataGridViewExam";
            this.dataGridViewExam.Size = new System.Drawing.Size(453, 332);
            this.dataGridViewExam.TabIndex = 0;
            this.dataGridViewExam.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewExam_CellDoubleClick);
            // 
            // FormExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 405);
            this.Controls.Add(this.gBoxExam);
            this.Controls.Add(this.btnExamAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изпити";
            this.gBoxExam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExamAdd;
        private System.Windows.Forms.GroupBox gBoxExam;
        private System.Windows.Forms.DataGridView dataGridViewExam;
    }
}