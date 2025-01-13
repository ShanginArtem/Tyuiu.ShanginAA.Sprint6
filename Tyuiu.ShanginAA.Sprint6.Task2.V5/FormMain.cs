using Tyuiu.ShanginAA.Sprint6.Task2.V5.Lib;

namespace Tyuiu.ShanginAA.Sprint6.Task2.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            try
            {

                DataService ds = new DataService();
                int startStep = Convert.ToInt32(textBoxStartStep_SAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_SAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_SAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chart1.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAbout_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 2 Выполнил студент ИСПб-24-1 Шангин Артём Александрович", "Сообщение");
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
