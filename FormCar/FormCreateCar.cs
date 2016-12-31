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
			tbCost.Text = "5";
			tbModelCar.Text = "6";
			//btOk.Enabled = false;


		}
		

		public string GetTextBoxBrandCar => tbBrandCar.Text;

		public string GetTextBoxtbModelCar => tbModelCar.Text;

		public string GetTextBoxtbRelaseYear => tbRelaseYear.Text;

		public string GetTextBoxtbtbCost => tbCost.Text;

		private void tbBrandCar_TextChanged(object sender, EventArgs e)
		{
			
		}

		

		private void tbRelaseYear_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			if ((tbBrandCar.Text.Length == 0) || (tbModelCar.Text.Length == 0) ||
					(tbRelaseYear.Text.Length == 0) || (tbCost.Text.Length == 0))
			{
				btOk.Enabled = false;
			}
			else
			{
				btOk.Enabled = true;
			}

		}

		private void btOkCreateCar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btClear_Click(object sender, EventArgs e)
		{
			this.tbBrandCar.Clear();
			this.tbModelCar.Clear();
			this.tbRelaseYear.Clear();
			this.tbCost.Clear();
		}
		 private void tbRelaseYear_KeyPress(object sender, KeyPressEventArgs e)
		 {
			 tbRelaseYear.MaxLength = 4;
			 if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
			 {
				 return;
			 }
			 if (Char.IsControl(e.KeyChar))
			 {
				 if (e.KeyChar == (char) Keys.Enter)
				 {
					 tbCost.Focus();
				 }
			 }
			 e.Handled=true;

		 }

		/*public bool  ActivityOkButton()
		{
			if (tbBrandCar.Text.Length == 0 || tbModelCar.Text.Length == 0 ||
			    tbRelaseYear.Text.Length == 0 || tbCost.Text.Length == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}*/
	}
}
