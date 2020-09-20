using System;
using System.Windows.Forms;

namespace Test_App
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

		private void calculate_Click(object sender, EventArgs e)
		{
			int fn = Int32.Parse(box1.Text);
			int sn = Int32.Parse(box2.Text);

			int result;

			result = fn + sn;

			Box3.Text = $"{result}";

		}
	}
}
