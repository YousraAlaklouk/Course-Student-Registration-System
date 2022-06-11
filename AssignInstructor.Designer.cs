namespace Course_Student_Registration_System
{
    partial class AssignInstructor
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
            this.resButt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab1Ins1Nm = new System.Windows.Forms.Label();
            this.labIns1Nm = new System.Windows.Forms.Label();
            this.combInstN1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labInst1 = new System.Windows.Forms.Label();
            this.checkInst1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butAs = new System.Windows.Forms.Button();
            this.cancButt = new System.Windows.Forms.Button();
            this.combCrs = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resButt
            // 
            this.resButt.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resButt.Location = new System.Drawing.Point(335, 401);
            this.resButt.Name = "resButt";
            this.resButt.Size = new System.Drawing.Size(130, 45);
            this.resButt.TabIndex = 26;
            this.resButt.Text = "&Reset";
            this.resButt.UseVisualStyleBackColor = true;
            this.resButt.Click += new System.EventHandler(this.resButt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab1Ins1Nm);
            this.groupBox1.Controls.Add(this.labIns1Nm);
            this.groupBox1.Controls.Add(this.combInstN1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labInst1);
            this.groupBox1.Controls.Add(this.checkInst1);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(128, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 244);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course\'s Intructor Information";
            // 
            // lab1Ins1Nm
            // 
            this.lab1Ins1Nm.AutoSize = true;
            this.lab1Ins1Nm.ForeColor = System.Drawing.Color.Indigo;
            this.lab1Ins1Nm.Location = new System.Drawing.Point(30, 175);
            this.lab1Ins1Nm.Name = "lab1Ins1Nm";
            this.lab1Ins1Nm.Size = new System.Drawing.Size(178, 21);
            this.lab1Ins1Nm.TabIndex = 24;
            this.lab1Ins1Nm.Text = "Instructor Number";
            // 
            // labIns1Nm
            // 
            this.labIns1Nm.AutoSize = true;
            this.labIns1Nm.ForeColor = System.Drawing.Color.Indigo;
            this.labIns1Nm.Location = new System.Drawing.Point(282, 175);
            this.labIns1Nm.Name = "labIns1Nm";
            this.labIns1Nm.Size = new System.Drawing.Size(0, 21);
            this.labIns1Nm.TabIndex = 21;
            // 
            // combInstN1
            // 
            this.combInstN1.FormattingEnabled = true;
            this.combInstN1.Location = new System.Drawing.Point(282, 134);
            this.combInstN1.Name = "combInstN1";
            this.combInstN1.Size = new System.Drawing.Size(182, 29);
            this.combInstN1.TabIndex = 8;
            this.combInstN1.SelectedIndexChanged += new System.EventHandler(this.combInstN1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Course Instructor(s)";
            // 
            // labInst1
            // 
            this.labInst1.AutoSize = true;
            this.labInst1.Location = new System.Drawing.Point(24, 137);
            this.labInst1.Name = "labInst1";
            this.labInst1.Size = new System.Drawing.Size(227, 21);
            this.labInst1.TabIndex = 3;
            this.labInst1.Text = "Course Instructor Name";
            // 
            // checkInst1
            // 
            this.checkInst1.AutoSize = true;
            this.checkInst1.Checked = true;
            this.checkInst1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkInst1.Enabled = false;
            this.checkInst1.Location = new System.Drawing.Point(24, 91);
            this.checkInst1.Name = "checkInst1";
            this.checkInst1.Size = new System.Drawing.Size(132, 25);
            this.checkInst1.TabIndex = 7;
            this.checkInst1.Text = "Instructor ";
            this.checkInst1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(152, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Choose A Course";
            // 
            // butAs
            // 
            this.butAs.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butAs.Location = new System.Drawing.Point(502, 403);
            this.butAs.Name = "butAs";
            this.butAs.Size = new System.Drawing.Size(122, 41);
            this.butAs.TabIndex = 27;
            this.butAs.Text = "&Assign";
            this.butAs.UseVisualStyleBackColor = true;
            this.butAs.Click += new System.EventHandler(this.butAs_Click);
            // 
            // cancButt
            // 
            this.cancButt.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancButt.Location = new System.Drawing.Point(139, 403);
            this.cancButt.Name = "cancButt";
            this.cancButt.Size = new System.Drawing.Size(129, 45);
            this.cancButt.TabIndex = 28;
            this.cancButt.Text = "Cance&l";
            this.cancButt.UseVisualStyleBackColor = true;
            this.cancButt.Click += new System.EventHandler(this.cancButt_Click);
            // 
            // combCrs
            // 
            this.combCrs.FormattingEnabled = true;
            this.combCrs.Location = new System.Drawing.Point(336, 41);
            this.combCrs.Name = "combCrs";
            this.combCrs.Size = new System.Drawing.Size(182, 33);
            this.combCrs.TabIndex = 30;
            // 
            // AssignInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(763, 506);
            this.Controls.Add(this.combCrs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancButt);
            this.Controls.Add(this.resButt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butAs);
            this.Name = "AssignInstructor";
            this.Text = "AssignInstructor";
            this.Load += new System.EventHandler(this.AssignInstructor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button resButt;
        private GroupBox groupBox1;
        private Label label4;
        private Button butAs;
        private Label lab1Ins1Nm;
        private Label labIns1Nm;
        private ComboBox combInstN1;
        private Label label9;
        private Label labInst1;
        private CheckBox checkInst1;
        private Button cancButt;
        private ComboBox combCrs;
    }
}