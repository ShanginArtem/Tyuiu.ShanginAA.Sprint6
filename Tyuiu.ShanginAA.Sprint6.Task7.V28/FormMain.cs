using System.ComponentModel;
using Tyuiu.ShanginAA.Sprint6.Task7.V28.Lib;

namespace Tyuiu.ShanginAA.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_SAA.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SAA.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;

        static string openFilePath;
        DataService ds = new DataService();

        public int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;


        }

        private void groupBoxCondition_SAA_Enter(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panelOutPut_SAA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOpenFile_SAA_Click(object sender, EventArgs e)
        {
            openFileDialog_SAA.ShowDialog();
            openFilePath = openFileDialog_SAA.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewIn_SAA.ColumnCount = columns;
            dataGridViewIn_SAA.RowCount = rows;
            dataGridViewOut_SAA.ColumnCount = columns;
            dataGridViewOut_SAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_SAA.Columns[i].Width = 25;
                dataGridViewOut_SAA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_SAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_SAA.Enabled = true;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_SAA.ColumnCount = 50;
            dataGridViewOut_SAA.ColumnCount = 50;

            dataGridViewIn_SAA.RowCount = 50;
            dataGridViewOut_SAA.RowCount = 50;

            panelInPut_SAA.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_SAA.Columns[i].Width = 25;
                dataGridViewOut_SAA.Columns[i].Width = 25;
            }
        }



        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_SAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_SAA.Enabled = true;
        }

        private void buttonSaveFile_SAA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SAA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SAA.ShowDialog();

            string path = saveFileDialogMatrix_SAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_SAA.RowCount;
            int columns = dataGridViewOut_SAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_SAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_SAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void openFileDialog_SAA_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonInfo_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 7 Выполнил студент ИСПб-24-1 Шангин Артём Александрович", "Сообщение");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
