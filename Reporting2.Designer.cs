namespace Course_Student_Registration_System
{
    partial class Reporting2
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
            this.txtInsSrch = new System.Windows.Forms.TextBox();
            this.combsrch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSrchIns = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSrchIns)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(333, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search For An Instructor";
            // 
            // butRlod
            // 
            this.butRlod.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butRlod.Location = new System.Drawing.Point(861, 124);
            this.butRlod.Name = "butRlod";
            this.butRlod.Size = new System.Drawing.Size(112, 36);
            this.butRlod.TabIndex = 3;
            this.butRlod.Text = "&Reload";
            this.toolTip1.SetToolTip(this.butRlod, "this button will clear all the field and re;oad the tabel");
            this.butRlod.UseVisualStyleBackColor = true;
            this.butRlod.Click += new System.EventHandler(this.butRlod_Click);
            // 
            // txtInsSrch
            // 
            this.txtInsSrch.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInsSrch.Location = new System.Drawing.Point(233, 117);
            this.txtInsSrch.Multiline = true;
            this.txtInsSrch.Name = "txtInsSrch";
            this.txtInsSrch.PlaceholderText = "Search for an Instrector";
            this.txtInsSrch.Size = new System.Drawing.Size(599, 46);
            this.txtInsSrch.TabIndex = 2;
            this.txtInsSrch.TextChanged += new System.EventHandler(this.txtInsSrch_TextChanged);
            // 
            // combsrch
            // 
            this.combsrch.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.combsrch.FormattingEnabled = true;
            this.combsrch.Items.AddRange(new object[] {
            "Instructor Number",
            "Job Title",
            "Vacancy Number",
            "First Name",
            "Last Name",
            "Middle Name",
            "ID Number",
            "Graduation Date",
            "BirthDate",
            "Disability",
            "Email",
            "Address",
            "Phone Number",
            "Postcode",
            "Degree",
            "University Name For Bachelor",
            "University Name For Master",
            "University Name For PhD",
            "Major For Bachelor",
            "Specialized For Master",
            "Specialized For PhD",
            "Subject To Teach"});
            this.combsrch.Location = new System.Drawing.Point(36, 124);
            this.combsrch.Name = "combsrch";
            this.combsrch.Size = new System.Drawing.Size(182, 29);
            this.combsrch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search By ";
            // 
            // dataSrchIns
            // 
            this.dataSrchIns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSrchIns.Location = new System.Drawing.Point(36, 179);
            this.dataSrchIns.Name = "dataSrchIns";
            this.dataSrchIns.RowHeadersWidth = 62;
            this.dataSrchIns.RowTemplate.Height = 33;
            this.dataSrchIns.Size = new System.Drawing.Size(937, 420);
            this.dataSrchIns.TabIndex = 4;
            // 
            // Reporting2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1025, 636);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butRlod);
            this.Controls.Add(this.txtInsSrch);
            this.Controls.Add(this.combsrch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataSrchIns);
            this.Name = "Reporting2";
            this.Text = "Reporting2";
            this.Load += new System.EventHandler(this.Reporting2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSrchIns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Button butRlod;
        private TextBox txtInsSrch;
        private ComboBox combsrch;
        private Label label1;
        private DataGridView dataSrchIns;
        private ToolTip toolTip1;
    }
}