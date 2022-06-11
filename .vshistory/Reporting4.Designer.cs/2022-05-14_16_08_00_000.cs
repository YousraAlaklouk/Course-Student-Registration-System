namespace Course_Student_Registration_System
{
    partial class Reporting4
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
            this.txtStu = new System.Windows.Forms.MaskedTextBox();
            this.txtInst = new System.Windows.Forms.MaskedTextBox();
            this.txtCrs = new System.Windows.Forms.MaskedTextBox();
            this.txtCrsDat = new System.Windows.Forms.MaskedTextBox();
            this.gridRep = new System.Windows.Forms.DataGridView();
            this.reloadbut = new System.Windows.Forms.Button();
            this.radioStu = new System.Windows.Forms.RadioButton();
            this.radioCrs = new System.Windows.Forms.RadioButton();
            this.radioInst = new System.Windows.Forms.RadioButton();
            this.radioCrsDat = new System.Windows.Forms.RadioButton();
            this.labStu = new System.Windows.Forms.Label();
            this.labcrs = new System.Windows.Forms.Label();
            this.labIns = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridRep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(366, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report Screen";
            // 
            // txtStu
            // 
            this.txtStu.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStu.Location = new System.Drawing.Point(40, 136);
            this.txtStu.Mask = "00000";
            this.txtStu.Name = "txtStu";
            this.txtStu.Size = new System.Drawing.Size(150, 31);
            this.txtStu.TabIndex = 2;
            this.txtStu.ValidatingType = typeof(int);
            // 
            // txtInst
            // 
            this.txtInst.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInst.Location = new System.Drawing.Point(451, 136);
            this.txtInst.Mask = "00000";
            this.txtInst.Name = "txtInst";
            this.txtInst.Size = new System.Drawing.Size(150, 31);
            this.txtInst.TabIndex = 4;
            this.txtInst.ValidatingType = typeof(int);
            // 
            // txtCrs
            // 
            this.txtCrs.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCrs.Location = new System.Drawing.Point(40, 246);
            this.txtCrs.Mask = "00000";
            this.txtCrs.Name = "txtCrs";
            this.txtCrs.Size = new System.Drawing.Size(150, 31);
            this.txtCrs.TabIndex = 6;
            this.txtCrs.ValidatingType = typeof(int);
            // 
            // txtCrsDat
            // 
            this.txtCrsDat.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCrsDat.Location = new System.Drawing.Point(451, 246);
            this.txtCrsDat.Mask = "00/00/0000";
            this.txtCrsDat.Name = "txtCrsDat";
            this.txtCrsDat.Size = new System.Drawing.Size(150, 31);
            this.txtCrsDat.TabIndex = 8;
            this.txtCrsDat.ValidatingType = typeof(System.DateTime);
            // 
            // gridRep
            // 
            this.gridRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRep.Location = new System.Drawing.Point(24, 306);
            this.gridRep.Name = "gridRep";
            this.gridRep.RowHeadersWidth = 62;
            this.gridRep.RowTemplate.Height = 33;
            this.gridRep.Size = new System.Drawing.Size(1007, 328);
            this.gridRep.TabIndex = 10;
            // 
            // reloadbut
            // 
            this.reloadbut.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reloadbut.Location = new System.Drawing.Point(893, 227);
            this.reloadbut.Name = "reloadbut";
            this.reloadbut.Size = new System.Drawing.Size(112, 34);
            this.reloadbut.TabIndex = 9;
            this.reloadbut.Text = "&Reload";
            this.toolTip1.SetToolTip(this.reloadbut, "Reload and Reset");
            this.reloadbut.UseVisualStyleBackColor = true;
            this.reloadbut.Click += new System.EventHandler(this.reloadbut_Click);
            // 
            // radioStu
            // 
            this.radioStu.AutoSize = true;
            this.radioStu.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioStu.Location = new System.Drawing.Point(40, 101);
            this.radioStu.Name = "radioStu";
            this.radioStu.Size = new System.Drawing.Size(360, 25);
            this.radioStu.TabIndex = 1;
            this.radioStu.TabStop = true;
            this.radioStu.Text = "How Many Students Registred Past ";
            this.radioStu.UseVisualStyleBackColor = true;
            this.radioStu.CheckedChanged += new System.EventHandler(this.radioStu_CheckedChanged);
            // 
            // radioCrs
            // 
            this.radioCrs.AutoSize = true;
            this.radioCrs.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioCrs.Location = new System.Drawing.Point(40, 198);
            this.radioCrs.Name = "radioCrs";
            this.radioCrs.Size = new System.Drawing.Size(329, 25);
            this.radioCrs.TabIndex = 5;
            this.radioCrs.TabStop = true;
            this.radioCrs.Text = "How Many Courses Opened Past";
            this.radioCrs.UseVisualStyleBackColor = true;
            this.radioCrs.CheckedChanged += new System.EventHandler(this.radioCrs_CheckedChanged);
            // 
            // radioInst
            // 
            this.radioInst.AutoSize = true;
            this.radioInst.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioInst.Location = new System.Drawing.Point(451, 101);
            this.radioInst.Name = "radioInst";
            this.radioInst.Size = new System.Drawing.Size(375, 25);
            this.radioInst.TabIndex = 3;
            this.radioInst.Text = "How Many Instructors Registred Past";
            this.radioInst.UseVisualStyleBackColor = true;
            this.radioInst.CheckedChanged += new System.EventHandler(this.radioInst_CheckedChanged);
            // 
            // radioCrsDat
            // 
            this.radioCrsDat.AutoSize = true;
            this.radioCrsDat.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioCrsDat.Location = new System.Drawing.Point(451, 198);
            this.radioCrsDat.Name = "radioCrsDat";
            this.radioCrsDat.Size = new System.Drawing.Size(296, 25);
            this.radioCrsDat.TabIndex = 7;
            this.radioCrsDat.TabStop = true;
            this.radioCrsDat.Text = "How Many Courses Open On";
            this.radioCrsDat.UseVisualStyleBackColor = true;
            this.radioCrsDat.CheckedChanged += new System.EventHandler(this.radioCrsDat_CheckedChanged);
            // 
            // labStu
            // 
            this.labStu.AutoSize = true;
            this.labStu.Location = new System.Drawing.Point(196, 136);
            this.labStu.Name = "labStu";
            this.labStu.Size = new System.Drawing.Size(83, 25);
            this.labStu.TabIndex = 22;
            this.labStu.Text = "Month(s)";
            // 
            // labcrs
            // 
            this.labcrs.AutoSize = true;
            this.labcrs.Location = new System.Drawing.Point(196, 246);
            this.labcrs.Name = "labcrs";
            this.labcrs.Size = new System.Drawing.Size(83, 25);
            this.labcrs.TabIndex = 23;
            this.labcrs.Text = "Month(s)";
            // 
            // labIns
            // 
            this.labIns.AutoSize = true;
            this.labIns.Location = new System.Drawing.Point(618, 136);
            this.labIns.Name = "labIns";
            this.labIns.Size = new System.Drawing.Size(83, 25);
            this.labIns.TabIndex = 24;
            this.labIns.Text = "Month(s)";
            // 
            // Reporting4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1059, 655);
            this.Controls.Add(this.labIns);
            this.Controls.Add(this.labcrs);
            this.Controls.Add(this.labStu);
            this.Controls.Add(this.radioCrsDat);
            this.Controls.Add(this.radioInst);
            this.Controls.Add(this.radioCrs);
            this.Controls.Add(this.radioStu);
            this.Controls.Add(this.reloadbut);
            this.Controls.Add(this.gridRep);
            this.Controls.Add(this.txtCrsDat);
            this.Controls.Add(this.txtCrs);
            this.Controls.Add(this.txtInst);
            this.Controls.Add(this.txtStu);
            this.Controls.Add(this.label1);
            this.Name = "Reporting4";
            this.Text = "Reporting4";
            this.Load += new System.EventHandler(this.Reporting4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaskedTextBox txtStu;
        private MaskedTextBox txtInst;
        private MaskedTextBox txtCrs;
        private MaskedTextBox txtCrsDat;
        private DataGridView gridRep;
        private Button reloadbut;
        private RadioButton radioStu;
        private RadioButton radioCrs;
        private RadioButton radioInst;
        private RadioButton radioCrsDat;
        private Label labStu;
        private Label labcrs;
        private Label labIns;
        private ToolTip toolTip1;
    }
}