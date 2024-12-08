using Tyuiu.ChigurovMV.Sprint6.Task6.V20.Lib;

namespace Tyuiu.ChigurovMV.Sprint6.Task6.V20
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void buttonOpenFile_Click(object sender, EventArgs e)
		{
			openFileDialogTask.ShowDialog();
			openFilePath = openFileDialogTask.FileName;
			foreach (string line in File.ReadLines(openFilePath))
			{
				textBoxInput_CMV.AppendText(line + Environment.NewLine);
			}
			groupBoxInput_CMV.Text = groupBoxInput_CMV.Text + " " + openFileDialogTask.FileName;
			buttonDone_CMV.Enabled = true;
		}

		string openFilePath;
		DataService ds = new DataService();
		private void buttonDone_Click(object sender, EventArgs e)
		{
			textBoxOutput_CMV.Text = ds.CollectTextFromFile(openFilePath);
		}

		private void buttonHelp_Click(object sender, EventArgs e)
		{
			FormAbout formAbout = new FormAbout();
			formAbout.ShowDialog();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}
	}
}
