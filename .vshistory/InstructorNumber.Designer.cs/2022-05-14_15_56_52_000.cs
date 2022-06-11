namespace Course_Student_Registration_System
{
    partial class InstructorNumber
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
            this.labInstNum = new System.Windows.Forms.Label();
            this.okButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Instructor Number Is";
            // 
            // labInstNum
            // 
            this.labInstNum.AutoSize = true;
            this.labInstNum.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labInstNum.Location = new System.Drawing.Point(317, 77);
            this.labInstNum.Name = "labInstNum";
            this.labInstNum.Size = new System.Drawing.Size(0, 21);
            this.labInstNum.TabIndex = 1;
            // 
            // okButt
            // 
            this.okButt.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.okButt.Location = new System.Drawing.Point(166, 210);
            this.okButt.Name = "okButt";
            this.okButt.Size = new System.Drawing.Size(112, 34);
            this.okButt.TabIndex = 2;
            this.okButt.Text = "&OK";
            this.okButt.UseVisualStyleBackColor = true;
            this.okButt.Click += new System.EventHandler(this.okButt_Click);
            // 
            // InstructorNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(457, 277);
            this.Controls.Add(this.okButt);
            this.Controls.Add(this.labInstNum);
            this.Controls.Add(this.label1);
            this.Name = "InstructorNumber";
            this.Text = "InstructorNumber";
            this.Load += new System.EventHandler(this.InstructorNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labInstNum;
        private Button okButt;
    }
}