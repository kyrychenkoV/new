namespace FormCar
{
	partial class FormCar
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
			this.btCreateCer = new System.Windows.Forms.Button();
			this.btShowCar = new System.Windows.Forms.Button();
			this.btDeleteCar = new System.Windows.Forms.Button();
			this.btExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btCreateCer
			// 
			this.btCreateCer.Location = new System.Drawing.Point(60, 35);
			this.btCreateCer.Name = "btCreateCer";
			this.btCreateCer.Size = new System.Drawing.Size(99, 31);
			this.btCreateCer.TabIndex = 0;
			this.btCreateCer.Text = "Create Car";
			this.btCreateCer.UseVisualStyleBackColor = true;
			this.btCreateCer.Click += new System.EventHandler(this.btCreateCer_Click);
			// 
			// btShowCar
			// 
			this.btShowCar.Location = new System.Drawing.Point(60, 83);
			this.btShowCar.Name = "btShowCar";
			this.btShowCar.Size = new System.Drawing.Size(99, 31);
			this.btShowCar.TabIndex = 1;
			this.btShowCar.Text = "Show Car";
			this.btShowCar.UseVisualStyleBackColor = true;
			this.btShowCar.Click += new System.EventHandler(this.btShowCar_Click);
			// 
			// btDeleteCar
			// 
			this.btDeleteCar.Location = new System.Drawing.Point(60, 132);
			this.btDeleteCar.Name = "btDeleteCar";
			this.btDeleteCar.Size = new System.Drawing.Size(99, 31);
			this.btDeleteCar.TabIndex = 2;
			this.btDeleteCar.Text = "Delete Car";
			this.btDeleteCar.UseVisualStyleBackColor = true;
			// 
			// btExit
			// 
			this.btExit.Location = new System.Drawing.Point(60, 186);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(99, 31);
			this.btExit.TabIndex = 3;
			this.btExit.Text = "Exit";
			this.btExit.UseVisualStyleBackColor = true;
			// 
			// FormCar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(223, 262);
			this.Controls.Add(this.btExit);
			this.Controls.Add(this.btDeleteCar);
			this.Controls.Add(this.btShowCar);
			this.Controls.Add(this.btCreateCer);
			this.Name = "FormCar";
			this.Text = "Form Car";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btCreateCer;
		private System.Windows.Forms.Button btShowCar;
		private System.Windows.Forms.Button btDeleteCar;
		private System.Windows.Forms.Button btExit;
	}
}

