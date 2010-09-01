﻿namespace Pbp.Forms
{
    partial class ProjectionWindow
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
            this.projectionControlHost = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // projectionControlHost
            // 
            this.projectionControlHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.projectionControlHost.Location = new System.Drawing.Point(0, 0);
            this.projectionControlHost.Name = "projectionControlHost";
            this.projectionControlHost.Size = new System.Drawing.Size(640, 480);
            this.projectionControlHost.TabIndex = 2;
            this.projectionControlHost.Text = "elementHost1";
            this.projectionControlHost.Child = null;
            // 
            // projectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.projectionControlHost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "projectionWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "projectionWindow";
            this.Load += new System.EventHandler(this.projectionWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost projectionControlHost;
    }
}