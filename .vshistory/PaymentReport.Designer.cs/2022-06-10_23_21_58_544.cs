namespace Course_Student_Registration_System
{
    partial class PaymentReport
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
            this.dataPayment = new System.Windows.Forms.DataGridView();
            this.checkStdComp = new System.Windows.Forms.CheckBox();
            this.checkDntComp = new System.Windows.Forms.CheckBox();
            this.txtsrch = new System.Windows.Forms.TextBox();
            this.butRlod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.butNtfy = new System.Windows.Forms.Button();
            this.butFiltr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(466, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment report";
            // 
            // dataPayment
            // 
            this.dataPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPayment.Location = new System.Drawing.Point(12, 220);
            this.dataPayment.Name = "dataPayment";
            this.dataPayment.RowHeadersWidth = 62;
            this.dataPayment.RowTemplate.Height = 33;
            this.dataPayment.Size = new System.Drawing.Size(1221, 474);
            this.dataPayment.TabIndex = 6;
            // 
            // checkStdComp
            // 
            this.checkStdComp.AutoSize = true;
            this.checkStdComp.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkStdComp.Location = new System.Drawing.Point(23, 151);
            this.checkStdComp.Name = "checkStdComp";
            this.checkStdComp.Size = new System.Drawing.Size(370, 25);
            this.checkStdComp.TabIndex = 3;
            this.checkStdComp.Text = "Students Compeleted There Payment";
            this.checkStdComp.UseVisualStyleBackColor = true;
            // 
            // checkDntComp
            // 
            this.checkDntComp.AutoSize = true;
            this.checkDntComp.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkDntComp.Location = new System.Drawing.Point(459, 151);
            this.checkDntComp.Name = "checkDntComp";
            this.checkDntComp.Size = new System.Drawing.Size(731, 25);
            this.checkDntComp.TabIndex = 4;
            this.checkDntComp.Text = "Student Paied But Didn\'t Complete The whole Payment Or Didn\'t Pay At All";
            this.checkDntComp.UseVisualStyleBackColor = true;
            // 
            // txtsrch
            // 
            this.txtsrch.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtsrch.Location = new System.Drawing.Point(62, 96);
            this.txtsrch.Multiline = true;
            this.txtsrch.Name = "txtsrch";
            this.txtsrch.PlaceholderText = "Do You Want To Search With Specific Student Name?Write It Here!";
            this.txtsrch.Size = new System.Drawing.Size(874, 35);
            this.txtsrch.TabIndex = 1;
            this.txtsrch.TextChanged += new System.EventHandler(this.txtsrch_TextChanged);
            // 
            // butRlod
            // 
            this.butRlod.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butRlod.Location = new System.Drawing.Point(956, 95);
            this.butRlod.Name = "butRlod";
            this.butRlod.Size = new System.Drawing.Size(112, 36);
            this.butRlod.TabIndex = 2;
            this.butRlod.Text = "&Reload";
            this.toolTip1.SetToolTip(this.butRlod, "This button will reset all the field and reload the table");
            this.butRlod.UseVisualStyleBackColor = true;
            this.butRlod.Click += new System.EventHandler(this.butRlod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "note: if you didn\'t check any, you will search by all";
            // 
            // butNtfy
            // 
            this.butNtfy.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butNtfy.Location = new System.Drawing.Point(1097, 95);
            this.butNtfy.Name = "butNtfy";
            this.butNtfy.Size = new System.Drawing.Size(112, 36);
            this.butNtfy.TabIndex = 19;
            this.butNtfy.Text = "&Notify";
            this.toolTip1.SetToolTip(this.butNtfy, "you will send a notify through the email and text messages\r\n to the student you c" +
        "hoose");
            this.butNtfy.UseVisualStyleBackColor = true;
            this.butNtfy.Click += new System.EventHandler(this.butNtfy_Click);
            // 
            // butFiltr
            // 
            this.butFiltr.Location = new System.Drawing.Point(1078, 180);
            this.butFiltr.Name = "butFiltr";
            this.butFiltr.Size = new System.Drawing.Size(112, 34);
            this.butFiltr.TabIndex = 20;
            this.butFiltr.Text = "Filter";
            this.butFiltr.UseVisualStyleBackColor = true;
            this.butFiltr.Click += new System.EventHandler(this.butFiltr_Click);
            // 
            // PaymentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1254, 742);
            this.Controls.Add(this.butFiltr);
            this.Controls.Add(this.butNtfy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butRlod);
            this.Controls.Add(this.txtsrch);
            this.Controls.Add(this.checkDntComp);
            this.Controls.Add(this.checkStdComp);
            this.Controls.Add(this.dataPayment);
            this.Controls.Add(this.label1);
            this.Name = "PaymentReport";
            this.Text = "PaymentReport";
            this.Load += new System.EventHandler(this.PaymentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataPayment;
        private CheckBox checkStdComp;
        private CheckBox checkDntComp;
        private TextBox txtsrch;
        private Button butRlod;
        private Label label2;
        private ToolTip toolTip1;
        private Button butNtfy;
        private Button butFiltr;
    }
}