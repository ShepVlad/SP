﻿namespace _05_TimerZBS
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this._lb = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(314, 198);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 2;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _lb
            // 
            this._lb.FormattingEnabled = true;
            this._lb.Items.AddRange(new object[] {
            "item%1",
            "item%2"});
            this._lb.Location = new System.Drawing.Point(101, 48);
            this._lb.Name = "_lb";
            this._lb.Size = new System.Drawing.Size(181, 173);
            this._lb.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clean";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button);
            this.Controls.Add(this._lb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox _lb;
        private System.Windows.Forms.Button button2;
    }
}

