﻿namespace Xonix
{
    partial class XonixGame
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
            this.GameAreaPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // GameAreaPanel
            // 
            this.GameAreaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameAreaPanel.Location = new System.Drawing.Point(12, 12);
            this.GameAreaPanel.Name = "GameAreaPanel";
            this.GameAreaPanel.Size = new System.Drawing.Size(1000, 600);
            this.GameAreaPanel.TabIndex = 0;
            this.GameAreaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GameAreaPanel_Paint);
            // 
            // XonixGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1024, 661);
            this.Controls.Add(this.GameAreaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "XonixGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xonix";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GameAreaPanel;
    }
}

