namespace MyFirstForm
{
    partial class studentrecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentrecord));
            this.gbstudent = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtdof = new System.Windows.Forms.TextBox();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblDisolay = new System.Windows.Forms.Label();
            this.btnrecord = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.gbstudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbstudent
            // 
            this.gbstudent.Controls.Add(this.comboBox1);
            this.gbstudent.Controls.Add(this.rdofemale);
            this.gbstudent.Controls.Add(this.rdomale);
            this.gbstudent.Controls.Add(this.txtdof);
            this.gbstudent.Controls.Add(this.txtName);
            this.gbstudent.Controls.Add(this.label4);
            this.gbstudent.Controls.Add(this.label3);
            this.gbstudent.Controls.Add(this.label2);
            this.gbstudent.Controls.Add(this.label1);
            this.gbstudent.Location = new System.Drawing.Point(39, 52);
            this.gbstudent.Name = "gbstudent";
            this.gbstudent.Size = new System.Drawing.Size(338, 228);
            this.gbstudent.TabIndex = 0;
            this.gbstudent.TabStop = false;
            this.gbstudent.Text = "Student Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtdof
            // 
            this.txtdof.Location = new System.Drawing.Point(175, 87);
            this.txtdof.Name = "txtdof";
            this.txtdof.Size = new System.Drawing.Size(133, 20);
            this.txtdof.TabIndex = 5;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(175, 138);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(48, 17);
            this.rdomale.TabIndex = 6;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(249, 138);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(59, 17);
            this.rdofemale.TabIndex = 7;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "L3DC",
            "L4DC",
            "L5DC",
            "Final Year"});
            this.comboBox1.Location = new System.Drawing.Point(175, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(39, 287);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "I accept the policy";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblDisolay
            // 
            this.lblDisolay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisolay.Location = new System.Drawing.Point(426, 52);
            this.lblDisolay.Name = "lblDisolay";
            this.lblDisolay.Size = new System.Drawing.Size(262, 228);
            this.lblDisolay.TabIndex = 2;
            // 
            // btnrecord
            // 
            this.btnrecord.Location = new System.Drawing.Point(472, 296);
            this.btnrecord.Name = "btnrecord";
            this.btnrecord.Size = new System.Drawing.Size(75, 23);
            this.btnrecord.TabIndex = 3;
            this.btnrecord.Text = "Record";
            this.btnrecord.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(588, 296);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // studentrecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(718, 376);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnrecord);
            this.Controls.Add(this.lblDisolay);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.gbstudent);
            this.Name = "studentrecord";
            this.Text = "studentrecord";
            this.gbstudent.ResumeLayout(false);
            this.gbstudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbstudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rdofemale;
        private System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.TextBox txtdof;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblDisolay;
        private System.Windows.Forms.Button btnrecord;
        private System.Windows.Forms.Button btnexit;
    }
}