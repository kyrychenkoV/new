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
		
		List<Car> collection = new List<Car>();
		

		private void btCreateCer_Click(object sender, EventArgs e)
		{
			FormCreateCar formCar = new FormCreateCar();
			formCar.ShowDialog();
			Car car = new Car();
			car.brandCar = formCar.GetTextBoxBrandCar;
			car.modelCar = formCar.GetTextBoxtbModelCar;
			car.releaseYear = formCar.GetTextBoxtbRelaseYear;
			car.cost = formCar.GetTextBoxtbtbCost;
			collection.Add(car);
			
			//listview.AddCarListView(collection);
		}

		private void btShowCar_Click(object sender, EventArgs e)
		{
			FormListView listview = new FormListView();
			listview.AddCarListView(collection);
			listview.Show();
		}

		private void btDeleteCar_Click(object sender, EventArgs e)
		{
			FormClear clear=new FormClear();
			
			clear.AddComponentComboBox(collection);
			clear.ShowDialog();
			collection.RemoveAt(clear.GetIndexComboBox());
		}

		private void btExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
