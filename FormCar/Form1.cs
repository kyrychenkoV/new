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
		readonly List<Car> collection = new List<Car>();

		private void btCreateCer_Click(object sender, EventArgs e)
		{
			FormCreateCar formCar = new FormCreateCar();
			formCar.ShowDialog();
			Car car = new Car();
			try
			{
				car.brandCar = formCar.GetTextBoxBrandCar;
				car.modelCar = formCar.GetTextBoxtbModelCar;
				car.releaseYear = formCar.GetTextBoxtbRelaseYear;
				car.cost = formCar.GetTextBoxtbtbCost;
				if (formCar.ButtonClick())
				{
					collection.Add(car);
				}
			}
			catch (Exception a)
			{
				MessageBox.Show(a.ToString());
			}
		}

		private void btShowCar_Click(object sender, EventArgs e)
		{
			try
			{
				FormListView listview = new FormListView();
				listview.AddCarListView(collection);
				listview.Show();
			}
			catch (Exception a)
			{
				MessageBox.Show(a.ToString());
			}

		}

		private void btDeleteCar_Click(object sender, EventArgs e)
		{
			FormClear clear = new FormClear();

			clear.AddComponentComboBox(collection);
			clear.ShowDialog();

			try
			{
				if (clear.GetIndexComboBox() >= 0)
				{
					collection.RemoveAt(clear.GetIndexComboBox());
				}
			}
			catch (Exception a)
			{
				MessageBox.Show(a.ToString());
			}
		}

		private void btExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
