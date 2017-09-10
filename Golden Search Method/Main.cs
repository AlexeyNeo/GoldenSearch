using System;
using System.Windows.Forms;
using info.lundin.math;
using System.Diagnostics;

namespace GoldenSearchMethod
{
 
    public partial class Main : Form
    {
        Form newMDIChild = new GoldenSearchMethod.iteration();//дочернее окно
        public ExpressionParser parser = new ExpressionParser();
        public Main()
        {
            InitializeComponent();
            frm2 = new iteration();
        }
        iteration frm2;
        public String[] it = new String[100];
        public int k = 0;
        public int time = 0;
        public string fx;

        private void Form1_Load(object sender, EventArgs e)
        {//настройки прогресс бара
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;     
        }
        private int v()// проверка на пустоту
        {
            double tol = double.Parse(tolBox.Text);
                
            if (aBox.Text == "" || bBox.Text=="")
            {
                MessageBox.Show("Вы не указали диапазон поиска.");
                return 0;
            }
            if (comboBoxf.Text == "")
            {
                MessageBox.Show("Поле не 'F' не может быть пустым, выберите элемент из списка или напишите вручную формулу.");
                return 0;
            }
           if (  tol < 1e-28 )
            {
                MessageBox.Show("Программа не может расчитать с введенной точностью.");
                return 0;
            }
            if (tolBox.Text == "")
            {
                MessageBox.Show("Укажите точность вычисления.");
                return 0;
            }
            if (k_maxBox.Text == "")
            {
                MessageBox.Show("Введите кол-во итераций.");
                return 0;
            }
            if (maxRadio.Checked == false && MinRatio.Checked==false)
            {
                MessageBox.Show("Необходимо выбрать поиск минимума или максимума функции.");
                return 0;
            }
            return 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fx = comboBoxf.Text;
            if (v() == 0)
            { }
            else
            {
                progressBar1.Visible = true;
                timer1.Start();
                Decimal a = Decimal.Parse(aBox.Text);
                Decimal b = Decimal.Parse(bBox.Text);
                double tol = parser.Parse(tolBox.Text);
                int k_max = int.Parse(k_maxBox.Text);
                GoldenSM obj = new GoldenSM();// объект класса

                if (maxRadio.Checked == true)
                {
                    Stopwatch stopWatch = new Stopwatch();

                    stopWatch.Start();
                    ////данные для входного интерфейса.
                    it = obj.GoldenIterationMax(a, a, b, tol, k_max, fx);//метод вычисления
                    stopWatch.Stop();

                    TimeSpan ts = stopWatch.Elapsed;
                    ms.Text = String.Format("{0,000}", ts.TotalMilliseconds);
                  
                }
                else
                { 
                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();
                    it = obj.GoldenIterationMin(a, a, b, tol, k_max, fx);//алгоритм golden search
                    TimeSpan ts = stopWatch.Elapsed;
                    ms.Text = String.Format("{0,000}", ts.TotalMilliseconds);
                }
                //данные для выходного интерфейса.
                countinerBox.Text = "" + obj.k_iner();//выводим кол-во итераций
                k = obj.k_iner();
                x1uotFBox.Text = "" + obj.x1out();//выводим х1
                fx1outBox.Text = "" + obj.fx1out();//Fx1
                outTolBox.Text = "" + obj.absab().ToString("0e0");
                iterationButton.Enabled = true;
            }
        }       
        private void str(string[] it)
        {
            throw new NotImplementedException();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            iterationButton.Enabled = false;
           
            for (int i = 0; i < k; i++)//заполняю окно записями 
            {
                frm2.richTextBox1.Text += it[i];
            }
            frm2.ShowDialog();//вызываю 
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //сброс полей вывода
            countinerBox.Text = "";
            x1uotFBox.Text = "";
            fx1outBox.Text = "";
            outTolBox.Text = "";
            progressBar1.Value = 0;
            timer1.Stop();
            progressBar1.Visible = false;
            iterationButton.Enabled = false;
            ms.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Increment(+20);  
            else
            {
                time++;
                if (time == 6)
                {
                    timer1.Stop();
                    progressBar1.Visible = false;
                    time = 0;
                    progressBar1.Value = 0;
                }
            }
            
        }

        private void countinerBox_TextChanged(object sender, EventArgs e)
        {

        }
        /* Ниже происходит обработка входного интерфейса      */

        private void aBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;// перевод в ASCII
            if (!Char.IsDigit(number) && number != 8 && number != 45 && number != 43 && number != 44 && number != 101) // если нет в условии, то не выводим символ на экран
                {
                    e.Handled = true;
                }
        }

        private void bBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;// перевод в ASCII
            if (!Char.IsDigit(number) && number != 8 && number != 45 && number != 43 && number != 44 && number != 101) // если нет в условии, то не выводим символ на экран
            {
                e.Handled = true;
            }
        }

        private void tolBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;// перевод в ASCII
            if (!Char.IsDigit(number) && number != 8 && number != 45 && number != 43 && number != 44 && number != 101) // если нет в условии, то не выводим символ на экран
            {
                e.Handled = true;
            }
        }

        private void k_maxBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;// перевод в ASCII
            if (!Char.IsDigit(number) && number != 8) // если нет в условии, то не выводим символ на экран
            {
                e.Handled = true;
            }
        }

        private void fBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
