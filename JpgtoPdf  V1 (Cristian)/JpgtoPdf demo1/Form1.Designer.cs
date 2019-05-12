namespace JpgtoPdf_demo1
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
            this.JpgtoPdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JpgtoPdf
            // 
            this.JpgtoPdf.Location = new System.Drawing.Point(58, 53);
            this.JpgtoPdf.Name = "JpgtoPdf";
            this.JpgtoPdf.Size = new System.Drawing.Size(105, 69);
            this.JpgtoPdf.TabIndex = 0;
            this.JpgtoPdf.Text = "JpgtoPdf";
            this.JpgtoPdf.UseVisualStyleBackColor = true;
            this.JpgtoPdf.Click += new System.EventHandler(this.JpgtoPdf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 450);
            this.Controls.Add(this.JpgtoPdf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button JpgtoPdf;
    }
}

