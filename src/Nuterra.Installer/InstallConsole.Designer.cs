﻿namespace Nuterra.Installer
{
	partial class InstallConsole
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.output = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// output
			// 
			this.output.BackColor = System.Drawing.Color.Black;
			this.output.Dock = System.Windows.Forms.DockStyle.Fill;
			this.output.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.output.ForeColor = System.Drawing.Color.Lime;
			this.output.Location = new System.Drawing.Point(0, 0);
			this.output.Multiline = true;
			this.output.Name = "output";
			this.output.ReadOnly = true;
			this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.output.Size = new System.Drawing.Size(659, 279);
			this.output.TabIndex = 0;
			this.output.Text = "1. Select TerraTech install directory\r\n2. Click \"Install\" button\r\n3. Enjoy Nuterr" +
    "a (optional)\r\n\r\n";
			// 
			// InstallConsole
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.output);
			this.Name = "InstallConsole";
			this.Size = new System.Drawing.Size(659, 279);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox output;
	}
}
