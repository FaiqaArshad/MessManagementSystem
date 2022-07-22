namespace MessManagement
{
    partial class Meal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ddown = new System.Windows.Forms.NumericUpDown();
            this.ldown = new System.Windows.Forms.NumericUpDown();
            this.bdown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 395);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Meal";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.White;
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(167, 311);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(115, 45);
            this.update.TabIndex = 19;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(15, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 45);
            this.button2.TabIndex = 18;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.Image = global::MessManagement.Properties.Resources.dlt;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Location = new System.Drawing.Point(167, 264);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(120, 41);
            this.delete.TabIndex = 17;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Image = global::MessManagement.Properties.Resources.imagesCR5WT6YV2;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(180, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 32);
            this.button4.TabIndex = 16;
            this.button4.Text = "Insert";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Select ID";
            // 
            // id
            // 
            this.id.FormattingEnabled = true;
            this.id.Location = new System.Drawing.Point(86, 48);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(201, 24);
            this.id.TabIndex = 12;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox4.Location = new System.Drawing.Point(86, 169);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(138, 24);
            this.comboBox4.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::MessManagement.Properties.Resources.imagesCR5WT6YV2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Meal Unit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Breakfast";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dinner";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lunch";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 347);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ddown);
            this.panel2.Controls.Add(this.ldown);
            this.panel2.Controls.Add(this.bdown);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(18, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 146);
            this.panel2.TabIndex = 6;
            // 
            // ddown
            // 
            this.ddown.Location = new System.Drawing.Point(96, 97);
            this.ddown.Name = "ddown";
            this.ddown.Size = new System.Drawing.Size(163, 20);
            this.ddown.TabIndex = 21;
            // 
            // ldown
            // 
            this.ldown.Location = new System.Drawing.Point(96, 63);
            this.ldown.Name = "ldown";
            this.ldown.Size = new System.Drawing.Size(163, 20);
            this.ldown.TabIndex = 20;
            // 
            // bdown
            // 
            this.bdown.Location = new System.Drawing.Point(96, 25);
            this.bdown.Name = "bdown";
            this.bdown.Size = new System.Drawing.Size(163, 20);
            this.bdown.TabIndex = 19;
            // 
            // Meal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Meal";
            this.Text = "Meal";
            this.Load += new System.EventHandler(this.Meal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox id;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown bdown;
        private System.Windows.Forms.NumericUpDown ddown;
        private System.Windows.Forms.NumericUpDown ldown;
        private System.Windows.Forms.Button update;
    }
}