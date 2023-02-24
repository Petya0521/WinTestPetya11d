namespace TestWinPetya
{
	partial class Form1
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
			this.txt = new System.Windows.Forms.TextBox();
			this.lbl = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.textB = new System.Windows.Forms.TextBox();
			this.texb = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.lbl3 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.btn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// txt
			// 
			this.txt.Location = new System.Drawing.Point(12, 100);
			this.txt.Name = "txt";
			this.txt.Size = new System.Drawing.Size(100, 22);
			this.txt.TabIndex = 0;
			// 
			// lbl
			// 
			this.lbl.AutoSize = true;
			this.lbl.Location = new System.Drawing.Point(34, 57);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(37, 16);
			this.lbl.TabIndex = 1;
			this.lbl.Text = "Име:";
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Location = new System.Drawing.Point(21, 150);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(69, 16);
			this.lbl1.TabIndex = 2;
			this.lbl1.Text = "Презиме:";
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Location = new System.Drawing.Point(21, 232);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(69, 16);
			this.lbl2.TabIndex = 3;
			this.lbl2.Text = "Фамилия:";
			// 
			// textB
			// 
			this.textB.Location = new System.Drawing.Point(12, 181);
			this.textB.Name = "textB";
			this.textB.Size = new System.Drawing.Size(100, 22);
			this.textB.TabIndex = 4;
			// 
			// texb
			// 
			this.texb.Location = new System.Drawing.Point(12, 269);
			this.texb.Name = "texb";
			this.texb.Size = new System.Drawing.Size(100, 22);
			this.texb.TabIndex = 5;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Учащ",
            "Държавен служител",
            "Работник в частна фирма",
            "Безработник"});
			this.comboBox1.Location = new System.Drawing.Point(243, 181);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(171, 24);
			this.comboBox1.TabIndex = 7;
			// 
			// lbl3
			// 
			this.lbl3.AutoSize = true;
			this.lbl3.Location = new System.Drawing.Point(36, 312);
			this.lbl3.Name = "lbl3";
			this.lbl3.Size = new System.Drawing.Size(38, 16);
			this.lbl3.TabIndex = 8;
			this.lbl3.Text = "ЕГН:";
			this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(12, 340);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(100, 22);
			this.txt1.TabIndex = 9;
			// 
			// btn
			// 
			this.btn.Location = new System.Drawing.Point(281, 370);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(133, 23);
			this.btn.TabIndex = 10;
			this.btn.Text = "Отпечатване";
			this.btn.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(273, 150);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 16);
			this.label1.TabIndex = 11;
			this.label1.Text = "Сфера на работа";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(24, 406);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(66, 20);
			this.checkBox1.TabIndex = 12;
			this.checkBox1.Text = "Жена";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 498);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.lbl3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.texb);
			this.Controls.Add(this.textB);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.lbl);
			this.Controls.Add(this.txt);
			this.Name = "Form1";
			this.Text = "Хора";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.TextBox textB;
		private System.Windows.Forms.TextBox texb;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label lbl3;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Button btn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}

