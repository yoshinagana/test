
namespace ConsoleApp1
{
	partial class MainDialog
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
			this.buttonExecute = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.dataGridViewTargets = new System.Windows.Forms.DataGridView();
			this.buttonClear = new System.Windows.Forms.Button();
			this.textBoxLog = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTargets)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonExecute
			// 
			this.buttonExecute.Location = new System.Drawing.Point(3, 3);
			this.buttonExecute.Name = "buttonExecute";
			this.buttonExecute.Size = new System.Drawing.Size(75, 23);
			this.buttonExecute.TabIndex = 0;
			this.buttonExecute.Text = "Execute";
			this.buttonExecute.UseVisualStyleBackColor = true;
			this.buttonExecute.Click += new System.EventHandler(this.ButtonExecuteClick);
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(84, 3);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 1;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.buttonExecute);
			this.flowLayoutPanel1.Controls.Add(this.buttonClose);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(110, 320);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(162, 29);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// dataGridViewTargets
			// 
			this.dataGridViewTargets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewTargets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTargets.Location = new System.Drawing.Point(12, 41);
			this.dataGridViewTargets.Name = "dataGridViewTargets";
			this.dataGridViewTargets.ReadOnly = true;
			this.dataGridViewTargets.RowHeadersVisible = false;
			this.dataGridViewTargets.RowTemplate.Height = 21;
			this.dataGridViewTargets.Size = new System.Drawing.Size(260, 172);
			this.dataGridViewTargets.TabIndex = 3;
			// 
			// buttonClear
			// 
			this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClear.Location = new System.Drawing.Point(194, 12);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 4;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
			// 
			// textBoxLog
			// 
			this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxLog.Location = new System.Drawing.Point(12, 219);
			this.textBoxLog.Multiline = true;
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.ReadOnly = true;
			this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxLog.Size = new System.Drawing.Size(257, 95);
			this.textBoxLog.TabIndex = 5;
			// 
			// MainDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 361);
			this.Controls.Add(this.textBoxLog);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.dataGridViewTargets);
			this.Controls.Add(this.flowLayoutPanel1);
			this.MinimumSize = new System.Drawing.Size(300, 200);
			this.Name = "MainDialog";
			this.Text = "MainDialog";
			this.Load += new System.EventHandler(this.Form1Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTargets)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonExecute;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.DataGridView dataGridViewTargets;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.TextBox textBoxLog;
	}
}