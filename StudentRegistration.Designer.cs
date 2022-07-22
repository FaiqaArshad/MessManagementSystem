namespace MessManagement
{
    partial class StudentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegistration));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.semester = new System.Windows.Forms.ComboBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.contacttxt = new System.Windows.Forms.TextBox();
            this.roomtxt = new System.Windows.Forms.TextBox();
            this.regtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.room = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.display);
            this.groupBox1.Controls.Add(this.semester);
            this.groupBox1.Controls.Add(this.department);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nametxt);
            this.groupBox1.Controls.Add(this.contacttxt);
            this.groupBox1.Controls.Add(this.roomtxt);
            this.groupBox1.Controls.Add(this.regtxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.room);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::MessManagement.Properties.Resources.search;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(182, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.White;
            this.display.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.display.Location = new System.Drawing.Point(58, 387);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(239, 28);
            this.display.TabIndex = 18;
            this.display.Text = "Go Back";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // semester
            // 
            this.semester.FormattingEnabled = true;
            this.semester.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th",
            "6th",
            "7th",
            "8th"});
            this.semester.Location = new System.Drawing.Point(141, 215);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(137, 24);
            this.semester.TabIndex = 17;
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Items.AddRange(new object[] {
            "Computer Science",
            "BBA",
            "Electrical Engineering",
            "Bachelor of Education ",
            "BS Physics",
            "BS Mathematics"});
            this.department.Location = new System.Drawing.Point(141, 177);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(137, 24);
            this.department.TabIndex = 16;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Location = new System.Drawing.Point(58, 341);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(118, 40);
            this.delete.TabIndex = 15;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.White;
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(182, 294);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(115, 32);
            this.update.TabIndex = 14;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(58, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(141, 90);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(137, 22);
            this.nametxt.TabIndex = 12;
            // 
            // contacttxt
            // 
            this.contacttxt.Location = new System.Drawing.Point(141, 130);
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(137, 22);
            this.contacttxt.TabIndex = 11;
            // 
            // roomtxt
            // 
            this.roomtxt.Location = new System.Drawing.Point(141, 255);
            this.roomtxt.Name = "roomtxt";
            this.roomtxt.Size = new System.Drawing.Size(137, 22);
            this.roomtxt.TabIndex = 10;
            // 
            // regtxt
            // 
            this.regtxt.Location = new System.Drawing.Point(141, 46);
            this.regtxt.Name = "regtxt";
            this.regtxt.Size = new System.Drawing.Size(137, 22);
            this.regtxt.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name";
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(19, 260);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(57, 17);
            this.room.TabIndex = 4;
            this.room.Text = "Room No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(332, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 186);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(432, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "List of Registered Students ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1037, 474);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentRegistration";
            this.Text = "StudentRegistration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentRegistration_FormClosed);
            this.Load += new System.EventHandler(this.StudentRegistration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox contacttxt;
        private System.Windows.Forms.TextBox roomtxt;
        private System.Windows.Forms.TextBox regtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label room;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox semester;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button button2;
    }
}