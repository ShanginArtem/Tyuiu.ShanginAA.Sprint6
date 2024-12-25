using Tyuiu.ShanginAA.Sprint6.Task4.V2.Lib;

namespace Tyuiu.ShanginAA.Sprint6.Task4.V2
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_SAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_SAA.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_SAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SAA.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_SAA.Text = "";
                chartFunction_SAA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_SAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_SAA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 4 Выполнил студент ИСПб-24-1 Шангин Артём Александрович", "Сообщение");
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V2.txt";
                File.WriteAllText(path, textBoxResult_SAA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно!\n Открыть его в блокноте ? ", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



    }
}