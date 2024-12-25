namespace Tyuiu.ShanginAA.Sprint6.Task0.V4
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
            groupBoxCondition_SAA = new GroupBox();
            button2_SAA = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            groupBox4 = new GroupBox();
            textBox2 = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBoxTask_SAA = new GroupBox();
            groupBoxCondition_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_SAA
            // 
            groupBoxCondition_SAA.Controls.Add(button2_SAA);
            groupBoxCondition_SAA.Controls.Add(button1);
            groupBoxCondition_SAA.Controls.Add(pictureBox1);
            groupBoxCondition_SAA.Controls.Add(groupBox4);
            groupBoxCondition_SAA.Controls.Add(groupBox3);
            groupBoxCondition_SAA.Controls.Add(groupBoxTask_SAA);
            groupBoxCondition_SAA.Location = new Point(0, 0);
            groupBoxCondition_SAA.Name = "groupBoxCondition_SAA";
            groupBoxCondition_SAA.Size = new Size(799, 449);
            groupBoxCondition_SAA.TabIndex = 0;
            groupBoxCondition_SAA.TabStop = false;
            groupBoxCondition_SAA.Text = "Условие";
            // 
            // button2_SAA
            // 
            button2_SAA.Location = new Point(623, 399);
            button2_SAA.Name = "button2_SAA";
            button2_SAA.Size = new Size(40, 42);
            button2_SAA.TabIndex = 2;
            button2_SAA.Text = "?";
            button2_SAA.UseVisualStyleBackColor = true;
            button2_SAA.Click += button2_SAA_Click;
            // 
            // button1
            // 
            button1.Location = new Point(669, 416);
            button1.Name = "button1";
            button1.Size = new Size(106, 27);
            button1.TabIndex = 1;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.t1;
            pictureBox1.Location = new Point(510, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(label2);
            groupBox4.Location = new Point(510, 225);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(265, 168);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Вывод данных";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 97);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Результат";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Location = new Point(6, 225);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(498, 168);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 97);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 4;
            label1.Text = "Переменная Х: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.KeyPress += textBox1_KeyPress;
            //textBox1.TextChanged += textBox1_TextChanged_KeyPress;
            // 
            // groupBoxTask_SAA
            // 
            groupBoxTask_SAA.Location = new Point(6, 22);
            groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            groupBoxTask_SAA.Size = new Size(498, 157);
            groupBoxTask_SAA.TabIndex = 0;
            groupBoxTask_SAA.TabStop = false;
            groupBoxTask_SAA.Text = "Вычислить выражение по формуле";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxCondition_SAA);
            Name = "FormMain";
            Text = "Form1";
            groupBoxCondition_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_SAA;
        private GroupBox groupBoxTask_SAA;
        private Button button2_SAA;
        private Button button1;
        private PictureBox pictureBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
    }
}
