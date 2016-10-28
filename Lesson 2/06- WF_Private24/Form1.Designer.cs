namespace _06__WF_Private24
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
            if (disposing && (components != null)) {
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
            this.rtEdit = new System.Windows.Forms.RichTextBox();
            this.lpPrivate24 = new System.Windows.Forms.ListBox();
            this.lbTest = new System.Windows.Forms.ListBox();
            this.getData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtEdit
            // 
            this.rtEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtEdit.Location = new System.Drawing.Point(0, 0);
            this.rtEdit.Name = "rtEdit";
            this.rtEdit.Size = new System.Drawing.Size(887, 163);
            this.rtEdit.TabIndex = 0;
            this.rtEdit.Text = "";
            // 
            // lpPrivate24
            // 
            this.lpPrivate24.FormattingEnabled = true;
            this.lpPrivate24.Location = new System.Drawing.Point(47, 204);
            this.lpPrivate24.Name = "lpPrivate24";
            this.lpPrivate24.Size = new System.Drawing.Size(294, 225);
            this.lpPrivate24.TabIndex = 1;
            // 
            // lbTest
            // 
            this.lbTest.FormattingEnabled = true;
            this.lbTest.Location = new System.Drawing.Point(564, 204);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(294, 225);
            this.lbTest.TabIndex = 2;
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(47, 454);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(75, 23);
            this.getData.TabIndex = 3;
            this.getData.Text = "Get Data";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 508);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.lpPrivate24);
            this.Controls.Add(this.rtEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtEdit;
        private System.Windows.Forms.ListBox lpPrivate24;
        private System.Windows.Forms.ListBox lbTest;
        private System.Windows.Forms.Button getData;
    }
}

