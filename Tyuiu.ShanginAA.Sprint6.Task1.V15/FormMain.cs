using Tyuiu.ShanginAA.Sprint6.Task1.V15.Lib;

namespace Tyuiu.ShanginAA.Sprint6.Task1.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBoxCondition_SAA_TextChanged

            (object sender, EventArgs e)
        {
            MessageBox.Show("Task 1 Выполнил студент ИСПб-24-1 Шангин Артём Александрович", "Сообщение");
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxOutputResult_SAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonLaunch_SAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(TextBoxStartStepInput_SAA.Text);
                int stopStep = Convert.ToInt32(TextBoxStopStepInput_SAA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                TextBoxOutputResult_SAA.Text = "";
                TextBoxOutputResult_SAA.AppendText("+------+------+" + Environment.NewLine);
                TextBoxOutputResult_SAA.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                TextBoxOutputResult_SAA.AppendText("+------+------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}    |", startStep, valueArray[i]);
                    TextBoxOutputResult_SAA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                TextBoxOutputResult_SAA.AppendText("+------+------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}