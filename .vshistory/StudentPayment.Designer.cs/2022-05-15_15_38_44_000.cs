namespace Course_Student_Registration_System
{
    partial class StudentPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labStNam = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStNm = new System.Windows.Forms.TextBox();
            this.cancButt = new System.Windows.Forms.Button();
            this.resButt = new System.Windows.Forms.Button();
            this.payButt = new System.Windows.Forms.Button();
            this.txtPay = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(119, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(139, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // labStNam
            // 
            this.labStNam.AutoSize = true;
            this.labStNam.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labStNam.Location = new System.Drawing.Point(342, 193);
            this.labStNam.Name = "labStNam";
            this.labStNam.Size = new System.Drawing.Size(0, 21);
            this.labStNam.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(64, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount You Want To Add";
            // 
            // txtStNm
            // 
            this.txtStNm.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStNm.Location = new System.Drawing.Point(342, 97);
            this.txtStNm.Name = "txtStNm";
            this.txtStNm.Size = new System.Drawing.Size(150, 31);
            this.txtStNm.TabIndex = 1;
            // 
            // cancButt
            // 
            this.cancButt.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancButt.Location = new System.Drawing.Point(119, 353);
            this.cancButt.Name = "cancButt";
            this.cancButt.Size = new System.Drawing.Size(129, 45);
            this.cancButt.TabIndex = 3;
            this.cancButt.Text = "&Cancel";
            this.toolTip1.SetToolTip(this.cancButt, "this button will cancel your process and close this page");
            this.cancButt.UseVisualStyleBackColor = true;
            this.cancButt.Click += new System.EventHandler(this.cancButt_Click);
            // 
            // resButt
            // 
            this.resButt.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resButt.Location = new System.Drawing.Point(302, 353);
            this.resButt.Name = "resButt";
            this.resButt.Size = new System.Drawing.Size(130, 45);
            this.resButt.TabIndex = 4;
            this.resButt.Text = "&Reset";
            this.toolTip1.SetToolTip(this.resButt, "this button will reset all the field");
            this.resButt.UseVisualStyleBackColor = true;
            this.resButt.Click += new System.EventHandler(this.resButt_Click);
            // 
            // payButt
            // 
            this.payButt.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.payButt.Location = new System.Drawing.Point(473, 353);
            this.payButt.Name = "payButt";
            this.payButt.Size = new System.Drawing.Size(130, 45);
            this.payButt.TabIndex = 5;
            this.payButt.Text = "&Add";
            this.toolTip1.SetToolTip(this.payButt, "this button will submit and pay the amount you wrote");
            this.payButt.UseVisualStyleBackColor = true;
            this.payButt.Click += new System.EventHandler(this.payButt_Click);
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(342, 266);
            this.txtPay.Mask = "$#,###,###.###";
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(150, 31);
            this.txtPay.TabIndex = 2;
            // 
            // StudentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.cancButt);
            this.Controls.Add(this.resButt);
            this.Controls.Add(this.payButt);
            this.Controls.Add(this.txtStNm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labStNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentPayment";
            this.Text = "StudentPayment";
            this.Load += new System.EventHandler(this.StudentPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labStNam;
        private Label label6;
        private TextBox txtStNm;
        private Button cancButt;
        private Button resButt;
        private Button payButt;
        private MaskedTextBox txtPay;
        private ToolTip toolTip1;
    }
}