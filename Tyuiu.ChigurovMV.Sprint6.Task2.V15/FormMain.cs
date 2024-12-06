using Tyuiu.ChigurovMV.Sprint6.Task2.V15.Lib;

namespace Tyuiu.ChigurovMV.Sprint6.Task2.V15
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}
		DataService ds = new DataService();

		private void butttonDone_Click(object sender, EventArgs e)
		{

			try
			{
				this.chartFunction_CMV.Series[0].Points.Clear();
				this.chartFunction_CMV.Titles.Clear();
				int startValue = Convert.ToInt32(textBoxStartValue_CMV.Text);
				int stopValue = Convert.ToInt32(textBoxStopValue_CMV.Text);


				int len = ds.GetMassFunction(startValue, stopValue).Length;

				double[] valueArray = new double[len];

				valueArray = ds.GetMassFunction(startValue, stopValue);

				this.chartFunction_CMV.Titles.Add("График функции");

				this.chartFunction_CMV.ChartAreas[0].AxisX.Title = "Ось X";
				this.chartFunction_CMV.ChartAreas[0].AxisY.Title = "Ось Y";

				for (int i = 0; i < len; i++)
				{
					this.dataGridViewFunction_CMV.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));

					this.chartFunction_CMV.Series[0].Points.AddXY(startValue, valueArray[i]);

					startValue++;
				}
				
			}
			catch
			{
				MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void buttonHelp_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Таск 2 выполнил студент группы ПКТб-24-1 Чигуров Максим Владиславович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void buttonDone_MouseEnter(object sender, EventArgs e)
		{
			buttonDone_CMV.BackColor = Color.Red;
		}

		private void buttonDone_MouseLeave(object sender, EventArgs e)
		{
			buttonDone_CMV.BackColor = Color.Green;
		}

		private void buttonDone_MouseDown(object sender, MouseEventArgs e)
		{
			buttonDone_CMV.BackColor = Color.Blue;
		}
	}
	
}
