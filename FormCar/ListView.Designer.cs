namespace FormCar
{
	partial class FormListView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lvShowCar = new System.Windows.Forms.ListView();
			this.chNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chBrandCar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chModelCar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// lvShowCar
			// 
			this.lvShowCar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNumber,
            this.chBrandCar,
            this.chModelCar,
            this.chYear,
            this.chCost});
			this.lvShowCar.GridLines = true;
			this.lvShowCar.Location = new System.Drawing.Point(13, 13);
			this.lvShowCar.Name = "lvShowCar";
			this.lvShowCar.Size = new System.Drawing.Size(363, 274);
			this.lvShowCar.TabIndex = 0;
			this.lvShowCar.UseCompatibleStateImageBehavior = false;
			this.lvShowCar.View = System.Windows.Forms.View.Details;
			// 
			// chNumber
			// 
			this.chNumber.Text = "№";
			this.chNumber.Width = 36;
			// 
			// chBrandCar
			// 
			this.chBrandCar.Text = "Марка втомобиля";
			this.chBrandCar.Width = 122;
			// 
			// chModelCar
			// 
			this.chModelCar.Text = "Модель";
			// 
			// chYear
			// 
			this.chYear.Text = "Год выпуска";
			this.chYear.Width = 77;
			// 
			// chCost
			// 
			this.chCost.Text = "Стоимость";
			this.chCost.Width = 76;
			// 
			// FormListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(390, 298);
			this.Controls.Add(this.lvShowCar);
			this.Name = "FormListView";
			this.Text = "ListView";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvShowCar;
		private System.Windows.Forms.ColumnHeader chNumber;
		private System.Windows.Forms.ColumnHeader chBrandCar;
		private System.Windows.Forms.ColumnHeader chModelCar;
		private System.Windows.Forms.ColumnHeader chYear;
		private System.Windows.Forms.ColumnHeader chCost;
	}
}