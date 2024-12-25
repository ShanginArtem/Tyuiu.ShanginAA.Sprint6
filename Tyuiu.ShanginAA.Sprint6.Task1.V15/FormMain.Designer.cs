namespace Tyuiu.ShanginAA.Sprint6.Task1.V15
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
            groupBoxTask_SAA = new GroupBox();
            TextBoxCondition_SAA = new TextBox();
            GroupBoxInput_SAA = new GroupBox();
            TextBoxStopStep_SAA = new TextBox();
            TextBoxStartStep_SAA = new TextBox();
            TextBoxStopStepInput_SAA = new TextBox();
            TextBoxStartStepInput_SAA = new TextBox();
            GroupBoxOutput_SAA = new GroupBox();
            TextBoxOutputResult_SAA = new TextBox();
            TextBoxResult_SAA = new TextBox();
            ButtonHelp_SAA = new Button();
            ButtonLaunch_SAA = new Button();
            groupBoxTask_SAA.SuspendLayout();
            GroupBoxInput_SAA.SuspendLayout();
            GroupBoxOutput_SAA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SAA
            // 
            groupBoxTask_SAA.Controls.Add(TextBoxCondition_SAA);
            groupBoxTask_SAA.FlatStyle = FlatStyle.Flat;
            groupBoxTask_SAA.Location = new Point(12, 12);
            groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            groupBoxTask_SAA.Size = new Size(517, 343);
            groupBoxTask_SAA.TabIndex = 0;
            groupBoxTask_SAA.TabStop = false;
            groupBoxTask_SAA.Text = "Условие:";
            groupBoxTask_SAA.Enter += groupBox1_Enter;
            // 
            // TextBoxCondition_SAA
            // 
            TextBoxCondition_SAA.BackColor = SystemColors.Menu;
            TextBoxCondition_SAA.BorderStyle = BorderStyle.None;
            TextBoxCondition_SAA.Font = new Font("Segoe UI", 15F);
            TextBoxCondition_SAA.Location = new Point(18, 22);
            TextBoxCondition_SAA.Multiline = true;
            TextBoxCondition_SAA.Name = "TextBoxCondition_SAA";
            TextBoxCondition_SAA.ReadOnly = true;
            TextBoxCondition_SAA.Size = new Size(493, 246);
            TextBoxCondition_SAA.TabIndex = 0;
            TextBoxCondition_SAA.Text = resources.GetString("TextBoxCondition_SAA.Text");
            TextBoxCondition_SAA.TextChanged += TextBoxCondition_SAA_TextChanged;
            // 
            // GroupBoxInput_SAA
            // 
            GroupBoxInput_SAA.Controls.Add(TextBoxStopStep_SAA);
            GroupBoxInput_SAA.Controls.Add(TextBoxStartStep_SAA);
            GroupBoxInput_SAA.Controls.Add(TextBoxStopStepInput_SAA);
            GroupBoxInput_SAA.Controls.Add(TextBoxStartStepInput_SAA);
            GroupBoxInput_SAA.Location = new Point(12, 361);
            GroupBoxInput_SAA.Name = "GroupBoxInput_SAA";
            GroupBoxInput_SAA.Size = new Size(270, 77);
            GroupBoxInput_SAA.TabIndex = 1;
            GroupBoxInput_SAA.TabStop = false;
            GroupBoxInput_SAA.Text = "Ввод данных:";
            // 
            // TextBoxStopStep_SAA
            // 
            TextBoxStopStep_SAA.BackColor = SystemColors.ButtonFace;
            TextBoxStopStep_SAA.BorderStyle = BorderStyle.None;
            TextBoxStopStep_SAA.Location = new Point(141, 22);
            TextBoxStopStep_SAA.Name = "TextBoxStopStep_SAA";
            TextBoxStopStep_SAA.ReadOnly = true;
            TextBoxStopStep_SAA.Size = new Size(100, 16);
            TextBoxStopStep_SAA.TabIndex = 5;
            TextBoxStopStep_SAA.Text = "Конец шага:";
            // 
            // TextBoxStartStep_SAA
            // 
            TextBoxStartStep_SAA.BackColor = SystemColors.ButtonFace;
            TextBoxStartStep_SAA.BorderStyle = BorderStyle.None;
            TextBoxStartStep_SAA.Location = new Point(18, 22);
            TextBoxStartStep_SAA.Name = "TextBoxStartStep_SAA";
            TextBoxStartStep_SAA.ReadOnly = true;
            TextBoxStartStep_SAA.Size = new Size(100, 16);
            TextBoxStartStep_SAA.TabIndex = 4;
            TextBoxStartStep_SAA.Text = "Старт шага:";
            // 
            // TextBoxStopStepInput_SAA
            // 
            TextBoxStopStepInput_SAA.Location = new Point(141, 44);
            TextBoxStopStepInput_SAA.Name = "TextBoxStopStepInput_SAA";
            TextBoxStopStepInput_SAA.Size = new Size(117, 23);
            TextBoxStopStepInput_SAA.TabIndex = 3;
            // 
            // TextBoxStartStepInput_SAA
            // 
            TextBoxStartStepInput_SAA.Location = new Point(18, 44);
            TextBoxStartStepInput_SAA.Name = "TextBoxStartStepInput_SAA";
            TextBoxStartStepInput_SAA.Size = new Size(117, 23);
            TextBoxStartStepInput_SAA.TabIndex = 2;
            TextBoxStartStepInput_SAA.TextChanged += textBox1_TextChanged;
            // 
            // GroupBoxOutput_SAA
            // 
            GroupBoxOutput_SAA.Controls.Add(TextBoxOutputResult_SAA);
            GroupBoxOutput_SAA.Controls.Add(TextBoxResult_SAA);
            GroupBoxOutput_SAA.Location = new Point(554, 12);
            GroupBoxOutput_SAA.Name = "GroupBoxOutput_SAA";
            GroupBoxOutput_SAA.Size = new Size(234, 426);
            GroupBoxOutput_SAA.TabIndex = 2;
            GroupBoxOutput_SAA.TabStop = false;
            GroupBoxOutput_SAA.Text = "Вывод данных:";
            GroupBoxOutput_SAA.Enter += groupBox1_Enter_1;
            // 
            // TextBoxOutputResult_SAA
            // 
            TextBoxOutputResult_SAA.BackColor = SystemColors.ButtonFace;
            TextBoxOutputResult_SAA.BorderStyle = BorderStyle.None;
            TextBoxOutputResult_SAA.Location = new Point(6, 44);
            TextBoxOutputResult_SAA.Multiline = true;
            TextBoxOutputResult_SAA.Name = "TextBoxOutputResult_SAA";
            TextBoxOutputResult_SAA.ReadOnly = true;
            TextBoxOutputResult_SAA.ScrollBars = ScrollBars.Vertical;
            TextBoxOutputResult_SAA.Size = new Size(222, 372);
            TextBoxOutputResult_SAA.TabIndex = 6;
            TextBoxOutputResult_SAA.TextChanged += TextBoxOutputResult_SAA_TextChanged;
            // 
            // TextBoxResult_SAA
            // 
            TextBoxResult_SAA.BackColor = SystemColors.ButtonFace;
            TextBoxResult_SAA.BorderStyle = BorderStyle.None;
            TextBoxResult_SAA.Location = new Point(6, 22);
            TextBoxResult_SAA.Name = "TextBoxResult_SAA";
            TextBoxResult_SAA.ReadOnly = true;
            TextBoxResult_SAA.Size = new Size(100, 16);
            TextBoxResult_SAA.TabIndex = 5;
            TextBoxResult_SAA.Text = "Результат: ";
            // 
            // ButtonHelp_SAA
            // 
            ButtonHelp_SAA.BackColor = Color.RoyalBlue;
            ButtonHelp_SAA.FlatStyle = FlatStyle.Flat;
            ButtonHelp_SAA.Location = new Point(304, 376);
            ButtonHelp_SAA.Name = "ButtonHelp_SAA";
            ButtonHelp_SAA.Size = new Size(110, 52);
            ButtonHelp_SAA.TabIndex = 0;
            ButtonHelp_SAA.Text = "Справка";
            ButtonHelp_SAA.UseVisualStyleBackColor = false;
            ButtonHelp_SAA.Click += TextBoxCondition_SAA_TextChanged;
            // 
            // ButtonLaunch_SAA
            // 
            ButtonLaunch_SAA.BackColor = Color.SeaGreen;
            ButtonLaunch_SAA.FlatStyle = FlatStyle.Flat;
            ButtonLaunch_SAA.Location = new Point(420, 376);
            ButtonLaunch_SAA.Name = "ButtonLaunch_SAA";
            ButtonLaunch_SAA.Size = new Size(110, 52);
            ButtonLaunch_SAA.TabIndex = 1;
            ButtonLaunch_SAA.Text = "Выполнить";
            ButtonLaunch_SAA.UseVisualStyleBackColor = false;
            ButtonLaunch_SAA.Click += ButtonLaunch_SAA_Click;
            // 
            // FormMain_SAA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonLaunch_SAA);
            Controls.Add(ButtonHelp_SAA);
            Controls.Add(GroupBoxOutput_SAA);
            Controls.Add(GroupBoxInput_SAA);
            Controls.Add(groupBoxTask_SAA);
            Name = "FormMain_SAA";
            Text = "Спринт 6 | Таск 1 | Вариант 15 | Шангин А.А.";
            groupBoxTask_SAA.ResumeLayout(false);
            groupBoxTask_SAA.PerformLayout();
            GroupBoxInput_SAA.ResumeLayout(false);
            GroupBoxInput_SAA.PerformLayout();
            GroupBoxOutput_SAA.ResumeLayout(false);
            GroupBoxOutput_SAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SAA;
        private TextBox TextBoxCondition_SAA;
        private GroupBox GroupBoxInput_SAA;
        private GroupBox GroupBoxOutput_SAA;
        private Button ButtonHelp_SAA;
        private TextBox TextBoxStartStep_SAA;
        private TextBox TextBoxStopStepInput_SAA;
        private TextBox TextBoxStartStepInput_SAA;
        private Button ButtonLaunch_SAA;
        private TextBox TextBoxStopStep_SAA;
        private TextBox TextBoxOutputResult_SAA;
        private TextBox TextBoxResult_SAA;
    }
}