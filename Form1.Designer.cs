namespace MessManagement
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.npwd = new System.Windows.Forms.TextBox();
            this.cpwd = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(248, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(172, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 123);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(134, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(134, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Window;
            this.password.Location = new System.Drawing.Point(134, 196);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(245, 22);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.password_TextChanged);
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(134, 168);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(245, 22);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.username_TextChanged);
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.npwd);
            this.panel1.Controls.Add(this.cpwd);
            this.panel1.Controls.Add(this.user);
            this.panel1.Location = new System.Drawing.Point(259, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 312);
            this.panel1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(229, 163);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 33);
            this.button5.TabIndex = 6;
            this.button5.Text = "Ok";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "New password";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // npwd
            // 
            this.npwd.Location = new System.Drawing.Point(161, 90);
            this.npwd.Name = "npwd";
            this.npwd.PasswordChar = '*';
            this.npwd.Size = new System.Drawing.Size(207, 20);
            this.npwd.TabIndex = 2;
            // 
            // cpwd
            // 
            this.cpwd.Location = new System.Drawing.Point(161, 124);
            this.cpwd.Name = "cpwd";
            this.cpwd.PasswordChar = '*';
            this.cpwd.Size = new System.Drawing.Size(207, 20);
            this.cpwd.TabIndex = 1;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(161, 49);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(207, 20);
            this.user.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(134, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Forgot Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox npwd;
        private System.Windows.Forms.TextBox cpwd;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

