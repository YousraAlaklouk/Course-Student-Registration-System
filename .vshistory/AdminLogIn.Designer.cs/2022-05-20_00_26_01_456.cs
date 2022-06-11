namespace Course_Student_Registration_System
{
    partial class AdminLogIn
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkRememberMe = new System.Windows.Forms.CheckBox();
            this.txtEmOrUn = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cancButt = new System.Windows.Forms.Button();
            this.resButt = new System.Windows.Forms.Button();
            this.lginButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(336, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(95, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email OR UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(154, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // checkRememberMe
            // 
            this.checkRememberMe.AutoSize = true;
            this.checkRememberMe.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkRememberMe.Location = new System.Drawing.Point(336, 258);
            this.checkRememberMe.Name = "checkRememberMe";
            this.checkRememberMe.Size = new System.Drawing.Size(168, 25);
            this.checkRememberMe.TabIndex = 3;
            this.checkRememberMe.Text = "Remember Me";
            this.checkRememberMe.UseVisualStyleBackColor = true;
            // 
            // txtEmOrUn
            // 
            this.txtEmOrUn.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmOrUn.Location = new System.Drawing.Point(336, 125);
            this.txtEmOrUn.Name = "txtEmOrUn";
            this.txtEmOrUn.Size = new System.Drawing.Size(213, 31);
            this.txtEmOrUn.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPass.Location = new System.Drawing.Point(336, 188);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(213, 31);
            this.txtPass.TabIndex = 2;
            // 
            // cancButt
            // 
            this.cancButt.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancButt.Location = new System.Drawing.Point(154, 334);
            this.cancButt.Name = "cancButt";
            this.cancButt.Size = new System.Drawing.Size(129, 45);
            this.cancButt.TabIndex = 4;
            this.cancButt.Text = "&Cancel";
            this.cancButt.UseVisualStyleBackColor = true;
            this.cancButt.Click += new System.EventHandler(this.cancButt_Click);
            // 
            // resButt
            // 
            this.resButt.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resButt.Location = new System.Drawing.Point(337, 334);
            this.resButt.Name = "resButt";
            this.resButt.Size = new System.Drawing.Size(130, 45);
            this.resButt.TabIndex = 5;
            this.resButt.Text = "&Reset";
            this.resButt.UseVisualStyleBackColor = true;
            this.resButt.Click += new System.EventHandler(this.resButt_Click);
            // 
            // lginButt
            // 
            this.lginButt.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lginButt.Location = new System.Drawing.Point(508, 334);
            this.lginButt.Name = "lginButt";
            this.lginButt.Size = new System.Drawing.Size(130, 45);
            this.lginButt.TabIndex = 6;
            this.lginButt.Text = "&Login";
            this.lginButt.UseVisualStyleBackColor = true;
            this.lginButt.Click += new System.EventHandler(this.lginButt_Click);
            // 
            // AdminLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancButt);
            this.Controls.Add(this.resButt);
            this.Controls.Add(this.lginButt);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmOrUn);
            this.Controls.Add(this.checkRememberMe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminLogIn";
            this.Text = "AdminLogIn";
            this.Load += new System.EventHandler(this.AdminLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkRememberMe;
        private TextBox txtEmOrUn;
        private TextBox txtPass;
        private Button cancButt;
        private Button resButt;
        private Button lginButt;
    }
}