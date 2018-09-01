namespace quizsample
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.optdoknow = new System.Windows.Forms.RadioButton();
            this.optno = new System.Windows.Forms.RadioButton();
            this.optyes = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.optdoknow);
            this.groupBox1.Controls.Add(this.optno);
            this.groupBox1.Controls.Add(this.optyes);
            this.groupBox1.Location = new System.Drawing.Point(50, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1250, 600);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(880, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 80);
            this.button2.TabIndex = 8;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(130, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 85);
            this.label1.TabIndex = 4;
            this.label1.Text = "2. The term bit is short for:";
            // 
            // optdoknow
            // 
            this.optdoknow.AutoSize = true;
            this.optdoknow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.optdoknow.Font = new System.Drawing.Font("Minion Pro SmBd", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.optdoknow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.optdoknow.Location = new System.Drawing.Point(340, 300);
            this.optdoknow.Name = "optdoknow";
            this.optdoknow.Size = new System.Drawing.Size(261, 55);
            this.optdoknow.TabIndex = 2;
            this.optdoknow.Text = "binary number";
            this.optdoknow.UseVisualStyleBackColor = true;
            this.optdoknow.CheckedChanged += new System.EventHandler(this.optdoknow_CheckedChanged);
            // 
            // optno
            // 
            this.optno.AutoSize = true;
            this.optno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.optno.Font = new System.Drawing.Font("Minion Pro SmBd", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.optno.Location = new System.Drawing.Point(340, 100);
            this.optno.Name = "optno";
            this.optno.Size = new System.Drawing.Size(180, 55);
            this.optno.TabIndex = 1;
            this.optno.Text = "megabyte";
            this.optno.UseVisualStyleBackColor = true;
            // 
            // optyes
            // 
            this.optyes.AutoSize = true;
            this.optyes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.optyes.Font = new System.Drawing.Font("Minion Pro SmBd", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.optyes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.optyes.Location = new System.Drawing.Point(340, 200);
            this.optyes.Name = "optyes";
            this.optyes.Size = new System.Drawing.Size(225, 55);
            this.optyes.TabIndex = 0;
            this.optyes.Text = " binary digit";
            this.optyes.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form2";
            this.Opacity = 0.95D;
            this.Text = "Question 2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optdoknow;
        private System.Windows.Forms.RadioButton optno;
        private System.Windows.Forms.RadioButton optyes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}