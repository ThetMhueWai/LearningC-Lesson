namespace MyFirstForm
{
    partial class UserWelcom
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
            this.lblUserWelcome = new System.Windows.Forms.Label();
            this.btnPressMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserWelcome
            // 
            this.lblUserWelcome.AutoSize = true;
            this.lblUserWelcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserWelcome.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblUserWelcome.Location = new System.Drawing.Point(64, 24);
            this.lblUserWelcome.Name = "lblUserWelcome";
            this.lblUserWelcome.Size = new System.Drawing.Size(142, 22);
            this.lblUserWelcome.TabIndex = 0;
            this.lblUserWelcome.Text = "User Welcome";
            // 
            // btnPressMe
            // 
            this.btnPressMe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPressMe.Location = new System.Drawing.Point(115, 130);
            this.btnPressMe.Name = "btnPressMe";
            this.btnPressMe.Size = new System.Drawing.Size(75, 23);
            this.btnPressMe.TabIndex = 1;
            this.btnPressMe.Text = "Press Me";
            this.btnPressMe.UseVisualStyleBackColor = false;
            this.btnPressMe.Click += new System.EventHandler(this.btnPressMe_Click);
            // 
            // UserWelcom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 275);
            this.Controls.Add(this.btnPressMe);
            this.Controls.Add(this.lblUserWelcome);
            this.Name = "UserWelcom";
            this.Text = "User Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserWelcome;
        private System.Windows.Forms.Button btnPressMe;
    }
}

