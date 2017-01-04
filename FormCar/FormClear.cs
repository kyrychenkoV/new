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
	public partial class FormClear : Form
	{
		public FormClear()
		{
			InitializeComponent();
		}
		
		public void AddComponentComboBox(List<Car> collection)
		{
			FormListView a = new FormListView();
			a.GetList();
			for (int i = 0; i < collection.Count; i++)
			{
				a.GetList();
				this.cbDeleteCar.Items.Add((i + 1).ToString());
			}
		}

		private void btOk_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public int GetIndexComboBox()
		{
			return cbDeleteCar.SelectedIndex;
		}
	}
}
