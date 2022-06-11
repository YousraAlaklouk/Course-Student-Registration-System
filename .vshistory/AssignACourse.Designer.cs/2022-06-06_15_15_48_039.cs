namespace Course_Student_Registration_System
{
    partial class AssignACourse
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labSurname = new System.Windows.Forms.Label();
            this.searchBut = new System.Windows.Forms.Button();
            this.txtStdNm = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridCrs = new System.Windows.Forms.DataGridView();
            this.combCrs = new System.Windows.Forms.ComboBox();
            this.assignBut = new System.Windows.Forms.Button();
            this.resBut = new System.Windows.Forms.Button();
            this.cancBut = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(292, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign To A Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Number";
            // 
            // labStNam
            // 
            this.labStNam.AutoSize = true;
            this.labStNam.Location = new System.Drawing.Point(212, 243);
            this.labStNam.Name = "labStNam";
            this.labStNam.Size = new System.Drawing.Size(0, 21);
            this.labStNam.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choose A Course";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Student Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labSurname);
            this.groupBox1.Controls.Add(this.searchBut);
            this.groupBox1.Controls.Add(this.txtStdNm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labStNam);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // labSurname
            // 
            this.labSurname.AutoSize = true;
            this.labSurname.Location = new System.Drawing.Point(286, 243);
            this.labSurname.Name = "labSurname";
            this.labSurname.Size = new System.Drawing.Size(0, 21);
            this.labSurname.TabIndex = 6;
            // 
            // searchBut
            // 
            this.searchBut.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBut.Location = new System.Drawing.Point(91, 157);
            this.searchBut.Name = "searchBut";
            this.searchBut.Size = new System.Drawing.Size(112, 34);
            this.searchBut.TabIndex = 3;
            this.searchBut.Text = "&Search";
            this.toolTip1.SetToolTip(this.searchBut, "When you click here , the name and the student level will be found and shown ");
            this.searchBut.UseVisualStyleBackColor = true;
            this.searchBut.Click += new System.EventHandler(this.searchBut_Click);
            // 
            // txtStdNm
            // 
            this.txtStdNm.Location = new System.Drawing.Point(181, 79);
            this.txtStdNm.Name = "txtStdNm";
            this.txtStdNm.Size = new System.Drawing.Size(150, 31);
            this.txtStdNm.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridCrs);
            this.groupBox2.Controls.Add(this.combCrs);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(367, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 353);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Details";
            // 
            // gridCrs
            // 
            this.gridCrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCrs.Location = new System.Drawing.Point(17, 79);
            this.gridCrs.Name = "gridCrs";
            this.gridCrs.RowHeadersWidth = 62;
            this.gridCrs.RowTemplate.Height = 33;
            this.gridCrs.Size = new System.Drawing.Size(534, 251);
            this.gridCrs.TabIndex = 6;
            // 
            // combCrs
            // 
            this.combCrs.FormattingEnabled = true;
            this.combCrs.Location = new System.Drawing.Point(188, 40);
            this.combCrs.Name = "combCrs";
            this.combCrs.Size = new System.Drawing.Size(182, 29);
            this.combCrs.TabIndex = 5;
            // 
            // assignBut
            // 
            this.assignBut.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.assignBut.Location = new System.Drawing.Point(555, 496);
            this.assignBut.Name = "assignBut";
            this.assignBut.Size = new System.Drawing.Size(119, 46);
            this.assignBut.TabIndex = 9;
            this.assignBut.Text = "&Assign";
            this.toolTip1.SetToolTip(this.assignBut, "This button will Assign you For the chosen subject , you can not go backword late" +
        "r\r\n");
            this.assignBut.UseVisualStyleBackColor = true;
            this.assignBut.Click += new System.EventHandler(this.assignBut_Click);
            // 
            // resBut
            // 
            this.resBut.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resBut.Location = new System.Drawing.Point(394, 496);
            this.resBut.Name = "resBut";
            this.resBut.Size = new System.Drawing.Size(119, 46);
            this.resBut.TabIndex = 8;
            this.resBut.Text = "&Reset";
            this.toolTip1.SetToolTip(this.resBut, "This button will clear ALL the form ");
            this.resBut.UseVisualStyleBackColor = true;
            this.resBut.Click += new System.EventHandler(this.resBut_Click);
            // 
            // cancBut
            // 
            this.cancBut.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancBut.Location = new System.Drawing.Point(224, 496);
            this.cancBut.Name = "cancBut";
            this.cancBut.Size = new System.Drawing.Size(119, 46);
            this.cancBut.TabIndex = 7;
            this.cancBut.Text = "&Cancel";
            this.toolTip1.SetToolTip(this.cancBut, " this button for cancelling the opretation");
            this.cancBut.UseVisualStyleBackColor = true;
            this.cancBut.Click += new System.EventHandler(this.cancBut_Click);
            // 
            // AssignACourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(959, 573);
            this.Controls.Add(this.cancBut);
            this.Controls.Add(this.resBut);
            this.Controls.Add(this.assignBut);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AssignACourse";
            this.Text = "AssignACourse";
            this.Load += new System.EventHandler(this.AssignACourse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labStNam;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView gridCrs;
        private ComboBox combCrs;
        private Button searchBut;
        private TextBox txtStdNm;
        private Button assignBut;
        private Button resBut;
        private Button cancBut;
        private ToolTip toolTip1;
        private Label labSurname;
    }
}