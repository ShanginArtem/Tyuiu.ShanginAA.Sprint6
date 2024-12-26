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
            DataService ds = new DataService();
            int startStep = Convert.ToInt32(textBoxStartStep_SAA.Text);
            int stopStep = Convert.ToInt32(textBoxStopStep_SAA.Text);

            int len = ds.GetMassFunction(startStep, stopStep).Length;
            double[] valueArray = new double[len];

            valueArray = ds.GetMassFunction(startStep, stopStep);

            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridViewResult_SAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                startStep++;
            }
        }
    }
}
