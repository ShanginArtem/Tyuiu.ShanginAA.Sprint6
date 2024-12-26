namespace Tyuiu.ShanginAA.Sprint6.Task7.V28
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
            panelButtons_SAA = new Panel();
            groupBoxCondition_SAA = new GroupBox();
            labelCondition_SAA = new Label();
            panelTask_SAA = new Panel();
            buttonInfo_SAA = new Button();
            buttonSaveFile_SAA = new Button();
            buttonDone_SAA = new Button();
            buttonOpenFile_SAA = new Button();
            panelOutPut_SAA = new Panel();
            groupBoxOutPut_SAA = new GroupBox();
            dataGridViewOut_SAA = new DataGridView();
            panelInPut_SAA = new Panel();
            groupBoxInPut_SAA = new GroupBox();
            dataGridViewIn_SAA = new DataGridView();
            openFileDialog_SAA = new OpenFileDialog();
            saveFileDialogMatrix_SAA = new SaveFileDialog();
            toolTipButton_SAA = new ToolTip(components);
            label1 = new Label();
            panelButtons_SAA.SuspendLayout();
            groupBoxCondition_SAA.SuspendLayout();
            panelTask_SAA.SuspendLayout();
            panelOutPut_SAA.SuspendLayout();
            groupBoxOutPut_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_SAA).BeginInit();
            panelInPut_SAA.SuspendLayout();
            groupBoxInPut_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_SAA).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_SAA
            // 
            panelButtons_SAA.Controls.Add(groupBoxCondition_SAA);
            panelButtons_SAA.Controls.Add(panelTask_SAA);
            panelButtons_SAA.Dock = DockStyle.Top;
            panelButtons_SAA.Location = new Point(0, 0);
            panelButtons_SAA.Margin = new Padding(3, 4, 3, 4);
            panelButtons_SAA.Name = "panelButtons_SAA";
            panelButtons_SAA.Size = new Size(1340, 315);
            panelButtons_SAA.TabIndex = 0;
            // 
            // groupBoxCondition_SAA
            // 
            groupBoxCondition_SAA.Controls.Add(label1);
            groupBoxCondition_SAA.Controls.Add(labelCondition_SAA);
            groupBoxCondition_SAA.Dock = DockStyle.Top;
            groupBoxCondition_SAA.Location = new Point(0, 172);
            groupBoxCondition_SAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxCondition_SAA.Name = "groupBoxCondition_SAA";
            groupBoxCondition_SAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxCondition_SAA.Size = new Size(1340, 132);
            groupBoxCondition_SAA.TabIndex = 1;
            groupBoxCondition_SAA.TabStop = false;
            groupBoxCondition_SAA.Text = "Условие: ";
            groupBoxCondition_SAA.Enter += groupBoxCondition_SAA_Enter;
            // 
            // labelCondition_SAA
            // 
            labelCondition_SAA.AutoSize = true;
            labelCondition_SAA.Dock = DockStyle.Fill;
            labelCondition_SAA.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCondition_SAA.Location = new Point(3, 24);
            labelCondition_SAA.Name = "labelCondition_SAA";
            labelCondition_SAA.Size = new Size(0, 23);
            labelCondition_SAA.TabIndex = 0;
            // 
            // panelTask_SAA
            // 
            panelTask_SAA.Controls.Add(buttonInfo_SAA);
            panelTask_SAA.Controls.Add(buttonSaveFile_SAA);
            panelTask_SAA.Controls.Add(buttonDone_SAA);
            panelTask_SAA.Controls.Add(buttonOpenFile_SAA);
            panelTask_SAA.Dock = DockStyle.Top;
            panelTask_SAA.Location = new Point(0, 0);
            panelTask_SAA.Margin = new Padding(3, 4, 3, 4);
            panelTask_SAA.Name = "panelTask_SAA";
            panelTask_SAA.Size = new Size(1340, 172);
            panelTask_SAA.TabIndex = 0;
            // 
            // buttonInfo_SAA
            // 
            buttonInfo_SAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_SAA.Location = new Point(1215, 41);
            buttonInfo_SAA.Margin = new Padding(3, 4, 3, 4);
            buttonInfo_SAA.Name = "buttonInfo_SAA";
            buttonInfo_SAA.Size = new Size(115, 104);
            buttonInfo_SAA.TabIndex = 3;
            buttonInfo_SAA.Text = "Справка";
            buttonInfo_SAA.UseVisualStyleBackColor = true;
            buttonInfo_SAA.Click += buttonInfo_SAA_Click;
            // 
            // buttonSaveFile_SAA
            // 
            buttonSaveFile_SAA.Enabled = false;
            buttonSaveFile_SAA.Location = new Point(289, 41);
            buttonSaveFile_SAA.Margin = new Padding(3, 4, 3, 4);
            buttonSaveFile_SAA.Name = "buttonSaveFile_SAA";
            buttonSaveFile_SAA.Size = new Size(124, 104);
            buttonSaveFile_SAA.TabIndex = 2;
            buttonSaveFile_SAA.Text = "Скопировать";
            toolTipButton_SAA.SetToolTip(buttonSaveFile_SAA, " Сохранить результат в файл OutPutFileTask7.csv через saveFileDialog.\r\n\r\n\r\n");
            buttonSaveFile_SAA.UseVisualStyleBackColor = true;
            buttonSaveFile_SAA.Click += buttonSaveFile_SAA_Click;
            // 
            // buttonDone_SAA
            // 
            buttonDone_SAA.Anchor = AnchorStyles.Left;
            buttonDone_SAA.Enabled = false;
            buttonDone_SAA.Location = new Point(156, 41);
            buttonDone_SAA.Margin = new Padding(3, 4, 3, 4);
            buttonDone_SAA.Name = "buttonDone_SAA";
            buttonDone_SAA.Size = new Size(111, 104);
            buttonDone_SAA.TabIndex = 1;
            buttonDone_SAA.Text = "Отправить";
            toolTipButton_SAA.SetToolTip(buttonDone_SAA, "Изменить в седьмой строке числа не равные 13 на 0. Результат вывести в объект dataGridViewOut.");
            buttonDone_SAA.UseVisualStyleBackColor = true;
            buttonDone_SAA.Click += buttonDone_SAA_Click;
            // 
            // buttonOpenFile_SAA
            // 
            buttonOpenFile_SAA.Location = new Point(29, 41);
            buttonOpenFile_SAA.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFile_SAA.Name = "buttonOpenFile_SAA";
            buttonOpenFile_SAA.Size = new Size(107, 104);
            buttonOpenFile_SAA.TabIndex = 0;
            buttonOpenFile_SAA.Text = "Загрузить";
            toolTipButton_SAA.SetToolTip(buttonOpenFile_SAA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_SAA.UseVisualStyleBackColor = true;
            buttonOpenFile_SAA.Click += buttonOpenFile_SAA_Click;
            // 
            // panelOutPut_SAA
            // 
            panelOutPut_SAA.Controls.Add(groupBoxOutPut_SAA);
            panelOutPut_SAA.Dock = DockStyle.Fill;
            panelOutPut_SAA.Location = new Point(677, 315);
            panelOutPut_SAA.Margin = new Padding(3, 4, 3, 4);
            panelOutPut_SAA.Name = "panelOutPut_SAA";
            panelOutPut_SAA.Size = new Size(663, 670);
            panelOutPut_SAA.TabIndex = 2;
            panelOutPut_SAA.Paint += panelOutPut_SAA_Paint;
            // 
            // groupBoxOutPut_SAA
            // 
            groupBoxOutPut_SAA.Controls.Add(dataGridViewOut_SAA);
            groupBoxOutPut_SAA.Dock = DockStyle.Fill;
            groupBoxOutPut_SAA.Location = new Point(0, 0);
            groupBoxOutPut_SAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutPut_SAA.Name = "groupBoxOutPut_SAA";
            groupBoxOutPut_SAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutPut_SAA.Size = new Size(663, 670);
            groupBoxOutPut_SAA.TabIndex = 0;
            groupBoxOutPut_SAA.TabStop = false;
            groupBoxOutPut_SAA.Text = "Вывод:";
            // 
            // dataGridViewOut_SAA
            // 
            dataGridViewOut_SAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_SAA.Dock = DockStyle.Fill;
            dataGridViewOut_SAA.Location = new Point(3, 24);
            dataGridViewOut_SAA.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOut_SAA.Name = "dataGridViewOut_SAA";
            dataGridViewOut_SAA.RowHeadersVisible = false;
            dataGridViewOut_SAA.RowHeadersWidth = 51;
            dataGridViewOut_SAA.RowTemplate.Height = 24;
            dataGridViewOut_SAA.Size = new Size(657, 642);
            dataGridViewOut_SAA.TabIndex = 0;
            // 
            // panelInPut_SAA
            // 
            // ...
            // Здесь должен быть оставшийся код для panelInPut_SAA
            // 
            // panelInPut_SAA
            // 
            // 
            // panelInPut_SAA
            // 
            panelInPut_SAA.Controls.Add(groupBoxInPut_SAA);
            panelInPut_SAA.Dock = DockStyle.Left;
            panelInPut_SAA.Location = new Point(0, 315);
            panelInPut_SAA.Margin = new Padding(3, 4, 3, 4);
            panelInPut_SAA.Name = "panelInPut_SAA";
            panelInPut_SAA.Size = new Size(677, 670);
            panelInPut_SAA.TabIndex = 3;
            // 
            // groupBoxInPut_SAA
            // 
            groupBoxInPut_SAA.Controls.Add(dataGridViewIn_SAA);
            groupBoxInPut_SAA.Dock = DockStyle.Fill;
            groupBoxInPut_SAA.Location = new Point(0, 0);
            groupBoxInPut_SAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxInPut_SAA.Name = "groupBoxInPut_SAA";
            groupBoxInPut_SAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxInPut_SAA.Size = new Size(677, 670);
            groupBoxInPut_SAA.TabIndex = 0;
            groupBoxInPut_SAA.TabStop = false;
            groupBoxInPut_SAA.Text = "Ввод:";
            // 
            // dataGridViewIn_SAA
            // 
            dataGridViewIn_SAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_SAA.Dock = DockStyle.Fill;
            dataGridViewIn_SAA.Location = new Point(3, 24);
            dataGridViewIn_SAA.Margin = new Padding(3, 4, 3, 4);
            dataGridViewIn_SAA.Name = "dataGridViewIn_SAA";
            dataGridViewIn_SAA.RowHeadersVisible = false;
            dataGridViewIn_SAA.RowHeadersWidth = 51;
            dataGridViewIn_SAA.RowTemplate.Height = 24;
            dataGridViewIn_SAA.Size = new Size(671, 642);
            dataGridViewIn_SAA.TabIndex = 0;
            // 
            // openFileDialog_SAA
            // 
            openFileDialog_SAA.FileName = "openFileDialog1";
            openFileDialog_SAA.FileOk += openFileDialog_SAA_FileOk;
            // 
            // toolTipButton_SAA
            // 
            toolTipButton_SAA.IsBalloon = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 24);
            label1.Name = "label1";
            label1.Size = new Size(1176, 40);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 985);
            Controls.Add(panelOutPut_SAA);
            Controls.Add(panelInPut_SAA);
            Controls.Add(panelButtons_SAA);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 28 | Шангин А.А. ";
            panelButtons_SAA.ResumeLayout(false);
            groupBoxCondition_SAA.ResumeLayout(false);
            groupBoxCondition_SAA.PerformLayout();
            panelTask_SAA.ResumeLayout(false);
            panelOutPut_SAA.ResumeLayout(false);
            groupBoxOutPut_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_SAA).EndInit();
            panelInPut_SAA.ResumeLayout(false);
            groupBoxInPut_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_SAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_SAA;
        private System.Windows.Forms.GroupBox groupBoxCondition_SAA;
        private System.Windows.Forms.Label labelCondition_SAA;
        private System.Windows.Forms.Panel panelTask_SAA;
        private System.Windows.Forms.Panel panelOutPut_SAA;
        private System.Windows.Forms.Panel panelInPut_SAA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAA;
        private System.Windows.Forms.DataGridView dataGridViewOut_SAA;
        private System.Windows.Forms.GroupBox groupBoxInPut_SAA;
        private System.Windows.Forms.DataGridView dataGridViewIn_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.Button buttonOpenFile_SAA;
        private System.Windows.Forms.Button buttonInfo_SAA;
        private System.Windows.Forms.Button buttonSaveFile_SAA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_SAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SAA;
        private System.Windows.Forms.ToolTip toolTipButton_SAA;
        private Label label1;
    }
}
