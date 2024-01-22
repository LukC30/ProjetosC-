/*
 * Created by SharpDevelop.
 * User: carva
 * Date: 14/08/2023
 * Time: 19:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace joojin
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Timer timer2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// timer2
			// 
			this.timer2.Enabled = true;
			this.timer2.Interval = 1000;
			this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(894, 391);
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.Text = "joojin";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.ResumeLayout(false);

		}
	}
}
