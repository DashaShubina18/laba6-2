namespace laba6._2
{
    partial class fMain
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
            this.btnEarth = new System.Windows.Forms.Button();
            this.btnMoon = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEarth
            // 
            this.btnEarth.Location = new System.Drawing.Point(106, 66);
            this.btnEarth.Name = "btnEarth";
            this.btnEarth.Size = new System.Drawing.Size(103, 34);
            this.btnEarth.TabIndex = 0;
            this.btnEarth.Text = "Земля";
            this.btnEarth.UseVisualStyleBackColor = true;
            this.btnEarth.Click += new System.EventHandler(this.btnEarth_Click);
            // 
            // btnMoon
            // 
            this.btnMoon.Location = new System.Drawing.Point(347, 66);
            this.btnMoon.Name = "btnMoon";
            this.btnMoon.Size = new System.Drawing.Size(103, 34);
            this.btnMoon.TabIndex = 1;
            this.btnMoon.Text = "Місяць";
            this.btnMoon.UseVisualStyleBackColor = true;
            this.btnMoon.Click += new System.EventHandler(this.btnMoon_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(106, 175);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(344, 97);
            this.txtOutput.TabIndex = 2;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnMoon);
            this.Controls.Add(this.btnEarth);
            this.Name = "fMain";
            this.Text = "Планети";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEarth;
        private System.Windows.Forms.Button btnMoon;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

