namespace Tyuiu.ChigurovMV.Sprint6.Task0.V22
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			groupBoxСondition = new GroupBox();
			textBoxTask = new TextBox();
			pictureBoxFormula = new PictureBox();
			groupBoxInput = new GroupBox();
			labelVarX = new Label();
			textBoxVarX = new TextBox();
			groupBoxOutput = new GroupBox();
			labelResult = new Label();
			textBoxResult = new TextBox();
			buttonDone = new Button();
			buttonHelp = new Button();
			groupBoxСondition.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
			groupBoxInput.SuspendLayout();
			groupBoxOutput.SuspendLayout();
			SuspendLayout();
			// 
			// groupBoxСondition
			// 
			groupBoxСondition.Controls.Add(textBoxTask);
			groupBoxСondition.Controls.Add(pictureBoxFormula);
			groupBoxСondition.Location = new Point(12, 12);
			groupBoxСondition.Name = "groupBoxСondition";
			groupBoxСondition.Size = new Size(445, 174);
			groupBoxСondition.TabIndex = 0;
			groupBoxСondition.TabStop = false;
			groupBoxСondition.Tag = "";
			groupBoxСondition.Text = "Условие";
			// 
			// textBoxTask
			// 
			textBoxTask.BorderStyle = BorderStyle.None;
			textBoxTask.Location = new Point(6, 22);
			textBoxTask.Multiline = true;
			textBoxTask.Name = "textBoxTask";
			textBoxTask.ReadOnly = true;
			textBoxTask.Size = new Size(217, 145);
			textBoxTask.TabIndex = 0;
			textBoxTask.TabStop = false;
			textBoxTask.Text = "Вычислить выражение по формуле";
			// 
			// pictureBoxFormula
			// 
			pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
			pictureBoxFormula.Location = new Point(244, 22);
			pictureBoxFormula.Name = "pictureBoxFormula";
			pictureBoxFormula.Size = new Size(192, 36);
			pictureBoxFormula.TabIndex = 1;
			pictureBoxFormula.TabStop = false;
			// 
			// groupBoxInput
			// 
			groupBoxInput.Controls.Add(labelVarX);
			groupBoxInput.Controls.Add(textBoxVarX);
			groupBoxInput.Location = new Point(16, 211);
			groupBoxInput.Name = "groupBoxInput";
			groupBoxInput.Size = new Size(195, 101);
			groupBoxInput.TabIndex = 2;
			groupBoxInput.TabStop = false;
			groupBoxInput.Text = "Ввод данных";
			// 
			// labelVarX
			// 
			labelVarX.AutoSize = true;
			labelVarX.Location = new Point(6, 51);
			labelVarX.Name = "labelVarX";
			labelVarX.Size = new Size(89, 15);
			labelVarX.TabIndex = 6;
			labelVarX.Text = "Переменная X:";
			// 
			// textBoxVarX
			// 
			textBoxVarX.Location = new Point(6, 72);
			textBoxVarX.Name = "textBoxVarX";
			textBoxVarX.Size = new Size(126, 23);
			textBoxVarX.TabIndex = 0;
			textBoxVarX.KeyPress += textBoxVarX_KeyPress;
			// 
			// groupBoxOutput
			// 
			groupBoxOutput.Controls.Add(labelResult);
			groupBoxOutput.Controls.Add(textBoxResult);
			groupBoxOutput.Location = new Point(256, 211);
			groupBoxOutput.Name = "groupBoxOutput";
			groupBoxOutput.Size = new Size(192, 101);
			groupBoxOutput.TabIndex = 3;
			groupBoxOutput.TabStop = false;
			groupBoxOutput.Text = "Вывод данных";
			// 
			// labelResult
			// 
			labelResult.AutoSize = true;
			labelResult.Location = new Point(6, 51);
			labelResult.Name = "labelResult";
			labelResult.Size = new Size(63, 15);
			labelResult.TabIndex = 8;
			labelResult.Text = "Результат:";
			// 
			// textBoxResult
			// 
			textBoxResult.Location = new Point(6, 72);
			textBoxResult.Name = "textBoxResult";
			textBoxResult.ReadOnly = true;
			textBoxResult.Size = new Size(180, 23);
			textBoxResult.TabIndex = 7;
			// 
			// buttonDone
			// 
			buttonDone.Location = new Point(318, 332);
			buttonDone.Name = "buttonDone";
			buttonDone.Size = new Size(130, 28);
			buttonDone.TabIndex = 4;
			buttonDone.Text = "Выполнить";
			buttonDone.UseVisualStyleBackColor = true;
			buttonDone.Click += buttonDone_Click;
			// 
			// buttonHelp
			// 
			buttonHelp.Location = new Point(284, 332);
			buttonHelp.Name = "buttonHelp";
			buttonHelp.Size = new Size(28, 28);
			buttonHelp.TabIndex = 5;
			buttonHelp.Text = "?";
			buttonHelp.UseVisualStyleBackColor = true;
			buttonHelp.Click += buttonHelp_Click;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(460, 383);
			Controls.Add(buttonHelp);
			Controls.Add(buttonDone);
			Controls.Add(groupBoxOutput);
			Controls.Add(groupBoxInput);
			Controls.Add(groupBoxСondition);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "FormMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Спринт 6 | Таск 0 | Вариант 22 | Чигуров М. В. ";
			groupBoxСondition.ResumeLayout(false);
			groupBoxСondition.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
			groupBoxInput.ResumeLayout(false);
			groupBoxInput.PerformLayout();
			groupBoxOutput.ResumeLayout(false);
			groupBoxOutput.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBoxСondition;
		private PictureBox pictureBoxFormula;
		private GroupBox groupBoxInput;
		private GroupBox groupBoxOutput;
		private Button buttonDone;
		private TextBox textBoxTask;
		private TextBox textBoxVarX;
		private Label labelVarX;
		private Label labelResult;
		private TextBox textBoxResult;
		private Button buttonHelp;
	}
}
