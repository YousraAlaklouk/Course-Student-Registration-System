namespace Course_Student_Registration_System
{
    partial class reporting1
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
            this.gridStuSrch = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.combSrch = new System.Windows.Forms.ComboBox();
            this.txtStuSrch = new System.Windows.Forms.TextBox();
            this.butRlod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridStuSrch)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStuSrch
            // 
            this.gridStuSrch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStuSrch.Location = new System.Drawing.Point(27, 156);
            this.gridStuSrch.Name = "gridStuSrch";
            this.gridStuSrch.RowHeadersWidth = 62;
            this.gridStuSrch.RowTemplate.Height = 33;
            this.gridStuSrch.Size = new System.Drawing.Size(937, 420);
            this.gridStuSrch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By ";
            // 
            // combSrch
            // 
            this.combSrch.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.combSrch.FormattingEnabled = true;
            this.combSrch.Items.AddRange(new object[] {
            "Student Number",
            "Student Name",
            "Student Middle Name",
            "Student Last Name",
            "Student Birth Date",
            "Student Department",
            "Student Faculty",
            "Stusent Sex",
            "Student Age",
            "Student Phone Number",
            "Student Email",
            "Student Address"});
            this.combSrch.Location = new System.Drawing.Point(27, 101);
            this.combSrch.Name = "combSrch";
            this.combSrch.Size = new System.Drawing.Size(182, 29);
            this.combSrch.TabIndex = 1;
            // 
            // txtStuSrch
            // 
            this.txtStuSrch.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStuSrch.Location = new System.Drawing.Point(224, 94);
            this.txtStuSrch.Multiline = true;
            this.txtStuSrch.Name = "txtStuSrch";
            this.txtStuSrch.PlaceholderText = "Search for a student";
            this.txtStuSrch.Size = new System.Drawing.Size(599, 46);
            this.txtStuSrch.TabIndex = 2;
            // 
            // butRlod
            // 
            this.butRlod.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butRlod.Location = new System.Drawing.Point(852, 101);
            this.butRlod.Name = "butRlod";
            this.butRlod.Size = new System.Drawing.Size(112, 36);
            this.butRlod.TabIndex = 3;
            this.butRlod.Text = "&Reload";
            this.toolTip1.SetToolTip(this.butRlod, "this button will reset all the field and reload the table");
            this.butRlod.UseVisualStyleBackColor = true;
            this.butRlod.Click += new System.EventHandler(this.butRlod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(320, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search For A Student";
            // 
            // reporting1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(996, 592);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butRlod);
            this.Controls.Add(this.txtStuSrch);
            this.Controls.Add(this.combSrch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridStuSrch);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "reporting1";
            this.Text = "reporting1";
            this.Load += new System.EventHandler(this.reporting1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStuSrch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridStuSrch;
        private Label label1;
        private ComboBox combSrch;
        private TextBox txtStuSrch;
        private Button butRlod;
        private Label label2;
        private ToolTip toolTip1;
    }
}