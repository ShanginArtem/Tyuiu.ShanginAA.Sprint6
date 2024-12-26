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
            buttonDone_SAA = new Button();
            dataGridViewResult_SAA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            textBoxStartStep_SAA = new TextBox();
            textBoxStopStep_SAA = new TextBox();
            labelStartStep_SAA = new Label();
            labelStopStep_SAA = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_SAA
            // 
            buttonDone_SAA.Location = new Point(12, 59);
            buttonDone_SAA.Name = "buttonDone_SAA";
            buttonDone_SAA.Size = new Size(87, 67);
            buttonDone_SAA.TabIndex = 0;
            buttonDone_SAA.Text = "run";
            buttonDone_SAA.UseVisualStyleBackColor = true;
            buttonDone_SAA.Click += buttonDone_SAA_Click;
            // 
            // dataGridViewResult_SAA
            // 
            dataGridViewResult_SAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_SAA.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewResult_SAA.Location = new Point(222, 12);
            dataGridViewResult_SAA.Name = "dataGridViewResult_SAA";
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
            labelStartStep_SAA.Size = new Size(31, 15);
            labelStartStep_SAA.TabIndex = 4;
            labelStartStep_SAA.Text = "Start";
            // 
            // labelStopStep_SAA
            // 
            labelStopStep_SAA.AutoSize = true;
            labelStopStep_SAA.Location = new Point(116, 12);
            labelStopStep_SAA.Name = "labelStopStep_SAA";
            labelStopStep_SAA.Size = new Size(31, 15);
            labelStopStep_SAA.TabIndex = 5;
            labelStopStep_SAA.Text = "Stop";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 450);
            Controls.Add(labelStopStep_SAA);
            Controls.Add(labelStartStep_SAA);
            Controls.Add(textBoxStopStep_SAA);
            Controls.Add(textBoxStartStep_SAA);
            Controls.Add(dataGridViewResult_SAA);
            Controls.Add(buttonDone_SAA);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
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
    }
}
