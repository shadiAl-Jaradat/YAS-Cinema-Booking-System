
namespace pro1
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
            System.Windows.Forms.Button done;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.C_nam = new System.Windows.Forms.Label();
            this.WLC = new System.Windows.Forms.Label();
            done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(348, 142);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 30);
            this.textBox1.TabIndex = 0;
            // 
            // C_nam
            // 
            this.C_nam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.C_nam.AutoSize = true;
            this.C_nam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C_nam.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_nam.Location = new System.Drawing.Point(256, 142);
            this.C_nam.Name = "C_nam";
            this.C_nam.Size = new System.Drawing.Size(86, 31);
            this.C_nam.TabIndex = 1;
            this.C_nam.Text = "Name";
            this.C_nam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.C_nam.Click += new System.EventHandler(this.C_nam_Click);
            // 
            // WLC
            // 
            this.WLC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WLC.AutoSize = true;
            this.WLC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.WLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLC.Location = new System.Drawing.Point(209, 85);
            this.WLC.Name = "WLC";
            this.WLC.Size = new System.Drawing.Size(346, 36);
            this.WLC.TabIndex = 2;
            this.WLC.Text = "Welcom to YAS cinema";
            // 
            // done
            // 
            done.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            done.BackColor = System.Drawing.Color.Maroon;
            done.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            done.FlatAppearance.BorderSize = 0;
            done.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            done.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            done.Location = new System.Drawing.Point(312, 201);
            done.Name = "done";
            done.Size = new System.Drawing.Size(143, 31);
            done.TabIndex = 3;
            done.Text = "Enter";
            done.UseVisualStyleBackColor = false;
            done.Click += new System.EventHandler(this.done_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 432);
            this.Controls.Add(done);
            this.Controls.Add(this.WLC);
            this.Controls.Add(this.C_nam);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label C_nam;
        private System.Windows.Forms.Label WLC;
    }
}

