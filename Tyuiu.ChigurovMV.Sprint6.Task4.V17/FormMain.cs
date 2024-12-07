using Tyuiu.ChigurovMV.Sprint6.Task4.V17.Lib;

namespace Tyuiu.ChigurovMV.Sprint6.Task4.V17
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		DataService ds = new DataService();

		private void buttonDone_Click(object sender, EventArgs e)
		{
			try
			{
				int startValue = Convert.ToInt32(textBoxStartValue_CMV.Text);
				int stopValue = Convert.ToInt32(textBoxStopValue_CMV.Text);

				int len = stopValue - startValue + 1;

				double[] valueArray = new double[len];

				valueArray = ds.GetMassFunction(startValue, stopValue);

				this.chartFunction_CMV.ChartAreas[0].AxisX.Title = "��� X";
				this.chartFunction_CMV.ChartAreas[0].AxisY.Title = "��� Y";

				textBoxResult_CMV.Text = "";

				chartFunction_CMV.Series[0].Points.Clear();

				for (int i = 0; i < len; i++)
				{
					this.chartFunction_CMV.Series[0].Points.AddXY(startValue, valueArray[i]);
					textBoxResult_CMV.AppendText(valueArray[i] + Environment.NewLine);
					startValue++;
				}
			}
			catch
			{
				MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonHelp_Click(object sender, EventArgs e)
		{
			MessageBox.Show("���� 4 �������� ������� ������ ����-24-1 ������� ������ �������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{
				string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask4.txt" });
				File.WriteAllText(path, textBoxResult_CMV.Text);

				DialogResult dialogResult = MessageBox.Show("����" + path + " �������� �������! \n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
				if (dialogResult == DialogResult.Yes)
				{
					System.Diagnostics.Process txt = new System.Diagnostics.Process();
					txt.StartInfo.FileName = "notepad.exe";
					txt.StartInfo.Arguments = path;
					txt.Start();
				}
			}
			catch
			{
				MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}
	}


}
