namespace Course_Student_Registration_System
{
    partial class StudentNumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.labStuNum = new System.Windows.Forms.Label();
            this.okButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Student Number Is";
            // 
            // labStuNum
            // 
            this.labStuNum.AutoSize = true;
            this.labStuNum.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labStuNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labStuNum.Location = new System.Drawing.Point(324, 78);
            this.labStuNum.Name = "labStuNum";
            this.labStuNum.Size = new System.Drawing.Size(0, 21);
            this.labStuNum.TabIndex = 1;
            // 
            // okButt
            // 
            this.okButt.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.okButt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.okButt.Location = new System.Drawing.Point(155, 218);
            this.okButt.Name = "okButt";
            this.okButt.Size = new System.Drawing.Size(112, 34);
            this.okButt.TabIndex = 2;
            this.okButt.Text = "&OK";
            this.okButt.UseVisualStyleBackColor = true;
            this.okButt.Click += new System.EventHandler(this.okButt_Click);
            // 
            // StudentNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(408, 280);
            this.Controls.Add(this.okButt);
            this.Controls.Add(this.labStuNum);
            this.Controls.Add(this.label1);
            this.Name = "StudentNumber";
            this.Text = "StudentNumber";
            this.Load += new System.EventHandler(this.StudentNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labStuNum;
        private Button okButt;
    }
}