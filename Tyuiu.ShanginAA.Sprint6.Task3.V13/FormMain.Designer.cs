namespace Tyuiu.ShanginAA.Sprint6.Task3.V13
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
            groupBoxCon_SAA = new GroupBox();
            textBoxCon_SAA = new TextBox();
            dataGridViewMatrix_SAA = new DataGridView();
            groupBoxResult_SAA = new GroupBox();
            dataGridViewRes_SAA = new DataGridView();
            buttonHelp_SAA = new Button();
            buttonDone_SAA = new Button();
            groupBoxCon_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_SAA).BeginInit();
            groupBoxResult_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_SAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCon_SAA
            // 
            groupBoxCon_SAA.Controls.Add(dataGridViewMatrix_SAA);
            groupBoxCon_SAA.Controls.Add(textBoxCon_SAA);
            groupBoxCon_SAA.Location = new Point(12, 4);
            groupBoxCon_SAA.Name = "groupBoxCon_SAA";
            groupBoxCon_SAA.Size = new Size(374, 293);
            groupBoxCon_SAA.TabIndex = 0;
            groupBoxCon_SAA.TabStop = false;
            groupBoxCon_SAA.Text = "Условие";
            // 
            // textBoxCon_SAA
            // 
            textBoxCon_SAA.BackColor = SystemColors.ButtonFace;
            textBoxCon_SAA.Location = new Point(6, 22);
            textBoxCon_SAA.Multiline = true;
            textBoxCon_SAA.Name = "textBoxCon_SAA";
            textBoxCon_SAA.Size = new Size(198, 265);
            textBoxCon_SAA.TabIndex = 0;
            textBoxCon_SAA.Text = "Дана матрица 5 на 5\r\n-7     34  -2    25  5\r\n-16 -12   30  -3   17\r\n  3  -15    30  -3   17\r\n 17   22  -3    32 -11\r\n  9    28   1    -9  -2\r\nВыполнить сортировку по возрастанию во втором столбце.\r\n";
            // 
            // dataGridViewMatrix_SAA
            // 
            dataGridViewMatrix_SAA.BackgroundColor = SystemColors.Info;
            dataGridViewMatrix_SAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_SAA.Location = new Point(210, 22);
            dataGridViewMatrix_SAA.Name = "dataGridViewMatrix_SAA";
            dataGridViewMatrix_SAA.Size = new Size(158, 150);
            dataGridViewMatrix_SAA.TabIndex = 1;
            // 
            // groupBoxResult_SAA
            // 
            groupBoxResult_SAA.Controls.Add(dataGridViewRes_SAA);
            groupBoxResult_SAA.Location = new Point(395, 4);
            groupBoxResult_SAA.Name = "groupBoxResult_SAA";
            groupBoxResult_SAA.Size = new Size(174, 205);
            groupBoxResult_SAA.TabIndex = 1;
            groupBoxResult_SAA.TabStop = false;
            groupBoxResult_SAA.Text = "Вывод";
            // 
            // dataGridViewRes_SAA
            // 
            dataGridViewRes_SAA.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewRes_SAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_SAA.Location = new Point(6, 22);
            dataGridViewRes_SAA.Name = "dataGridViewRes_SAA";
            dataGridViewRes_SAA.Size = new Size(162, 150);
            dataGridViewRes_SAA.TabIndex = 0;
            // 
            // buttonHelp_SAA
            // 
            buttonHelp_SAA.Location = new Point(419, 274);
            buttonHelp_SAA.Name = "buttonHelp_SAA";
            buttonHelp_SAA.Size = new Size(48, 23);
            buttonHelp_SAA.TabIndex = 2;
            buttonHelp_SAA.Text = "?";
            buttonHelp_SAA.UseVisualStyleBackColor = true;
            buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            // 
            // buttonDone_SAA
            // 
            buttonDone_SAA.Location = new Point(473, 274);
            buttonDone_SAA.Name = "buttonDone_SAA";
            buttonDone_SAA.Size = new Size(90, 23);
            buttonDone_SAA.TabIndex = 3;
            buttonDone_SAA.Text = "Выполнить";
            buttonDone_SAA.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 309);
            Controls.Add(buttonDone_SAA);
            Controls.Add(buttonHelp_SAA);
            Controls.Add(groupBoxResult_SAA);
            Controls.Add(groupBoxCon_SAA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 13 | Шангин А.А. ";
            groupBoxCon_SAA.ResumeLayout(false);
            groupBoxCon_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_SAA).EndInit();
            groupBoxResult_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_SAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCon_SAA;
        private DataGridView dataGridViewMatrix_SAA;
        private TextBox textBoxCon_SAA;
        private GroupBox groupBoxResult_SAA;
        private DataGridView dataGridViewRes_SAA;
        private Button buttonHelp_SAA;
        private Button buttonDone_SAA;
    }
}
