using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CallStack
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			GetStackTrace();
		}

		private List<String> GetStackTrace()
		{
			List<String> retVal = new List<string>();
			// get call stack
			StackTrace stackTrace = new StackTrace();

			// get calling method name
			textBox2.Text ="";
			MessageBox.Show(stackTrace.FrameCount + "");
			for (int i = 0; i < stackTrace.FrameCount;i++ )
			{
				retVal.Add(stackTrace.GetFrame(i).GetMethod().Name);
			}

			return retVal;
		}
	}
}