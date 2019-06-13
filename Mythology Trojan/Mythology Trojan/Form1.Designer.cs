namespace Mythology_Trojan
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
            this.meltsrcBtn = new System.Windows.Forms.Button();
            this.textErrorFile = new System.Windows.Forms.TextBox();
            this.textIntro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // meltsrcBtn
            // 
            this.meltsrcBtn.Location = new System.Drawing.Point(397, 93);
            this.meltsrcBtn.Name = "meltsrcBtn";
            this.meltsrcBtn.Size = new System.Drawing.Size(75, 23);
            this.meltsrcBtn.TabIndex = 1;
            this.meltsrcBtn.Text = "melt screen function";
            this.meltsrcBtn.UseVisualStyleBackColor = true;
            this.meltsrcBtn.Visible = false;
            this.meltsrcBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textErrorFile
            // 
            this.textErrorFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textErrorFile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textErrorFile.Location = new System.Drawing.Point(12, 12);
            this.textErrorFile.Name = "textErrorFile";
            this.textErrorFile.Size = new System.Drawing.Size(100, 20);
            this.textErrorFile.TabIndex = 2;
            this.textErrorFile.Text = resources.GetString("textErrorFile.Text");
            this.textErrorFile.Visible = false;
            // 
            // textIntro
            // 
            this.textIntro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIntro.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textIntro.Location = new System.Drawing.Point(12, 38);
            this.textIntro.Name = "textIntro";
            this.textIntro.Size = new System.Drawing.Size(100, 20);
            this.textIntro.TabIndex = 3;
            this.textIntro.Text = resources.GetString("textIntro.Text");
            this.textIntro.Visible = false;
            this.textIntro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(154, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Yes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Would you like to learn about the Trojan Horse?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(254, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(394, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "peter leal - myth101";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 296);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textIntro);
            this.Controls.Add(this.textErrorFile);
            this.Controls.Add(this.meltsrcBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "          ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button meltsrcBtn;
        private System.Windows.Forms.TextBox textErrorFile;
        private System.Windows.Forms.TextBox textIntro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}

