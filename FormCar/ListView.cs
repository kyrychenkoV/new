using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCar
{
	public partial class FormListView : Form
	{
		public FormListView()
		{
			InitializeComponent();
			lvShowCar.GridLines = true;
		}

		public void AddCarListView(List<Car> collection)
		{
			lvShowCar.Items.Clear();
			foreach (var number in collection)
			{
				ListViewItem m = new ListViewItem((lvShowCar.Items.Count + 1).ToString());
				lvShowCar.Items.Add(m);
				m.SubItems.Add(((Car)number).brandCar);
				m.SubItems.Add(number.modelCar);
				m.SubItems.Add(number.releaseYear);
				m.SubItems.Add(number.cost);

			}
			}
		public ListView GetList()
		{
			return this.lvShowCar;
		}
	}
}
