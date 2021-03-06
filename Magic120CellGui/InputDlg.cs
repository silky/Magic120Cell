using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Magic120Cell
{
	public partial class InputDlg : Form
	{
		public InputDlg()
		{
			InitializeComponent();
		}

		public string Caption
		{
			get { return this.Text; }
			set { this.Text = value; }
		}

		public string Prompt
		{
			get { return this.labelPrompt.Text; }
			set { this.labelPrompt.Text = value; }
		}

		public string Value
		{
			get { return this.textInput.Text; }
			set { this.textInput.Text = value; }
		}

		private void btnOK_Click( object sender, EventArgs e )
		{
			this.DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click( object sender, EventArgs e )
		{
			this.DialogResult = DialogResult.Cancel;
			Close();
		}

		private void textInput_TextChanged( object sender, EventArgs e )
		{
			this.btnOK.Enabled = (this.textInput.Text != string.Empty);
		}
	}
}