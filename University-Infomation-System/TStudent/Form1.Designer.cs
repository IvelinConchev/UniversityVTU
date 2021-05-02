namespace TStudent
{
    partial class Form1
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
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxMiddleName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxEGN = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEGN = new System.Windows.Forms.Label();
            this.btnFirstName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(178, 105);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFirstName.TabIndex = 1;
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Location = new System.Drawing.Point(178, 178);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMiddleName.TabIndex = 2;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(178, 242);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLastName.TabIndex = 3;
            // 
            // txtBoxEGN
            // 
            this.txtBoxEGN.Location = new System.Drawing.Point(178, 302);
            this.txtBoxEGN.Name = "txtBoxEGN";
            this.txtBoxEGN.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEGN.TabIndex = 5;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(68, 112);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "Име";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(68, 185);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(53, 13);
            this.lblMiddleName.TabIndex = 8;
            this.lblMiddleName.Text = "Презиме";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(68, 242);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Фамилия";
            // 
            // lblEGN
            // 
            this.lblEGN.AutoSize = true;
            this.lblEGN.Location = new System.Drawing.Point(68, 302);
            this.lblEGN.Name = "lblEGN";
            this.lblEGN.Size = new System.Drawing.Size(28, 13);
            this.lblEGN.TabIndex = 10;
            this.lblEGN.Text = "ЕГН";
            // 
            // btnFirstName
            // 
            this.btnFirstName.Location = new System.Drawing.Point(178, 401);
            this.btnFirstName.Name = "btnFirstName";
            this.btnFirstName.Size = new System.Drawing.Size(75, 23);
            this.btnFirstName.TabIndex = 12;
            this.btnFirstName.Text = "Добави";
            this.btnFirstName.UseVisualStyleBackColor = true;
            this.btnFirstName.Click += new System.EventHandler(this.BtnFirstName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFirstName);
            this.Controls.Add(this.lblEGN);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtBoxEGN);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxMiddleName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxMiddleName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxEGN;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEGN;
        private System.Windows.Forms.Button btnFirstName;
    }
}

