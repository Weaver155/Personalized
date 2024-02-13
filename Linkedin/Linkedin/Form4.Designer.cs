namespace Linkedin
{
    partial class Form4
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
            richTextBoxArticles = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxArticles
            // 
            richTextBoxArticles.Location = new Point(72, 159);
            richTextBoxArticles.Name = "richTextBoxArticles";
            richTextBoxArticles.Size = new Size(1554, 614);
            richTextBoxArticles.TabIndex = 0;
            richTextBoxArticles.Text = "";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 232);
            ClientSize = new Size(1774, 1000);
            Controls.Add(richTextBoxArticles);
            Name = "Form4";
            Text = "Posts Data";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxArticles;
    }
}