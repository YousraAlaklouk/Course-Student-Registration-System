namespace Course_Student_Registration_System
{
    partial class OpenACourse
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
            this.combCrs = new System.Windows.Forms.ComboBox();
            this.resBut = new System.Windows.Forms.Button();
            this.opnBut = new System.Windows.Forms.Button();
            this.cancBut = new System.Windows.Forms.Button();
            this.txtPric = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDurTo = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDurFr = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTim = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(327, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open A Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose The Course You Want To Open";
            // 
            // combCrs
            // 
            this.combCrs.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.combCrs.FormattingEnabled = true;
            this.combCrs.Location = new System.Drawing.Point(448, 99);
            this.combCrs.Name = "combCrs";
            this.combCrs.Size = new System.Drawing.Size(199, 29);
            this.combCrs.TabIndex = 1;
            // 
            // resBut
            // 
            this.resBut.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resBut.Location = new System.Drawing.Point(426, 505);
            this.resBut.Name = "resBut";
            this.resBut.Size = new System.Drawing.Size(122, 47);
            this.resBut.TabIndex = 11;
            this.resBut.Text = "&Reset";
            this.toolTip1.SetToolTip(this.resBut, "this Button will clear all the form ");
            this.resBut.UseVisualStyleBackColor = true;
            this.resBut.Click += new System.EventHandler(this.resBut_Click);
            // 
            // opnBut
            // 
            this.opnBut.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.opnBut.Location = new System.Drawing.Point(617, 505);
            this.opnBut.Name = "opnBut";
            this.opnBut.Size = new System.Drawing.Size(122, 47);
            this.opnBut.TabIndex = 12;
            this.opnBut.Text = "&Open";
            this.toolTip1.SetToolTip(this.opnBut, "This Button will open the course");
            this.opnBut.UseVisualStyleBackColor = true;
            this.opnBut.Click += new System.EventHandler(this.opnBut_Click);
            // 
            // cancBut
            // 
            this.cancBut.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancBut.Location = new System.Drawing.Point(242, 505);
            this.cancBut.Name = "cancBut";
            this.cancBut.Size = new System.Drawing.Size(122, 47);
            this.cancBut.TabIndex = 10;
            this.cancBut.Text = "&Cancel";
            this.toolTip1.SetToolTip(this.cancBut, " this button for cancelling the opretation");
            this.cancBut.UseVisualStyleBackColor = true;
            this.cancBut.Click += new System.EventHandler(this.cancBut_Click);
            // 
            // txtPric
            // 
            this.txtPric.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPric.Location = new System.Drawing.Point(320, 211);
            this.txtPric.Mask = "00000";
            this.txtPric.Name = "txtPric";
            this.txtPric.Size = new System.Drawing.Size(199, 31);
            this.txtPric.TabIndex = 5;
            this.txtPric.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Course Price For Per Month";
            // 
            // txtDurTo
            // 
            this.txtDurTo.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDurTo.Location = new System.Drawing.Point(320, 136);
            this.txtDurTo.Mask = "00/00/0000";
            this.txtDurTo.Name = "txtDurTo";
            this.txtDurTo.Size = new System.Drawing.Size(199, 31);
            this.txtDurTo.TabIndex = 4;
            this.txtDurTo.ValidatingType = typeof(System.DateTime);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(233, 139);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 21);
            this.label18.TabIndex = 27;
            this.label18.Text = "To";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(223, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 21);
            this.label17.TabIndex = 26;
            this.label17.Text = "From";
            // 
            // txtDurFr
            // 
            this.txtDurFr.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDurFr.Location = new System.Drawing.Point(320, 68);
            this.txtDurFr.Mask = "00/00/0000";
            this.txtDurFr.Name = "txtDurFr";
            this.txtDurFr.Size = new System.Drawing.Size(199, 31);
            this.txtDurFr.TabIndex = 3;
            this.txtDurFr.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(8, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 21);
            this.label13.TabIndex = 24;
            this.label13.Text = "Course Duration";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTim);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtDays);
            this.groupBox3.Controls.Add(this.txtRoom);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(595, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 295);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Place and Time Details";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(115, 189);
            this.txtTim.Mask = "00:00";
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(91, 31);
            this.txtTim.TabIndex = 9;
            this.txtTim.ValidatingType = typeof(System.DateTime);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 21);
            this.label16.TabIndex = 5;
            this.label16.Text = "Time";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(115, 113);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(150, 31);
            this.txtDays.TabIndex = 8;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(115, 43);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(150, 31);
            this.txtRoom.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 21);
            this.label15.TabIndex = 1;
            this.label15.Text = "Day(s)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "Room";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDurFr);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDurTo);
            this.groupBox1.Controls.Add(this.txtPric);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(34, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 295);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Payment And Duration Details";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pastToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 132);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.fileToolStripMenuItem.Text = "Cut";
            // 
            // pastToolStripMenuItem
            // 
            this.pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            this.pastToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.pastToolStripMenuItem.Text = "Past";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // OpenACourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(971, 609);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cancBut);
            this.Controls.Add(this.opnBut);
            this.Controls.Add(this.resBut);
            this.Controls.Add(this.combCrs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OpenACourse";
            this.Text = "OpenACourse";
            this.Load += new System.EventHandler(this.OpenACourse_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox combCrs;
        private Button resBut;
        private Button opnBut;
        private Button cancBut;
        private MaskedTextBox txtPric;
        private Label label8;
        private MaskedTextBox txtDurTo;
        private Label label18;
        private Label label17;
        private MaskedTextBox txtDurFr;
        private Label label13;
        private ToolTip toolTip1;
        private GroupBox groupBox3;
        private MaskedTextBox txtTim;
        private Label label16;
        private TextBox txtDays;
        private TextBox txtRoom;
        private Label label15;
        private Label label14;
        private GroupBox groupBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem pastToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}