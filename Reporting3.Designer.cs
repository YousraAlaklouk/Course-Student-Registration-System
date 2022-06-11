namespace Course_Student_Registration_System
{
    partial class Reporting3
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
            this.label2 = new System.Windows.Forms.Label();
            this.butRlod = new System.Windows.Forms.Button();
            this.txtSrchCrs = new System.Windows.Forms.TextBox();
            this.combSrch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCrsSrch = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrsSrch)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(341, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Search For A Course";
            // 
            // butRlod
            // 
            this.butRlod.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butRlod.Location = new System.Drawing.Point(873, 110);
            this.butRlod.Name = "butRlod";
            this.butRlod.Size = new System.Drawing.Size(112, 36);
            this.butRlod.TabIndex = 3;
            this.butRlod.Text = "&Reload";
            this.butRlod.UseVisualStyleBackColor = true;
            this.butRlod.Click += new System.EventHandler(this.butRlod_Click);
            // 
            // txtSrchCrs
            // 
            this.txtSrchCrs.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSrchCrs.Location = new System.Drawing.Point(245, 103);
            this.txtSrchCrs.Multiline = true;
            this.txtSrchCrs.Name = "txtSrchCrs";
            this.txtSrchCrs.PlaceholderText = "Search for a Course";
            this.txtSrchCrs.Size = new System.Drawing.Size(599, 46);
            this.txtSrchCrs.TabIndex = 2;
            this.txtSrchCrs.TextChanged += new System.EventHandler(this.txtSrchCrs_TextChanged);
            // 
            // combSrch
            // 
            this.combSrch.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.combSrch.FormattingEnabled = true;
            this.combSrch.Items.AddRange(new object[] {
            "CourseID",
            "Course Name ",
            "Course Title",
            "Course Credit",
            "Course State",
            "Course Descreption",
            "Course Type",
            "Instrector Giving The Course",
            "Opened Courses Start",
            "Opened Courses Finish",
            "Opened Courses Price For Per Month",
            "Opened Courses Room",
            "Opened Courses Days",
            "Opened Courses Time"});
            this.combSrch.Location = new System.Drawing.Point(48, 110);
            this.combSrch.Name = "combSrch";
            this.combSrch.Size = new System.Drawing.Size(182, 29);
            this.combSrch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search By ";
            // 
            // gridCrsSrch
            // 
            this.gridCrsSrch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCrsSrch.Location = new System.Drawing.Point(48, 165);
            this.gridCrsSrch.Name = "gridCrsSrch";
            this.gridCrsSrch.RowHeadersWidth = 62;
            this.gridCrsSrch.RowTemplate.Height = 33;
            this.gridCrsSrch.Size = new System.Drawing.Size(937, 420);
            this.gridCrsSrch.TabIndex = 4;
            // 
            // Reporting3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1032, 621);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butRlod);
            this.Controls.Add(this.txtSrchCrs);
            this.Controls.Add(this.combSrch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridCrsSrch);
            this.Name = "Reporting3";
            this.Text = "Reporting3";
            this.Load += new System.EventHandler(this.Reporting3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrsSrch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Button butRlod;
        private TextBox txtSrchCrs;
        private ComboBox combSrch;
        private Label label1;
        private DataGridView gridCrsSrch;
        private ToolTip toolTip1;
    }
}