using Tyuiu.ShanginAA.Sprint6.Task5.V12.Lib;

namespace Tyuiu.ShanginAA.Sprint6.Task5.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\msi\source\repos\Tyuiu.ShanginAA.Sprint6\Tyuiu.ShanginAA.Sprint6.Task5.V12\bin\Debug\InPutDataFileTask5V12.txt";



        private void buttonOK_Click(object sender, EventArgs e)
        {
            dataGridViewResult.ColumnCount = 2;
            dataGridViewResult.Columns[0].Width = 20;
            dataGridViewResult.Columns[1].Width = 50;

            this.chartFunction.ChartAreas[0].AxisX.Title = "��� X";
            this.chartFunction.ChartAreas[0].AxisY.Title = "��� Y";

            chartFunction.Series[0].Points.Clear();


            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction.Series[0].Points.AddXY(i, numsMass[i]);
            }



        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 5 �������� ������� ����-24-1 ������ ���� �������������", "���������");
        }
    }
}
