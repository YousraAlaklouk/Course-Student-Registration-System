namespace Course_Student_Registration_System
{
    partial class UserInterface
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
            this.stRegBut = new System.Windows.Forms.Button();
            this.instRegBut = new System.Windows.Forms.Button();
            this.butLogin = new System.Windows.Forms.Button();
            this.asnCrsBut = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.butStPay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(146, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Click on one of the buttons";
            // 
            // stRegBut
            // 
            this.stRegBut.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stRegBut.Location = new System.Drawing.Point(96, 148);
            this.stRegBut.Name = "stRegBut";
            this.stRegBut.Size = new System.Drawing.Size(264, 64);
            this.stRegBut.TabIndex = 1;
            this.stRegBut.Text = "&Student Registration Form";
            this.toolTip1.SetToolTip(this.stRegBut, "this button will go directly to to student registration form");
            this.stRegBut.UseVisualStyleBackColor = true;
            this.stRegBut.Click += new System.EventHandler(this.stRegBut_Click);
            // 
            // instRegBut
            // 
            this.instRegBut.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.instRegBut.Location = new System.Drawing.Point(406, 148);
            this.instRegBut.Name = "instRegBut";
            this.instRegBut.Size = new System.Drawing.Size(264, 64);
            this.instRegBut.TabIndex = 2;
            this.instRegBut.Text = "&Instructor Registration Form";
            this.toolTip1.SetToolTip(this.instRegBut, "this button will go directly to Instructor registration form");
            this.instRegBut.UseVisualStyleBackColor = true;
            this.instRegBut.Click += new System.EventHandler(this.instRegBut_Click);
            // 
            // butLogin
            // 
            this.butLogin.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butLogin.Location = new System.Drawing.Point(247, 350);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(264, 64);
            this.butLogin.TabIndex = 5;
            this.butLogin.Text = "&Login As An Admin";
            this.toolTip1.SetToolTip(this.butLogin, "you have an account as an Admin ? Login now !");
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // asnCrsBut
            // 
            this.asnCrsBut.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.asnCrsBut.Location = new System.Drawing.Point(96, 251);
            this.asnCrsBut.Name = "asnCrsBut";
            this.asnCrsBut.Size = new System.Drawing.Size(264, 64);
            this.asnCrsBut.TabIndex = 3;
            this.asnCrsBut.Text = "&Assign To A Course";
            this.toolTip1.SetToolTip(this.asnCrsBut, "do you have a record as a student ? then you can assign to some courses ");
            this.asnCrsBut.UseVisualStyleBackColor = true;
            this.asnCrsBut.Click += new System.EventHandler(this.asnCrsBut_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pastToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 138);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(127, 32);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(127, 32);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pastToolStripMenuItem
            // 
            this.pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            this.pastToolStripMenuItem.Size = new System.Drawing.Size(127, 32);
            this.pastToolStripMenuItem.Text = "Past";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(127, 32);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // butStPay
            // 
            this.butStPay.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butStPay.Location = new System.Drawing.Point(406, 251);
            this.butStPay.Name = "butStPay";
            this.butStPay.Size = new System.Drawing.Size(264, 64);
            this.butStPay.TabIndex = 4;
            this.butStPay.Text = "Student &Payment";
            this.toolTip1.SetToolTip(this.butStPay, "Do You have Payment to do ? click here!");
            this.butStPay.UseVisualStyleBackColor = true;
            this.butStPay.Click += new System.EventHandler(this.butStPay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Course_Student_Registration_System.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(0, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(794, 449);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.butStPay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.asnCrsBut);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.instRegBut);
            this.Controls.Add(this.stRegBut);
            this.Controls.Add(this.label1);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button stRegBut;
        private Button instRegBut;
        private Button butLogin;
        private Button asnCrsBut;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pastToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private Button butStPay;
    }
}