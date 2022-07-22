namespace MessManagement
{
    partial class Searchstudent
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
            this.search1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomno = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.semester = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.TextBox();
            this.stxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search1
            // 
            this.search1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search1.Location = new System.Drawing.Point(16, 54);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(170, 23);
            this.search1.TabIndex = 0;
            this.search1.Text = "Enter Registration No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.stxt);
            this.groupBox1.Controls.Add(this.search1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Image = global::MessManagement.Properties.Resources.search2;
            this.search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.Location = new System.Drawing.Point(325, 45);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(99, 32);
            this.search.TabIndex = 3;
            this.search.Text = "Serach";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.roomno);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.contact);
            this.panel1.Controls.Add(this.semester);
            this.panel1.Controls.Add(this.department);
            this.panel1.Location = new System.Drawing.Point(19, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 297);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Department";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Semester";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Contact No";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Room No";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // roomno
            // 
            this.roomno.Location = new System.Drawing.Point(160, 198);
            this.roomno.Name = "roomno";
            this.roomno.Size = new System.Drawing.Size(199, 20);
            this.roomno.TabIndex = 19;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(160, 65);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(199, 20);
            this.id.TabIndex = 18;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(160, 91);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(199, 20);
            this.name.TabIndex = 17;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(160, 120);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(199, 20);
            this.contact.TabIndex = 16;
            // 
            // semester
            // 
            this.semester.Location = new System.Drawing.Point(160, 172);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(199, 20);
            this.semester.TabIndex = 15;
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(160, 146);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(199, 20);
            this.department.TabIndex = 14;
            // 
            // stxt
            // 
            this.stxt.Location = new System.Drawing.Point(179, 45);
            this.stxt.Multiline = true;
            this.stxt.Name = "stxt";
            this.stxt.Size = new System.Drawing.Size(140, 32);
            this.stxt.TabIndex = 1;
            // 
            // Searchstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MessManagement.Properties.Resources.image__1_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Searchstudent";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Searchstudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label search1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox stxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roomno;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox semester;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Button search;
    }
}