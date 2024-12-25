using Tyuiu.ShanginAA.Sprint6.Task0.V4.Lib;

namespace Tyuiu.ShanginAA.Sprint6.Task0.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBox2.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBox1.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 0 Выполнил студент ИСПб-24-1 Шангин Артём Александрович", "Сообщение");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
