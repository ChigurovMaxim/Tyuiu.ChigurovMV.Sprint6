using System.IO;
using Tyuiu.ChigurovMV.Sprint6.Task7.V24.Lib;

namespace Tyuiu.ChigurovMV.Sprint6.Task7.V24
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
			openFileDialogTask.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
			saveFileDialogMatrix.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
		}

		static int rows;
		static int columns;
		static string openFilePath;

		DataService ds = new DataService();

		public static int[,] LoadFromFileData(string filePath)
		{
			rows = File.ReadLines(filePath).Count();
			string[] strings = File.ReadAllText(filePath).Split("\n");
			columns = strings[0].Split(';').Length;
			int[,] matrix = new int[rows, columns];

			using (StreamReader stream = new StreamReader(filePath))
			{
				string line;
				int count = 0;
				while ((line = stream.ReadLine()) != null)
				{
					string[] row = line.Split(';');
					for (int i = 0; i < columns; i++)
					{
						matrix[count, i] = Convert.ToInt32(row[i]);
					}
					count++;
				}
			}
			return matrix;
		}

		private void buttonHelp_Click(object sender, EventArgs e)
		{
			FormAbout formAbout = new FormAbout();
			formAbout.ShowDialog();
		}



		private void buttonOpenFile_Click(object sender, EventArgs e)
		{
			openFileDialogTask.ShowDialog();
			openFilePath = openFileDialogTask.FileName;

			int[,] arrayValues = new int[rows, columns];

			arrayValues = LoadFromFileData(openFilePath);

			dataGridViewIn_CMV.ColumnCount = columns;
			dataGridViewIn_CMV.RowCount = rows;
			dataGridViewOut_CMV.ColumnCount = columns;
			dataGridViewOut_CMV.RowCount = rows;

			dataGridViewIn_CMV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridViewOut_CMV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < columns; c++)
				{
					dataGridViewIn_CMV.Rows[r].Cells[c].Value = arrayValues[r, c];
				}
			}

			buttonDone_CMV.Enabled = true;
		}

		private void buttonDone_Click(object sender, EventArgs e)
		{
			int[,] arrayValues = new int[rows, columns];
			arrayValues = ds.GetMatrix(openFilePath);

			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < columns; c++)
				{
					dataGridViewOut_CMV.Rows[r].Cells[c].Value = arrayValues[r, c];
				}
			}
			buttonSaveFile_CMV.Enabled = true;
		}

		private void buttonSaveFile_Click(object sender, EventArgs e)
		{
			saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
			saveFileDialogMatrix.InitialDirectory = @"C:\DataSprint6";
			saveFileDialogMatrix.ShowDialog();

			string path = saveFileDialogMatrix.FileName;

			FileInfo fileInfo = new FileInfo(path);
			if (fileInfo.Exists)
			{
				File.Delete(path);
			}

			string str = "";

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					if (j != columns - 1)
					{
						str += dataGridViewOut_CMV.Rows[i].Cells[j].Value + ";";
					}
					else
					{
						str += dataGridViewOut_CMV.Rows[i].Cells[j].Value;
					}
				}
				File.AppendAllText(path, str + Environment.NewLine);
				str = "";
			}
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			dataGridViewIn_CMV.ColumnCount = 50;
			dataGridViewOut_CMV.ColumnCount = 50;

			dataGridViewIn_CMV.RowCount = 50;
			dataGridViewOut_CMV.RowCount = 50;


			for (int i = 0; i < 50; i++)
			{
				dataGridViewIn_CMV.Columns[i].Width = 25;
				dataGridViewOut_CMV.Columns[i].Width = 25;
			}
		}

		private void buttonOpenFile_CMV_MouseEnter(object sender, EventArgs e)
		{
			toolTipTask.ToolTipTitle = "Открыть файл";

		}

		private void buttonSaveFile_CMV_MouseEnter(object sender, EventArgs e)
		{
			toolTipTask.ToolTipTitle = "Сохранить файл";
		}

		private void buttonDone_CMV_MouseEnter(object sender, EventArgs e)
		{
			toolTipTask.ToolTipTitle = "Выполнить";
		}

		private void buttonHelp_CMV_MouseEnter(object sender, EventArgs e)
		{
			toolTipTask.ToolTipTitle = "Справка";
		}
	}
}
