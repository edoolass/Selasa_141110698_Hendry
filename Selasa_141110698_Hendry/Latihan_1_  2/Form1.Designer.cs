namespace Latihan_1___2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(83, 228);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(200, 20);
            this.DTP.TabIndex = 10;
            this.DTP.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(83, 73);
            this.vScrollBar1.Maximum = 59;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 130);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(267, 73);
            this.vScrollBar2.Maximum = 49;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 130);
            this.vScrollBar2.TabIndex = 11;
            this.vScrollBar2.Value = 40;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 292);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "Form1";
            this.Text = "Latihan_1_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
    }
}

