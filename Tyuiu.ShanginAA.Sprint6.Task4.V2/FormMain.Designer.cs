namespace Tyuiu.ShanginAA.Sprint6.Task4.V2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition_SAA = new GroupBox();
            textBoxCondition_SAA = new TextBox();
            groupBoxEnter_SAA = new GroupBox();
            label2 = new Label();
            labelStartStep_SAA = new Label();
            textBoxStopStep_SAA = new TextBox();
            textBoxStartStep_SAA = new TextBox();
            groupBoxResult_SAA = new GroupBox();
            textBoxResult_SAA = new TextBox();
            chartFunction_SAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonStart_SAA = new Button();
            buttonSave_SAA = new Button();
            buttonHelp_SAA = new Button();
            groupBoxCondition_SAA.SuspendLayout();
            groupBoxEnter_SAA.SuspendLayout();
            groupBoxResult_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_SAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_SAA
            // 
            groupBoxCondition_SAA.Controls.Add(textBoxCondition_SAA);
            groupBoxCondition_SAA.Location = new Point(12, 12);
            groupBoxCondition_SAA.Name = "groupBoxCondition_SAA";
            groupBoxCondition_SAA.Size = new Size(442, 95);
            groupBoxCondition_SAA.TabIndex = 0;
            groupBoxCondition_SAA.TabStop = false;
            groupBoxCondition_SAA.Text = "Условие:";
            // 
            // textBoxCondition_SAA
            // 
            textBoxCondition_SAA.Font = new Font("Segoe UI", 6F);
            textBoxCondition_SAA.Location = new Point(6, 24);
            textBoxCondition_SAA.Multiline = true;
            textBoxCondition_SAA.Name = "textBoxCondition_SAA";
            textBoxCondition_SAA.ReadOnly = true;
            textBoxCondition_SAA.Size = new Size(430, 65);
            textBoxCondition_SAA.TabIndex = 0;
            textBoxCondition_SAA.Text = "Протабулировать функцию на диапазоне от -5 до 5\r\nРезультат вывести в textBox, построить график функции и сохранить в файл\r\nOutPutFileTask4V2.txt";
            // 
            // groupBoxEnter_SAA
            // 
            groupBoxEnter_SAA.Controls.Add(label2);
            groupBoxEnter_SAA.Controls.Add(labelStartStep_SAA);
            groupBoxEnter_SAA.Controls.Add(textBoxStopStep_SAA);
            groupBoxEnter_SAA.Controls.Add(textBoxStartStep_SAA);
            groupBoxEnter_SAA.Location = new Point(460, 12);
            groupBoxEnter_SAA.Name = "groupBoxEnter_SAA";
            groupBoxEnter_SAA.Size = new Size(294, 95);
            groupBoxEnter_SAA.TabIndex = 1;
            groupBoxEnter_SAA.TabStop = false;
            groupBoxEnter_SAA.Text = "Ввод данных:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F);
            label2.Location = new Point(154, 24);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 2;
            label2.Text = "Конец шага:";
            // 
            // labelStartStep_SAA
            // 
            labelStartStep_SAA.AutoSize = true;
            labelStartStep_SAA.Font = new Font("Segoe UI", 7F);
            labelStartStep_SAA.Location = new Point(6, 24);
            labelStartStep_SAA.Name = "labelStartStep_SAA";
            labelStartStep_SAA.Size = new Size(82, 19);
            labelStartStep_SAA.TabIndex = 0;
            labelStartStep_SAA.Text = "Старт шага:";
            // 
            // textBoxStopStep_SAA
            // 
            textBoxStopStep_SAA.Location = new Point(154, 47);
            textBoxStopStep_SAA.Name = "textBoxStopStep_SAA";
            textBoxStopStep_SAA.Size = new Size(134, 31);
            textBoxStopStep_SAA.TabIndex = 1;
            // 
            // textBoxStartStep_SAA
            // 
            textBoxStartStep_SAA.Location = new Point(6, 47);
            textBoxStartStep_SAA.Name = "textBoxStartStep_SAA";
            textBoxStartStep_SAA.Size = new Size(134, 31);
            textBoxStartStep_SAA.TabIndex = 0;
            // 
            // groupBoxResult_SAA
            // 
            groupBoxResult_SAA.Controls.Add(textBoxResult_SAA);
            groupBoxResult_SAA.Location = new Point(12, 113);
            groupBoxResult_SAA.Name = "groupBoxResult_SAA";
            groupBoxResult_SAA.Size = new Size(300, 468);
            groupBoxResult_SAA.TabIndex = 2;
            groupBoxResult_SAA.TabStop = false;
            groupBoxResult_SAA.Text = "Вывод:";
            // 
            // textBoxResult_SAA
            // 
            textBoxResult_SAA.Location = new Point(6, 30);
            textBoxResult_SAA.Multiline = true;
            textBoxResult_SAA.Name = "textBoxResult_SAA";
            textBoxResult_SAA.ReadOnly = true;
            textBoxResult_SAA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SAA.Size = new Size(288, 432);
            textBoxResult_SAA.TabIndex = 0;
            // 
            // chartFunction_SAA
            // 
            chartArea3.Name = "ChartArea1";
            chartFunction_SAA.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            chartFunction_SAA.Legends.Add(legend3);
            chartFunction_SAA.Location = new Point(329, 113);
            chartFunction_SAA.Name = "chartFunction_SAA";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartFunction_SAA.Series.Add(series3);
            chartFunction_SAA.Size = new Size(890, 468);
            chartFunction_SAA.TabIndex = 3;
            chartFunction_SAA.Text = "chart1";
            // 
            // buttonStart_SAA
            // 
            buttonStart_SAA.BackColor = Color.ForestGreen;
            buttonStart_SAA.Location = new Point(760, 22);
            buttonStart_SAA.Name = "buttonStart_SAA";
            buttonStart_SAA.Size = new Size(112, 79);
            buttonStart_SAA.TabIndex = 4;
            buttonStart_SAA.Text = "Выполнить";
            buttonStart_SAA.UseVisualStyleBackColor = false;
            buttonStart_SAA.Click += buttonStart_Click;
            // 
            // buttonSave_SAA
            // 
            buttonSave_SAA.BackColor = Color.RoyalBlue;
            buttonSave_SAA.Location = new Point(878, 22);
            buttonSave_SAA.Name = "buttonSave_SAA";
            buttonSave_SAA.Size = new Size(112, 79);
            buttonSave_SAA.TabIndex = 5;
            buttonSave_SAA.Text = "Сохранить";
            buttonSave_SAA.UseVisualStyleBackColor = false;
            buttonSave_SAA.Click += buttonSave_Click;
            // 
            // buttonHelp_SAA
            // 
            buttonHelp_SAA.BackColor = Color.CornflowerBlue;
            buttonHelp_SAA.Location = new Point(1107, 22);
            buttonHelp_SAA.Name = "buttonHelp_SAA";
            buttonHelp_SAA.Size = new Size(112, 79);
            buttonHelp_SAA.TabIndex = 6;
            buttonHelp_SAA.Text = "Справка";
            buttonHelp_SAA.UseVisualStyleBackColor = false;
            buttonHelp_SAA.Click += buttonHelp_Click;
            // 
            // FormMain_SAA
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 593);
            Controls.Add(buttonHelp_SAA);
            Controls.Add(buttonSave_SAA);
            Controls.Add(buttonStart_SAA);
            Controls.Add(chartFunction_SAA);
            Controls.Add(groupBoxResult_SAA);
            Controls.Add(groupBoxEnter_SAA);
            Controls.Add(groupBoxCondition_SAA);
            Name = "FormMain_SAA";
            Text = "Спринт 6 | Таск 4 | Вариант 2 | Шангин А.А. ";
            Load += Form1_Load;
            groupBoxCondition_SAA.ResumeLayout(false);
            groupBoxCondition_SAA.PerformLayout();
            groupBoxEnter_SAA.ResumeLayout(false);
            groupBoxEnter_SAA.PerformLayout();
            groupBoxResult_SAA.ResumeLayout(false);
            groupBoxResult_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_SAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_SAA;
        private GroupBox groupBoxEnter_SAA;
        private TextBox textBoxCondition_SAA;
        private GroupBox groupBoxResult_SAA;
        private TextBox textBoxResult_SAA;
        private Label label2;
        private Label labelStartStep_SAA;
        private TextBox textBoxStopStep_SAA;
        private TextBox textBoxStartStep_SAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SAA;
        private Button buttonStart_SAA;
        private Button buttonSave_SAA;
        private Button buttonHelp_SAA;
    }
}
