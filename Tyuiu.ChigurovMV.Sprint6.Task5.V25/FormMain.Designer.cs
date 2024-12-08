namespace Tyuiu.ChigurovMV.Sprint6.Task5.V25
{
	partial class FormMain
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			panelTop_CMV = new Panel();
			buttonDone_CMV = new Button();
			buttonOpenFile_CMV = new Button();
			buttonHelp_CMV = new Button();
			groupBoxTask_CMV = new GroupBox();
			textBoxTask_CMV = new TextBox();
			panelSplitContainer_CMV = new Panel();
			splitContainer_CMV = new SplitContainer();
			groupBoxOutput_CMV = new GroupBox();
			dataGridViewNums = new DataGridView();
			chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
			panelTop_CMV.SuspendLayout();
			groupBoxTask_CMV.SuspendLayout();
			panelSplitContainer_CMV.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer_CMV).BeginInit();
			splitContainer_CMV.Panel1.SuspendLayout();
			splitContainer_CMV.Panel2.SuspendLayout();
			splitContainer_CMV.SuspendLayout();
			groupBoxOutput_CMV.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
			((System.ComponentModel.ISupportInitialize)chartDiag).BeginInit();
			SuspendLayout();
			// 
			// panelTop_CMV
			// 
			panelTop_CMV.BackColor = Color.White;
			panelTop_CMV.Controls.Add(buttonDone_CMV);
			panelTop_CMV.Controls.Add(buttonOpenFile_CMV);
			panelTop_CMV.Controls.Add(buttonHelp_CMV);
			panelTop_CMV.Controls.Add(groupBoxTask_CMV);
			panelTop_CMV.Dock = DockStyle.Top;
			panelTop_CMV.Location = new Point(0, 0);
			panelTop_CMV.Name = "panelTop_CMV";
			panelTop_CMV.Size = new Size(784, 100);
			panelTop_CMV.TabIndex = 1;
			// 
			// buttonDone_CMV
			// 
			buttonDone_CMV.BackColor = Color.FromArgb(0, 192, 0);
			buttonDone_CMV.Cursor = Cursors.Hand;
			buttonDone_CMV.Location = new Point(522, 23);
			buttonDone_CMV.Name = "buttonDone_CMV";
			buttonDone_CMV.Size = new Size(80, 65);
			buttonDone_CMV.TabIndex = 4;
			buttonDone_CMV.Text = "Выполнить";
			buttonDone_CMV.UseVisualStyleBackColor = false;
			buttonDone_CMV.Click += buttonDone_Click;
			// 
			// buttonOpenFile_CMV
			// 
			buttonOpenFile_CMV.BackColor = Color.FromArgb(128, 128, 255);
			buttonOpenFile_CMV.Cursor = Cursors.Hand;
			buttonOpenFile_CMV.Location = new Point(608, 23);
			buttonOpenFile_CMV.Name = "buttonOpenFile_CMV";
			buttonOpenFile_CMV.Size = new Size(80, 65);
			buttonOpenFile_CMV.TabIndex = 5;
			buttonOpenFile_CMV.Text = "Открыть файл";
			buttonOpenFile_CMV.UseVisualStyleBackColor = false;
			buttonOpenFile_CMV.Click += buttonOpenFile_Click;
			// 
			// buttonHelp_CMV
			// 
			buttonHelp_CMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			buttonHelp_CMV.BackColor = SystemColors.ActiveCaption;
			buttonHelp_CMV.Cursor = Cursors.Hand;
			buttonHelp_CMV.Location = new Point(692, 23);
			buttonHelp_CMV.Name = "buttonHelp_CMV";
			buttonHelp_CMV.Size = new Size(80, 65);
			buttonHelp_CMV.TabIndex = 6;
			buttonHelp_CMV.Text = "Справка";
			buttonHelp_CMV.UseVisualStyleBackColor = false;
			buttonHelp_CMV.Click += buttonHelp_Click;
			// 
			// groupBoxTask_CMV
			// 
			groupBoxTask_CMV.Controls.Add(textBoxTask_CMV);
			groupBoxTask_CMV.Location = new Point(5, 3);
			groupBoxTask_CMV.Name = "groupBoxTask_CMV";
			groupBoxTask_CMV.Size = new Size(511, 91);
			groupBoxTask_CMV.TabIndex = 3;
			groupBoxTask_CMV.TabStop = false;
			groupBoxTask_CMV.Text = "Условие:";
			// 
			// textBoxTask_CMV
			// 
			textBoxTask_CMV.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBoxTask_CMV.Location = new Point(6, 22);
			textBoxTask_CMV.Multiline = true;
			textBoxTask_CMV.Name = "textBoxTask_CMV";
			textBoxTask_CMV.ReadOnly = true;
			textBoxTask_CMV.Size = new Size(497, 63);
			textBoxTask_CMV.TabIndex = 0;
			textBoxTask_CMV.Text = "Прочитать данные из файла InPutFileTask5V25.txt. Вывести в dataGridView.\r\nДан список из чисел. Вывести все числа, не равные 0. \r\nПостроить диаграмму по этим значениям.";
			// 
			// panelSplitContainer_CMV
			// 
			panelSplitContainer_CMV.Controls.Add(splitContainer_CMV);
			panelSplitContainer_CMV.Dock = DockStyle.Fill;
			panelSplitContainer_CMV.Location = new Point(0, 100);
			panelSplitContainer_CMV.Name = "panelSplitContainer_CMV";
			panelSplitContainer_CMV.Size = new Size(784, 341);
			panelSplitContainer_CMV.TabIndex = 2;
			// 
			// splitContainer_CMV
			// 
			splitContainer_CMV.Dock = DockStyle.Fill;
			splitContainer_CMV.Location = new Point(0, 0);
			splitContainer_CMV.Name = "splitContainer_CMV";
			// 
			// splitContainer_CMV.Panel1
			// 
			splitContainer_CMV.Panel1.BackColor = Color.White;
			splitContainer_CMV.Panel1.Controls.Add(groupBoxOutput_CMV);
			// 
			// splitContainer_CMV.Panel2
			// 
			splitContainer_CMV.Panel2.Controls.Add(chartDiag);
			splitContainer_CMV.Size = new Size(784, 341);
			splitContainer_CMV.SplitterDistance = 217;
			splitContainer_CMV.TabIndex = 0;
			// 
			// groupBoxOutput_CMV
			// 
			groupBoxOutput_CMV.Controls.Add(dataGridViewNums);
			groupBoxOutput_CMV.Dock = DockStyle.Fill;
			groupBoxOutput_CMV.Location = new Point(0, 0);
			groupBoxOutput_CMV.Name = "groupBoxOutput_CMV";
			groupBoxOutput_CMV.Size = new Size(217, 341);
			groupBoxOutput_CMV.TabIndex = 0;
			groupBoxOutput_CMV.TabStop = false;
			groupBoxOutput_CMV.Text = "Вывод данных:";
			// 
			// dataGridViewNums
			// 
			dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewNums.ColumnHeadersVisible = false;
			dataGridViewNums.Dock = DockStyle.Fill;
			dataGridViewNums.Location = new Point(3, 19);
			dataGridViewNums.Name = "dataGridViewNums";
			dataGridViewNums.RowHeadersVisible = false;
			dataGridViewNums.Size = new Size(211, 319);
			dataGridViewNums.TabIndex = 0;
			// 
			// chartDiag
			// 
			chartArea1.Name = "ChartArea1";
			chartDiag.ChartAreas.Add(chartArea1);
			chartDiag.Dock = DockStyle.Fill;
			legend1.Name = "Legend1";
			chartDiag.Legends.Add(legend1);
			chartDiag.Location = new Point(0, 0);
			chartDiag.Name = "chartDiag";
			series1.ChartArea = "ChartArea1";
			series1.IsVisibleInLegend = false;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			chartDiag.Series.Add(series1);
			chartDiag.Size = new Size(563, 341);
			chartDiag.TabIndex = 0;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(784, 441);
			Controls.Add(panelSplitContainer_CMV);
			Controls.Add(panelTop_CMV);
			MinimumSize = new Size(800, 480);
			Name = "FormMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Спринт 6 | Таск 5 | Вариант 25 | Чигуров М. В. ";
			panelTop_CMV.ResumeLayout(false);
			groupBoxTask_CMV.ResumeLayout(false);
			groupBoxTask_CMV.PerformLayout();
			panelSplitContainer_CMV.ResumeLayout(false);
			splitContainer_CMV.Panel1.ResumeLayout(false);
			splitContainer_CMV.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer_CMV).EndInit();
			splitContainer_CMV.ResumeLayout(false);
			groupBoxOutput_CMV.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
			((System.ComponentModel.ISupportInitialize)chartDiag).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Panel panelTop_CMV;
		private Panel panelSplitContainer_CMV;
		private SplitContainer splitContainer_CMV;
		private Button buttonDone_CMV;
		private Button buttonOpenFile_CMV;
		private Button buttonHelp_CMV;
		private GroupBox groupBoxTask_CMV;
		private TextBox textBoxTask_CMV;
		private GroupBox groupBoxOutput_CMV;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
		private DataGridView dataGridViewNums;
	}
}
