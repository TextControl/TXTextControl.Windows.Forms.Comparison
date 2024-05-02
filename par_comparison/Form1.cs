using System.Diagnostics;
using System.Text.RegularExpressions;
using TXTextControl;

namespace par_comparison
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}





		private void button1_Click(object sender, EventArgs e)
		{
			DocumentComparison dc = new DocumentComparison(textControl1, textControl2);

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void textControl1_InputPositionChanged(object sender, EventArgs e)
		{
			Debug.WriteLine(textControl1.Selection.Start);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textControl1.ResetContents();
			textControl1.IsTrackChangesEnabled = false;
			textControl2.ResetContents();
		}
	}
}
