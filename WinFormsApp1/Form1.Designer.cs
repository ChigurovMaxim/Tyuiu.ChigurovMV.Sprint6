namespace WinFormsApp1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			dataGridView1 = new DataGridView();
			comboBox1 = new ComboBox();
			comboBox2 = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.ForeColor = Color.Red;
			textBox1.Location = new Point(99, 53);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(260, 23);
			textBox1.TabIndex = 0;
			textBox1.Text = "Привет мир";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(119, 132);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(240, 150);
			dataGridView1.TabIndex = 1;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(435, 132);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(121, 23);
			comboBox1.TabIndex = 2;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(461, 236);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(121, 23);
			comboBox2.TabIndex = 3;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(comboBox2);
			Controls.Add(comboBox1);
			Controls.Add(dataGridView1);
			Controls.Add(textBox1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private DataGridView dataGridView1;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
	}
}
