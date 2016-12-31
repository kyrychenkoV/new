using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

			ListViewItem m = new ListViewItem((collection.Count).ToString()); //lvShowCar.Items.Count.ToString()

			//lvShowCar.Items.Clear();
			foreach (var number in collection)
			{
				m.SubItems.Add(((Car)number).brandCar);
				m.SubItems.Add(((Car)number).modelCar);
				m.SubItems.Add(((Car)number).releaseYear);
				m.SubItems.Add(((Car)number).cost);
				m.Remove();
				lvShowCar.Items.Add(m);
				MessageBox.Show("BRANDCAR" + " " + collection.Count.ToString() + "= " + ((Car)number).brandCar);
			}
			
			/*if (collection.Count == 3)
			{
				lvShowCar.Items.Clear();
				m.Remove();
			}*/

		}




	}
}
