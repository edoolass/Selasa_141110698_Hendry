namespace Latihan_2
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(712, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 47);
            this.button2.TabIndex = 21;
            this.button2.Text = "Hapus";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 47);
            this.button1.TabIndex = 20;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Location = new System.Drawing.Point(492, 166);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown2.TabIndex = 19;
            this.domainUpDown2.Text = "Bulan";
            this.domainUpDown2.SelectedItemChanged += new System.EventHandler(this.domainUpDown2_SelectedItemChanged);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(491, 139);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 18;
            this.domainUpDown1.Text = "Tanggal";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(492, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 83);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 408);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

