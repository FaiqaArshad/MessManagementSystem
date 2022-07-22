namespace MessManagement
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInformationCTRLNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeInformationCTRLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealDetailCTRLMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingOptionCTRLBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Student_Registration = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.student);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(70, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::MessManagement.Properties.Resources.screen_shot_2015_11_07_at_2_20_10_pm_110895;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(352, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(202, 130);
            this.button6.TabIndex = 5;
            this.toolTip2.SetToolTip(this.button6, "Employee Informaations");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::MessManagement.Properties.Resources.untitled1;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(79, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 130);
            this.button4.TabIndex = 3;
            this.toolTip2.SetToolTip(this.button4, "Billing Information");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::MessManagement.Properties.Resources.logo;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(352, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 130);
            this.button2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button2, "Meal Information");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // student
            // 
            this.student.BackgroundImage = global::MessManagement.Properties.Resources.imagesMCQN93Q7;
            this.student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.student.Location = new System.Drawing.Point(79, 36);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(202, 130);
            this.student.TabIndex = 0;
            this.Student_Registration.SetToolTip(this.student, "Student Registration ");
            this.student.UseVisualStyleBackColor = true;
            this.student.Click += new System.EventHandler(this.button1_Click);
            this.student.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentInformationCTRLNToolStripMenuItem,
            this.employeeInformationCTRLEToolStripMenuItem,
            this.mealDetailCTRLMToolStripMenuItem,
            this.billingOptionCTRLBToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // studentInformationCTRLNToolStripMenuItem
            // 
            this.studentInformationCTRLNToolStripMenuItem.Name = "studentInformationCTRLNToolStripMenuItem";
            this.studentInformationCTRLNToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.studentInformationCTRLNToolStripMenuItem.Text = "Student Information CTRL+N";
            this.studentInformationCTRLNToolStripMenuItem.Click += new System.EventHandler(this.studentInformationCTRLNToolStripMenuItem_Click);
            // 
            // employeeInformationCTRLEToolStripMenuItem
            // 
            this.employeeInformationCTRLEToolStripMenuItem.Name = "employeeInformationCTRLEToolStripMenuItem";
            this.employeeInformationCTRLEToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.employeeInformationCTRLEToolStripMenuItem.Text = "Employee Information CTRL+E";
            this.employeeInformationCTRLEToolStripMenuItem.Click += new System.EventHandler(this.employeeInformationCTRLEToolStripMenuItem_Click);
            // 
            // mealDetailCTRLMToolStripMenuItem
            // 
            this.mealDetailCTRLMToolStripMenuItem.Name = "mealDetailCTRLMToolStripMenuItem";
            this.mealDetailCTRLMToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.mealDetailCTRLMToolStripMenuItem.Text = "Meal Detail CTRL+M";
            this.mealDetailCTRLMToolStripMenuItem.Click += new System.EventHandler(this.mealDetailCTRLMToolStripMenuItem_Click);
            // 
            // billingOptionCTRLBToolStripMenuItem
            // 
            this.billingOptionCTRLBToolStripMenuItem.Name = "billingOptionCTRLBToolStripMenuItem";
            this.billingOptionCTRLBToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.billingOptionCTRLBToolStripMenuItem.Text = "Billing Option CTRL+B";
            this.billingOptionCTRLBToolStripMenuItem.Click += new System.EventHandler(this.billingOptionCTRLBToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.signOutToolStripMenuItem.Text = "SignOut";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProjectToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutProjectToolStripMenuItem
            // 
            this.aboutProjectToolStripMenuItem.Name = "aboutProjectToolStripMenuItem";
            this.aboutProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutProjectToolStripMenuItem.Text = "About Project";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome To Mess Managemnet System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button student;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip Student_Registration;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentInformationCTRLNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeInformationCTRLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mealDetailCTRLMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingOptionCTRLBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProjectToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}