﻿namespace PraiseBase.Presenter.Forms
{
	partial class QADialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QADialog));
            this.checkBoxQASegmentation = new System.Windows.Forms.CheckBox();
            this.checkBoxQAImages = new System.Windows.Forms.CheckBox();
            this.checkBoxQATranslation = new System.Windows.Forms.CheckBox();
            this.checkBoxQASpelling = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxQASegmentation
            // 
            resources.ApplyResources(this.checkBoxQASegmentation, "checkBoxQASegmentation");
            this.checkBoxQASegmentation.Name = "checkBoxQASegmentation";
            this.checkBoxQASegmentation.UseVisualStyleBackColor = true;
            // 
            // checkBoxQAImages
            // 
            resources.ApplyResources(this.checkBoxQAImages, "checkBoxQAImages");
            this.checkBoxQAImages.Name = "checkBoxQAImages";
            this.checkBoxQAImages.UseVisualStyleBackColor = true;
            // 
            // checkBoxQATranslation
            // 
            resources.ApplyResources(this.checkBoxQATranslation, "checkBoxQATranslation");
            this.checkBoxQATranslation.Name = "checkBoxQATranslation";
            this.checkBoxQATranslation.UseVisualStyleBackColor = true;
            // 
            // checkBoxQASpelling
            // 
            resources.ApplyResources(this.checkBoxQASpelling, "checkBoxQASpelling");
            this.checkBoxQASpelling.Name = "checkBoxQASpelling";
            this.checkBoxQASpelling.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBoxComment
            // 
            resources.ApplyResources(this.textBoxComment, "textBoxComment");
            this.textBoxComment.Name = "textBoxComment";
            // 
            // buttonAccept
            // 
            resources.ApplyResources(this.buttonAccept, "buttonAccept");
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancl
            // 
            resources.ApplyResources(this.buttonCancl, "buttonCancl");
            this.buttonCancl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancl.Name = "buttonCancl";
            this.buttonCancl.UseVisualStyleBackColor = true;
            // 
            // QADialog
            // 
            this.AcceptButton = this.buttonAccept;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancl;
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancl);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxQASpelling);
            this.Controls.Add(this.checkBoxQATranslation);
            this.Controls.Add(this.checkBoxQASegmentation);
            this.Controls.Add(this.checkBoxQAImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "QADialog";
            this.Load += new System.EventHandler(this.QADialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxQASegmentation;
		private System.Windows.Forms.CheckBox checkBoxQAImages;
		private System.Windows.Forms.CheckBox checkBoxQATranslation;
		private System.Windows.Forms.CheckBox checkBoxQASpelling;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxComment;
		private System.Windows.Forms.Button buttonAccept;
		private System.Windows.Forms.Button buttonCancl;
	}
}