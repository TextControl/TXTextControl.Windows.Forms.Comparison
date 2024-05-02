namespace par_comparison
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textControl1 = new TXTextControl.TextControl();
			textControl2 = new TXTextControl.TextControl();
			button1 = new Button();
			splitContainer1 = new SplitContainer();
			panel1 = new Panel();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// textControl1
			// 
			textControl1.ControlChars = true;
			textControl1.Dock = DockStyle.Fill;
			textControl1.Font = new Font("Arial", 10F);
			textControl1.FormattingPrinter = "Standard";
			textControl1.Location = new Point(20, 20);
			textControl1.Name = "textControl1";
			textControl1.Size = new Size(243, 500);
			textControl1.TabIndex = 0;
			textControl1.Text = "The quick brown fox jumps over the lazy dog. A stitch in time saves nine. The sun rises in the east. An apple a day keeps the doctor away.";
			textControl1.UserNames = null;
			textControl1.ViewMode = TXTextControl.ViewMode.SimpleControl;
			textControl1.InputPositionChanged += textControl1_InputPositionChanged;
			// 
			// textControl2
			// 
			textControl2.ControlChars = true;
			textControl2.Dock = DockStyle.Fill;
			textControl2.Font = new Font("Arial", 10F);
			textControl2.FormattingPrinter = "Standard";
			textControl2.Location = new Point(20, 20);
			textControl2.Name = "textControl2";
			textControl2.Size = new Size(523, 500);
			textControl2.TabIndex = 1;
			textControl2.Text = "The quick red dog jumps over the lazy cat. A stitch in time saves nine.      The sun sinks in the east.  A peach a week keeps the doctor away.";
			textControl2.UserNames = null;
			textControl2.ViewMode = TXTextControl.ViewMode.SimpleControl;
			// 
			// button1
			// 
			button1.Location = new Point(18, 23);
			button1.Name = "button1";
			button1.Size = new Size(159, 42);
			button1.TabIndex = 2;
			button1.Text = "Compare";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.BackColor = Color.White;
			splitContainer1.Panel1.Controls.Add(textControl1);
			splitContainer1.Panel1.Padding = new Padding(20);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.BackColor = Color.White;
			splitContainer1.Panel2.Controls.Add(textControl2);
			splitContainer1.Panel2.Padding = new Padding(20);
			splitContainer1.Size = new Size(850, 540);
			splitContainer1.SplitterDistance = 283;
			splitContainer1.TabIndex = 3;
			// 
			// panel1
			// 
			panel1.Controls.Add(button1);
			panel1.Dock = DockStyle.Right;
			panel1.Location = new Point(850, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(200, 540);
			panel1.TabIndex = 4;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1050, 540);
			Controls.Add(splitContainer1);
			Controls.Add(panel1);
			Name = "Form1";
			Text = "Simple Document Comparison";
			Load += Form1_Load;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TXTextControl.TextControl textControl1;
		private TXTextControl.TextControl textControl2;
		private Button button1;
		private SplitContainer splitContainer1;
		private Panel panel1;
	}
}
