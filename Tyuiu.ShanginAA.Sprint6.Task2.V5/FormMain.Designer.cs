namespace Tyuiu.ShanginAA.Sprint6.Task2.V5
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
            buttonDone_SAA = new Button();
            dataGridViewResult_SAA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            textBoxStartStep_SAA = new TextBox();
            textBoxStopStep_SAA = new TextBox();
            labelStartStep_SAA = new Label();
            labelStopStep_SAA = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonAbout_SAA = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_SAA
            // 
            buttonDone_SAA.Location = new Point(12, 59);
            buttonDone_SAA.Name = "buttonDone_SAA";
            buttonDone_SAA.Size = new Size(87, 67);
            buttonDone_SAA.TabIndex = 0;
            buttonDone_SAA.Text = "Запустить";
            buttonDone_SAA.UseVisualStyleBackColor = true;
            buttonDone_SAA.Click += buttonDone_SAA_Click;
            // 
            // dataGridViewResult_SAA
            // 
            dataGridViewResult_SAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_SAA.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewResult_SAA.Location = new Point(222, 12);
            dataGridViewResult_SAA.Name = "dataGridViewResult_SAA";
            dataGridViewResult_SAA.RowHeadersVisible = false;
            dataGridViewResult_SAA.Size = new Size(145, 426);
            dataGridViewResult_SAA.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // textBoxStartStep_SAA
            // 
            textBoxStartStep_SAA.Location = new Point(12, 30);
            textBoxStartStep_SAA.Name = "textBoxStartStep_SAA";
            textBoxStartStep_SAA.Size = new Size(100, 23);
            textBoxStartStep_SAA.TabIndex = 2;
            // 
            // textBoxStopStep_SAA
            // 
            textBoxStopStep_SAA.Location = new Point(116, 30);
            textBoxStopStep_SAA.Name = "textBoxStopStep_SAA";
            textBoxStopStep_SAA.Size = new Size(100, 23);
            textBoxStopStep_SAA.TabIndex = 3;
            // 
            // labelStartStep_SAA
            // 
            labelStartStep_SAA.AutoSize = true;
            labelStartStep_SAA.Location = new Point(10, 12);
            labelStartStep_SAA.Name = "labelStartStep_SAA";
            labelStartStep_SAA.Size = new Size(68, 15);
            labelStartStep_SAA.TabIndex = 4;
            labelStartStep_SAA.Text = "Начальное";
            // 
            // labelStopStep_SAA
            // 
            labelStopStep_SAA.AutoSize = true;
            labelStopStep_SAA.Location = new Point(116, 12);
            labelStopStep_SAA.Name = "labelStopStep_SAA";
            labelStopStep_SAA.Size = new Size(61, 15);
            labelStopStep_SAA.TabIndex = 5;
            labelStopStep_SAA.Text = "Конечное";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(400, 12);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(387, 426);
            chart1.TabIndex = 6;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // buttonAbout_SAA
            // 
            buttonAbout_SAA.Location = new Point(10, 388);
            buttonAbout_SAA.Name = "buttonAbout_SAA";
            buttonAbout_SAA.Size = new Size(47, 50);
            buttonAbout_SAA.TabIndex = 7;
            buttonAbout_SAA.Text = "?";
            buttonAbout_SAA.UseVisualStyleBackColor = true;
            buttonAbout_SAA.Click += buttonAbout_SAA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 450);
            Controls.Add(buttonAbout_SAA);
            Controls.Add(chart1);
            Controls.Add(labelStopStep_SAA);
            Controls.Add(labelStartStep_SAA);
            Controls.Add(textBoxStopStep_SAA);
            Controls.Add(textBoxStartStep_SAA);
            Controls.Add(dataGridViewResult_SAA);
            Controls.Add(buttonDone_SAA);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_SAA;
        private DataGridView dataGridViewResult_SAA;
        private TextBox textBoxStartStep_SAA;
        private TextBox textBoxStopStep_SAA;
        private Label labelStartStep_SAA;
        private Label labelStopStep_SAA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private FileSystemWatcher fileSystemWatcher1;
        private Button buttonAbout_SAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
