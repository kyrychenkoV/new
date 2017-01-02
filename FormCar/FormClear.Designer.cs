namespace FormCar
{
	partial class FormClear
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
			this.cbDeleteCar = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbDeleteCar
			// 
			this.cbDeleteCar.FormattingEnabled = true;
			this.cbDeleteCar.Location = new System.Drawing.Point(28, 53);
			this.cbDeleteCar.Name = "cbDeleteCar";
			this.cbDeleteCar.Size = new System.Drawing.Size(121, 21);
			this.cbDeleteCar.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(207, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Выберете номер удаляемого елемента";
			// 
			// btOk
			// 
			this.btOk.Location = new System.Drawing.Point(28, 103);
			this.btOk.Name = "btOk";
			this.btOk.Size = new System.Drawing.Size(75, 23);
			this.btOk.TabIndex = 2;
			this.btOk.Text = "Ok";
			this.btOk.UseVisualStyleBackColor = true;
			this.btOk.Click += new System.EventHandler(this.btOk_Click);
			// 
			// FormClear
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(295, 197);
			this.Controls.Add(this.btOk);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbDeleteCar);
			this.Name = "FormClear";
			this.Text = "FormClear";
			this.Load += new System.EventHandler(this.FormClear_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbDeleteCar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btOk;
	}
}