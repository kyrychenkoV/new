namespace FormCar
{
	partial class FormCreateCar
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
			this.lbBrandCar = new System.Windows.Forms.Label();
			this.tbBrandCar = new System.Windows.Forms.TextBox();
			this.tbModelCar = new System.Windows.Forms.TextBox();
			this.lbModelCar = new System.Windows.Forms.Label();
			this.tbRelaseYear = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbBrandCar
			// 
			this.lbBrandCar.AutoSize = true;
			this.lbBrandCar.Location = new System.Drawing.Point(37, 29);
			this.lbBrandCar.Name = "lbBrandCar";
			this.lbBrandCar.Size = new System.Drawing.Size(54, 13);
			this.lbBrandCar.TabIndex = 0;
			this.lbBrandCar.Text = "Brand Car";
			// 
			// tbBrandCar
			// 
			this.tbBrandCar.Location = new System.Drawing.Point(107, 26);
			this.tbBrandCar.Name = "tbBrandCar";
			this.tbBrandCar.Size = new System.Drawing.Size(100, 20);
			this.tbBrandCar.TabIndex = 1;
			this.tbBrandCar.TextChanged += new System.EventHandler(this.tbBrandCar_TextChanged);
			// 
			// tbModelCar
			// 
			this.tbModelCar.Location = new System.Drawing.Point(107, 52);
			this.tbModelCar.Name = "tbModelCar";
			this.tbModelCar.Size = new System.Drawing.Size(100, 20);
			this.tbModelCar.TabIndex = 3;
			this.tbModelCar.TextChanged += new System.EventHandler(this.tbModelCar_TextChanged);
			// 
			// lbModelCar
			// 
			this.lbModelCar.AutoSize = true;
			this.lbModelCar.Location = new System.Drawing.Point(37, 55);
			this.lbModelCar.Name = "lbModelCar";
			this.lbModelCar.Size = new System.Drawing.Size(55, 13);
			this.lbModelCar.TabIndex = 2;
			this.lbModelCar.Text = "Model Car";
			// 
			// tbRelaseYear
			// 
			this.tbRelaseYear.Location = new System.Drawing.Point(107, 78);
			this.tbRelaseYear.Name = "tbRelaseYear";
			this.tbRelaseYear.Size = new System.Drawing.Size(100, 20);
			this.tbRelaseYear.TabIndex = 5;
			this.tbRelaseYear.TextChanged += new System.EventHandler(this.tbRelaseYear_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Release Year";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(107, 104);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 7;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Cost";
			// 
			// FormCreateCar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(256, 207);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbRelaseYear);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbModelCar);
			this.Controls.Add(this.lbModelCar);
			this.Controls.Add(this.tbBrandCar);
			this.Controls.Add(this.lbBrandCar);
			this.Name = "FormCreateCar";
			this.Text = "FormCreateCar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbBrandCar;
		private System.Windows.Forms.TextBox tbBrandCar;
		private System.Windows.Forms.TextBox tbModelCar;
		private System.Windows.Forms.Label lbModelCar;
		private System.Windows.Forms.TextBox tbRelaseYear;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label3;
	}
}