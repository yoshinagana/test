
namespace ConsoleApp1
{
	partial class AbortDialog
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
			this.buttonAbort = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonAbort
			// 
			this.buttonAbort.Location = new System.Drawing.Point(197, 126);
			this.buttonAbort.Name = "buttonAbort";
			this.buttonAbort.Size = new System.Drawing.Size(75, 23);
			this.buttonAbort.TabIndex = 0;
			this.buttonAbort.Text = "Abort";
			this.buttonAbort.UseVisualStyleBackColor = true;
			this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
			// 
			// AbortDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 161);
			this.Controls.Add(this.buttonAbort);
			this.MaximumSize = new System.Drawing.Size(300, 200);
			this.MinimumSize = new System.Drawing.Size(300, 200);
			this.Name = "AbortDialog";
			this.Text = "AbortDialog";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AbortDialog_FormClosed);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonAbort;
	}
}