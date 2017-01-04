using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCar
{
	public partial class FormCreateCar : Form
	{
		public FormCreateCar()
		{
			InitializeComponent();
			btOk.Enabled = false;
		}
		bool flag = false;

		public string GetTextBoxBrandCar => tbBrandCar.Text;

		public string GetTextBoxtbModelCar => tbModelCar.Text;

		public string GetTextBoxtbRelaseYear => tbRelaseYear.Text;

		public string GetTextBoxtbtbCost => tbCost.Text;

		private void tbBrandCar_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar))
			{
				return;
			}
			e.Handled = true;
			ChangeFocus(sender, e, tbModelCar);
		}

		private void tbModelCar_KeyPress(object sender, KeyPressEventArgs e)
		{
			ChangeFocus(sender, e, tbRelaseYear);
		}

		private void tbRelaseYear_KeyPress(object sender, KeyPressEventArgs e)
		{
			tbRelaseYear.MaxLength = 4;
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
			{
				return;
			}
			ChangeFocus(sender, e, tbCost);
			e.Handled = true;
		}

		private void tbCost_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
			{
				return;
			}

			ChangeFocus(sender, e, btOk);
			e.Handled = true;
		}
		private void ChangeFocus(object sender, KeyPressEventArgs e, Control nameControl)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				nameControl.Focus();
			}
		}

		private void tbCost_TextChanged(object sender, EventArgs e)
		{
			ActivOkButton();
		}

		private void btOkCreateCar_Click(object sender, EventArgs e)
		{
			flag = true;
			this.Close();
		}
		public bool ButtonClick()
		{
			return flag;
		}

		private void btClear_Click(object sender, EventArgs e)
		{
			this.tbBrandCar.Clear();
			this.tbModelCar.Clear();
			this.tbRelaseYear.Clear();
			this.tbCost.Clear();
		}

		public bool ActivOkButton()
		{
			if (tbBrandCar.Text.Length > 0 && tbModelCar.Text.Length > 0 &&
					tbRelaseYear.Text.Length > 0 && tbCost.Text.Length > 0)
			{
				if (CurrentDate())
				{
					btOk.Enabled = true;
					return true;
				}
			}
			btOk.Enabled = false;
			return false;
		}


		private bool CurrentDate()
		{
			DateTime currentYear = DateTime.Now;
			try
			{
				if (currentYear.Year >= Int32.Parse(tbRelaseYear.Text))
				{
					return true;
				}
			}
			catch (Exception a)
			{
				MessageBox.Show(a.ToString());
			}
			MessageBox.Show("Input correct year");
			tbRelaseYear.Focus();
			return false;
		}
	}
}



