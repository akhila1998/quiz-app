namespace quizsample
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.optdoknow = new System.Windows.Forms.RadioButton();
            this.optno = new System.Windows.Forms.RadioButton();
            this.optyes = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(880, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 80);
            this.button1.TabIndex = 10;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.optdoknow);
            this.groupBox1.Controls.Add(this.optno);
            this.groupBox1.Controls.Add(this.optyes);
            this.groupBox1.Location = new System.Drawing.Point(50, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1250, 600);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(130, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 85);
            this.label1.TabIndex = 4;
            this.label1.Text = "1.WWW Stands For";
            // 
            // optdoknow
            // 
            this.optdoknow.AutoSize = true;
            this.optdoknow.Font = new System.Drawing.Font("Minion Pro SmBd", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.optdoknow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.optdoknow.Location = new System.Drawing.Point(340, 300);
            this.optdoknow.Name = "optdoknow";
            this.optdoknow.Size = new System.Drawing.Size(279, 55);
            this.optdoknow.TabIndex = 2;
            this.optdoknow.Text = "Word Wide Web";
            this.optdoknow.UseVisualStyleBackColor = true;
            // 
            // optno
            // 
            this.optno.AutoSize = true;
            this.optno.Font = new System.Drawing.Font("Minion Pro SmBd", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.optno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.optno.Location = new System.Drawing.Point(340, 100);
            this.optno.Name = "optno";
            this.optno.Size = new System.Drawing.Size(197, 55);
            this.optno.TabIndex = 1;
            this.optno.Text = "World web";
            this.optno.UseVisualStyleBackColor = true;
            // 
            // optyes
            // 
            this.optyes.AutoSize = true;
            this.optyes.Font = new System.Drawing.Font("Minion Pro SmBd", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.optyes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.optyes.Location = new System.Drawing.Point(340, 200);
            this.optyes.Name = "optyes";
            this.optyes.Size = new System.Drawing.Size(289, 55);
            this.optyes.TabIndex = 0;
            this.optyes.Text = "World Wide Web";
            this.optyes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Question 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optdoknow;
        private System.Windows.Forms.RadioButton optno;
        private System.Windows.Forms.RadioButton optyes;
        private System.Windows.Forms.Label label1;
    }
}

