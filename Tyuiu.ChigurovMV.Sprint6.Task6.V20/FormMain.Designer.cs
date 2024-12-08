namespace Tyuiu.ChigurovMV.Sprint6.Task6.V20
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
			buttonDone_CMV = new Button();
			buttonOpenFile_CMV = new Button();
			buttonHelp_CMV = new Button();
			groupBoxTask_CMV = new GroupBox();
			textBoxTask_CMV = new TextBox();
			groupBoxInput_CMV = new GroupBox();
			textBoxInput_CMV = new TextBox();
			groupBoxOutput_CMV = new GroupBox();
			textBoxOutput_CMV = new TextBox();
			openFileDialogTask = new OpenFileDialog();
			toolTipTask = new ToolTip(components);
			panelPredTop_CMV = new Panel();
			splitContainer_CMV = new SplitContainer();
			panelTop_CMV.SuspendLayout();
			groupBoxTask_CMV.SuspendLayout();
			groupBoxInput_CMV.SuspendLayout();
			groupBoxOutput_CMV.SuspendLayout();
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
			panelTop_CMV.Controls.Add(buttonDone_CMV);
			panelTop_CMV.Controls.Add(buttonOpenFile_CMV);
			panelTop_CMV.Controls.Add(buttonHelp_CMV);
			panelTop_CMV.Dock = DockStyle.Top;
			panelTop_CMV.Location = new Point(0, 0);
			panelTop_CMV.Name = "panelTop_CMV";
			panelTop_CMV.Size = new Size(809, 88);
			panelTop_CMV.TabIndex = 3;
			// 
			// buttonDone_CMV
			// 
			buttonDone_CMV.BackColor = Color.White;
			buttonDone_CMV.BackgroundImage = (Image)resources.GetObject("buttonDone_CMV.BackgroundImage");
			buttonDone_CMV.BackgroundImageLayout = ImageLayout.Zoom;
			buttonDone_CMV.Cursor = Cursors.Hand;
			buttonDone_CMV.Enabled = false;
			buttonDone_CMV.Location = new Point(89, 12);
			buttonDone_CMV.Name = "buttonDone_CMV";
			buttonDone_CMV.Size = new Size(66, 65);
			buttonDone_CMV.TabIndex = 4;
			toolTipTask.SetToolTip(buttonDone_CMV, "Произвести обработку файла");
			buttonDone_CMV.UseVisualStyleBackColor = false;
			buttonDone_CMV.Click += buttonDone_Click;
			// 
			// buttonOpenFile_CMV
			// 
			buttonOpenFile_CMV.BackColor = Color.White;
			buttonOpenFile_CMV.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_CMV.BackgroundImage");
			buttonOpenFile_CMV.BackgroundImageLayout = ImageLayout.Zoom;
			buttonOpenFile_CMV.Cursor = Cursors.Hand;
			buttonOpenFile_CMV.Location = new Point(17, 12);
			buttonOpenFile_CMV.Name = "buttonOpenFile_CMV";
			buttonOpenFile_CMV.Size = new Size(66, 65);
			buttonOpenFile_CMV.TabIndex = 5;
			buttonOpenFile_CMV.Text = "\r\n";
			toolTipTask.SetToolTip(buttonOpenFile_CMV, "Открыть файл\r\nВыберите нужный файл для обработки.\r\n");
			buttonOpenFile_CMV.UseVisualStyleBackColor = false;
			buttonOpenFile_CMV.Click += buttonOpenFile_Click;
			// 
			// buttonHelp_CMV
			// 
			buttonHelp_CMV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			buttonHelp_CMV.BackColor = Color.White;
			buttonHelp_CMV.BackgroundImage = (Image)resources.GetObject("buttonHelp_CMV.BackgroundImage");
			buttonHelp_CMV.BackgroundImageLayout = ImageLayout.Zoom;
			buttonHelp_CMV.Cursor = Cursors.Hand;
			buttonHelp_CMV.Location = new Point(729, 12);
			buttonHelp_CMV.Name = "buttonHelp_CMV";
			buttonHelp_CMV.Size = new Size(68, 65);
			buttonHelp_CMV.TabIndex = 6;
			buttonHelp_CMV.UseVisualStyleBackColor = false;
			buttonHelp_CMV.Click += buttonHelp_Click;
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
			groupBoxInput_CMV.Controls.Add(textBoxInput_CMV);
			groupBoxInput_CMV.Dock = DockStyle.Fill;
			groupBoxInput_CMV.Location = new Point(0, 0);
			groupBoxInput_CMV.Name = "groupBoxInput_CMV";
			groupBoxInput_CMV.Size = new Size(269, 371);
			groupBoxInput_CMV.TabIndex = 0;
			groupBoxInput_CMV.TabStop = false;
			groupBoxInput_CMV.Text = "Ввод:";
			// 
			// textBoxInput_CMV
			// 
			textBoxInput_CMV.Dock = DockStyle.Fill;
			textBoxInput_CMV.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBoxInput_CMV.Location = new Point(3, 19);
			textBoxInput_CMV.Multiline = true;
			textBoxInput_CMV.Name = "textBoxInput_CMV";
			textBoxInput_CMV.ReadOnly = true;
			textBoxInput_CMV.Size = new Size(263, 349);
			textBoxInput_CMV.TabIndex = 0;
			// 
			// groupBoxOutput_CMV
			// 
			groupBoxOutput_CMV.Controls.Add(textBoxOutput_CMV);
			groupBoxOutput_CMV.Dock = DockStyle.Fill;
			groupBoxOutput_CMV.Location = new Point(0, 0);
			groupBoxOutput_CMV.Name = "groupBoxOutput_CMV";
			groupBoxOutput_CMV.Size = new Size(536, 371);
			groupBoxOutput_CMV.TabIndex = 0;
			groupBoxOutput_CMV.TabStop = false;
			groupBoxOutput_CMV.Text = "Вывод:";
			// 
			// textBoxOutput_CMV
			// 
			textBoxOutput_CMV.Dock = DockStyle.Fill;
			textBoxOutput_CMV.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBoxOutput_CMV.Location = new Point(3, 19);
			textBoxOutput_CMV.Multiline = true;
			textBoxOutput_CMV.Name = "textBoxOutput_CMV";
			textBoxOutput_CMV.ReadOnly = true;
			textBoxOutput_CMV.Size = new Size(530, 349);
			textBoxOutput_CMV.TabIndex = 0;
			// 
			// openFileDialogTask
			// 
			openFileDialogTask.FileName = "openFileDialogTask";
			// 
			// toolTipTask
			// 
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
			splitContainer_CMV.SplitterDistance = 269;
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
			Text = "Form1";
			Load += FormMain_Load;
			panelTop_CMV.ResumeLayout(false);
			groupBoxTask_CMV.ResumeLayout(false);
			groupBoxTask_CMV.PerformLayout();
			groupBoxInput_CMV.ResumeLayout(false);
			groupBoxInput_CMV.PerformLayout();
			groupBoxOutput_CMV.ResumeLayout(false);
			groupBoxOutput_CMV.PerformLayout();
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
		private TextBox textBoxInput_CMV;
		private TextBox textBoxOutput_CMV;
		private Panel panelPredTop_CMV;
		private SplitContainer splitContainer_CMV;
	}
}
