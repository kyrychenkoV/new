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

		private void FormClear_Load(object sender, EventArgs e)
		{

		}

		public void AddComponentComboBox(List<Car> collection)
		{
			FormListView a=new FormListView();
			a.GetList();
			for (int i = 0; i < collection.Count; i++)
			{
				a.GetList();
				this.cbDeleteCar.Items.Add((i+1).ToString());
			}
			}
		
		private void btOk_Click(object sender, EventArgs e)
		{
			MessageBox.Show((cbDeleteCar.SelectedIndex+1).ToString());
			this.Close();
		}

		public int GetIndexComboBox()
		{
			return cbDeleteCar.SelectedIndex;
		}
	}
}
