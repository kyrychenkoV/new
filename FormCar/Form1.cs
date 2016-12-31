using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCar
{
	public partial class FormCar : Form
	{
		public FormCar()
		{
			InitializeComponent();

		}
		Car car = new Car();
		List<Car> collection = new List<Car>();
		FormListView listview = new FormListView();

		private void btCreateCer_Click(object sender, EventArgs e)
		{
			FormCreateCar formCar = new FormCreateCar();
			formCar.ShowDialog();

			car.brandCar = formCar.GetTextBoxBrandCar;
			car.modelCar = formCar.GetTextBoxtbModelCar;
			car.releaseYear = formCar.GetTextBoxtbRelaseYear;
			car.cost = formCar.GetTextBoxtbtbCost;
			collection.Add(car);

			listview.AddCarListView(collection);
		}

		private void btShowCar_Click(object sender, EventArgs e)
		{
			listview.Show();
		}

		private void btDeleteCar_Click(object sender, EventArgs e)
		{
			collection.RemoveAt(1);
		}
	}
}
