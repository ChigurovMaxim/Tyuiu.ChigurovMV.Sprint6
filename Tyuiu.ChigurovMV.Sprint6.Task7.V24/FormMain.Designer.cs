namespace Tyuiu.ChigurovMV.Sprint6.Task7.V24
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			panelTop_CMV = new Panel();
			buttonSaveFile_CMV = new Button();
			buttonDone_CMV = new Button();
			buttonOpenFile_CMV = new Button();
			buttonHelp_CMV = new Button();
			groupBoxTask_CMV = new GroupBox();
			textBoxTask_CMV = new TextBox();
			groupBoxInput_CMV = new GroupBox();
			dataGridViewIn_CMV = new DataGridView();
			groupBoxOutput_CMV = new GroupBox();
			dataGridViewOut_CMV = new DataGridView();
			openFileDialogTask = new OpenFileDialog();
			toolTipTask = new ToolTip(components);
			panelPredTop_CMV = new Panel();
			splitContainer_CMV = new SplitContainer();
			saveFileDialogMatrix = new SaveFileDialog();
			panelTop_CMV.SuspendLayout();
			groupBoxTask_CMV.SuspendLayout();
			groupBoxInput_CMV.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewIn_CMV).BeginInit();
			groupBoxOutput_CMV.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewOut_CMV).BeginInit();
			panelPredTop_CMV.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer_CMV).BeginInit();
			splitContainer_CMV.Panel1.SuspendLayout();
			splitContainer_CMV.Panel2.SuspendLayout();
			splitContainer_CMV.SuspendLayout();
			SuspendLayout();
			// 
			// panelTop_CMV
			// 
			panelTop_CMV.BackColor = Color.White;
			panelTop_CMV.Controls.Add(buttonSaveFile_CMV);
			panelTop_CMV.Controls.Add(buttonDone_CMV);
			panelTop_CMV.Controls.Add(buttonOpenFile_CMV);
			panelTop_CMV.Controls.Add(buttonHelp_CMV);
			panelTop_CMV.Dock = DockStyle.Top;
			panelTop_CMV.Location = new Point(0, 0);
			panelTop_CMV.Name = "panelTop_CMV";
			panelTop_CMV.Size = new Size(809, 88);
			panelTop_CMV.TabIndex = 3;
			// 
			// buttonSaveFile_CMV
			// 
			buttonSaveFile_CMV.BackColor = Color.White;
			buttonSaveFile_CMV.BackgroundImage = Properties.Resources.Blu_Ray_Save_48x48;
			buttonSaveFile_CMV.BackgroundImageLayout = ImageLayout.Zoom;
			buttonSaveFile_CMV.Cursor = Cursors.Hand;
			buttonSaveFile_CMV.Enabled = false;
			buttonSaveFile_CMV.FlatStyle = FlatStyle.Flat;
			buttonSaveFile_CMV.Location = new Point(161, 12);
			buttonSaveFile_CMV.Name = "buttonSaveFile_CMV";
			buttonSaveFile_CMV.Size = new Size(66, 65);
			buttonSaveFile_CMV.TabIndex = 4;
			buttonSaveFile_CMV.UseVisualStyleBackColor = false;
			buttonSaveFile_CMV.Click += buttonSaveFile_Click;
			buttonSaveFile_CMV.MouseEnter += buttonSaveFile_CMV_MouseEnter;
			// 
			// buttonDone_CMV
			// 
			buttonDone_CMV.BackColor = Color.White;
			buttonDone_CMV.BackgroundImage = Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
			buttonDone_CMV.BackgroundImageLayout = ImageLayout.Zoom;
			buttonDone_CMV.Cursor = Cursors.Hand;
			buttonDone_CMV.Enabled = false;
			buttonDone_CMV.FlatStyle = FlatStyle.Flat;
			buttonDone_CMV.Location = new Point(89, 12);
			buttonDone_CMV.Name = "buttonDone_CMV";
			buttonDone_CMV.Size = new Size(66, 65);
			buttonDone_CMV.TabIndex = 4;
			toolTipTask.SetToolTip(buttonDone_CMV, "Произвести обработку файла");
			buttonDone_CMV.UseVisualStyleBackColor = false;
			buttonDone_CMV.Click += buttonDone_Click;
			buttonDone_CMV.MouseEnter += buttonDone_CMV_MouseEnter;
			// 
			// buttonOpenFile_CMV
			// 
			buttonOpenFile_CMV.BackColor = Color.White;
			buttonOpenFile_CMV.BackgroundImage = Properties.Resources.Open_icon_icons_com_73704;
			buttonOpenFile_CMV.BackgroundImageLayout = ImageLayout.Zoom;
			buttonOpenFile_CMV.Cursor = Cursors.Hand;
			buttonOpenFile_CMV.FlatStyle = FlatStyle.Flat;
			buttonOpenFile_CMV.Location = new Point(17, 12);
			buttonOpenFile_CMV.Name = "buttonOpenFile_CMV";
			buttonOpenFile_CMV.Size = new Size(66, 65);
			buttonOpenFile_CMV.TabIndex = 5;
			buttonOpenFile_CMV.Text = "\r\n";
			toolTipTask.SetToolTip(buttonOpenFile_CMV, "\r\n");
			buttonOpenFile_CMV.UseVisualStyleBackColor = false;
			buttonOpenFile_CMV.Click += buttonOpenFile_Click;
			buttonOpenFile_CMV.MouseEnter += buttonOpenFile_CMV_MouseEnter;
			// 
			// buttonHelp_CMV
			// 
			buttonHelp_CMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			buttonHelp_CMV.BackColor = Color.White;
			buttonHelp_CMV.BackgroundImage = Properties.Resources.mark_13708504;
			buttonHelp_CMV.BackgroundImageLayout = ImageLayout.Zoom;
			buttonHelp_CMV.Cursor = Cursors.Hand;
			buttonHelp_CMV.Location = new Point(729, 12);
			buttonHelp_CMV.Name = "buttonHelp_CMV";
			buttonHelp_CMV.Size = new Size(68, 65);
			buttonHelp_CMV.TabIndex = 6;
			buttonHelp_CMV.UseVisualStyleBackColor = false;
			buttonHelp_CMV.Click += buttonHelp_Click;
			buttonHelp_CMV.MouseEnter += buttonHelp_CMV_MouseEnter;
			// 
			// groupBoxTask_CMV
			// 
			groupBoxTask_CMV.Controls.Add(textBoxTask_CMV);
			groupBoxTask_CMV.Dock = DockStyle.Fill;
			groupBoxTask_CMV.Location = new Point(0, 0);
			groupBoxTask_CMV.Name = "groupBoxTask_CMV";
			groupBoxTask_CMV.Size = new Size(809, 100);
			groupBoxTask_CMV.TabIndex = 3;
			groupBoxTask_CMV.TabStop = false;
			groupBoxTask_CMV.Text = "Условие:";
			// 
			// textBoxTask_CMV
			// 
			textBoxTask_CMV.Dock = DockStyle.Fill;
			textBoxTask_CMV.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBoxTask_CMV.Location = new Point(3, 19);
			textBoxTask_CMV.Multiline = true;
			textBoxTask_CMV.Name = "textBoxTask_CMV";
			textBoxTask_CMV.ReadOnly = true;
			textBoxTask_CMV.Size = new Size(803, 78);
			textBoxTask_CMV.TabIndex = 0;
			textBoxTask_CMV.TabStop = false;
			textBoxTask_CMV.Text = resources.GetString("textBoxTask_CMV.Text");
			// 
			// groupBoxInput_CMV
			// 
			groupBoxInput_CMV.Controls.Add(dataGridViewIn_CMV);
			groupBoxInput_CMV.Dock = DockStyle.Fill;
			groupBoxInput_CMV.Location = new Point(0, 0);
			groupBoxInput_CMV.Name = "groupBoxInput_CMV";
			groupBoxInput_CMV.Size = new Size(388, 371);
			groupBoxInput_CMV.TabIndex = 0;
			groupBoxInput_CMV.TabStop = false;
			groupBoxInput_CMV.Text = "Ввод:";
			// 
			// dataGridViewIn_CMV
			// 
			dataGridViewIn_CMV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewIn_CMV.ColumnHeadersVisible = false;
			dataGridViewIn_CMV.Dock = DockStyle.Fill;
			dataGridViewIn_CMV.Location = new Point(3, 19);
			dataGridViewIn_CMV.Name = "dataGridViewIn_CMV";
			dataGridViewIn_CMV.RowHeadersVisible = false;
			dataGridViewIn_CMV.Size = new Size(382, 349);
			dataGridViewIn_CMV.TabIndex = 0;
			// 
			// groupBoxOutput_CMV
			// 
			groupBoxOutput_CMV.Controls.Add(dataGridViewOut_CMV);
			groupBoxOutput_CMV.Dock = DockStyle.Fill;
			groupBoxOutput_CMV.Location = new Point(0, 0);
			groupBoxOutput_CMV.Name = "groupBoxOutput_CMV";
			groupBoxOutput_CMV.Size = new Size(417, 371);
			groupBoxOutput_CMV.TabIndex = 0;
			groupBoxOutput_CMV.TabStop = false;
			groupBoxOutput_CMV.Text = "Вывод:";
			// 
			// dataGridViewOut_CMV
			// 
			dataGridViewOut_CMV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewOut_CMV.ColumnHeadersVisible = false;
			dataGridViewOut_CMV.Dock = DockStyle.Fill;
			dataGridViewOut_CMV.Location = new Point(3, 19);
			dataGridViewOut_CMV.Name = "dataGridViewOut_CMV";
			dataGridViewOut_CMV.RowHeadersVisible = false;
			dataGridViewOut_CMV.Size = new Size(411, 349);
			dataGridViewOut_CMV.TabIndex = 0;
			// 
			// openFileDialogTask
			// 
			openFileDialogTask.FileName = "openFileDialogTask";
			// 
			// toolTipTask
			// 
			toolTipTask.IsBalloon = true;
			toolTipTask.ToolTipIcon = ToolTipIcon.Info;
			toolTipTask.ToolTipTitle = "Подсказка";
			// 
			// panelPredTop_CMV
			// 
			panelPredTop_CMV.Controls.Add(groupBoxTask_CMV);
			panelPredTop_CMV.Dock = DockStyle.Top;
			panelPredTop_CMV.Location = new Point(0, 88);
			panelPredTop_CMV.Name = "panelPredTop_CMV";
			panelPredTop_CMV.Size = new Size(809, 100);
			panelPredTop_CMV.TabIndex = 4;
			// 
			// splitContainer_CMV
			// 
			splitContainer_CMV.Dock = DockStyle.Fill;
			splitContainer_CMV.Location = new Point(0, 188);
			splitContainer_CMV.Name = "splitContainer_CMV";
			// 
			// splitContainer_CMV.Panel1
			// 
			splitContainer_CMV.Panel1.Controls.Add(groupBoxInput_CMV);
			// 
			// splitContainer_CMV.Panel2
			// 
			splitContainer_CMV.Panel2.Controls.Add(groupBoxOutput_CMV);
			splitContainer_CMV.Size = new Size(809, 371);
			splitContainer_CMV.SplitterDistance = 388;
			splitContainer_CMV.TabIndex = 5;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(809, 559);
			Controls.Add(splitContainer_CMV);
			Controls.Add(panelPredTop_CMV);
			Controls.Add(panelTop_CMV);
			MinimumSize = new Size(825, 598);
			Name = "FormMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Спринт 6 | Таск 7 | Вариант 24 | Чигуров М. В. ";
			WindowState = FormWindowState.Maximized;
			Load += FormMain_Load;
			panelTop_CMV.ResumeLayout(false);
			groupBoxTask_CMV.ResumeLayout(false);
			groupBoxTask_CMV.PerformLayout();
			groupBoxInput_CMV.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewIn_CMV).EndInit();
			groupBoxOutput_CMV.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewOut_CMV).EndInit();
			panelPredTop_CMV.ResumeLayout(false);
			splitContainer_CMV.Panel1.ResumeLayout(false);
			splitContainer_CMV.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer_CMV).EndInit();
			splitContainer_CMV.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panelTop_CMV;
		private Button buttonDone_CMV;
		private Button buttonOpenFile_CMV;
		private Button buttonHelp_CMV;
		private GroupBox groupBoxTask_CMV;
		private TextBox textBoxTask_CMV;
		private GroupBox groupBoxOutput_CMV;
		private GroupBox groupBoxInput_CMV;
		private ToolTip toolTipTask;
		private OpenFileDialog openFileDialogTask;
		private Panel panelPredTop_CMV;
		private SplitContainer splitContainer_CMV;
		private Button buttonSaveFile_CMV;
		private SaveFileDialog saveFileDialogMatrix;
		private DataGridView dataGridViewIn_CMV;
		private DataGridView dataGridViewOut_CMV;
	}
}
