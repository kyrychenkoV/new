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
			
			

		}
		Car car = new Car();
		private string a;

		public string GettbBrandCar
		{
			get { return tbBrandCar.Text; }
		}

		private void tbBrandCar_TextChanged(object sender, EventArgs e)
		{
			
			a = tbBrandCar.Text;
		}

		private void tbModelCar_TextChanged(object sender, EventArgs e)
		{
			car.modelCar = tbModelCar.Text;
		}

		private void tbRelaseYear_TextChanged(object sender, EventArgs e)
		{
			car.releaseYear = tbRelaseYear.Text;
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
