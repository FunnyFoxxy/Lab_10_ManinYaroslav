using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataWrem
{
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox1.Cut();
            textBox1.Text = "Сегодня";
            textBox1.Text += " ";
            //DateTimelocalDate = DateTime.Now;
            DateTime thisDay = DateTime.Today;
            textBox1.Text += thisDay.ToString() + " "; //06.11.2015 0:00:00
            textBox1.Text += thisDay.ToString("d") + " "; //06.11.2015
            textBox1.Text += thisDay.ToString("D") + " "; //07.11.2015 13:13:51
            textBox1.Text += thisDay.ToString("g") + " ";
            //время
            string currentTime = DateTime.Now.TimeOfDay.ToString();
            textBox1.Text += currentTime + " ";
            //по умолчанию результат 01.01.0001 0:00:00
            var someTime = new DateTime();
            textBox1.Text += someTime + " ";
            //системнаядатаивремя 06.11.2015 15:26:55
            textBox1.Text += DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime sDay = DateTime.Now;
            DateTime zDay = sDay.AddDays(1);
            richTextBox1.Text = "pppp ";
            richTextBox1.Text += "завтра " + zDay;
            zDay = sDay.AddDays(7);
            richTextBox1.Text += " через неделю " + zDay;
            // толькодата
            DateTime tDay = DateTime.Today;
            richTextBox1.Text += " только дата " + tDay.ToString("d");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime nowDate = DateTime.Today;
            DateTime dt = Convert.ToDateTime(textBox2.Text);
            int age = nowDate.Year - dt.Year;
            richTextBox1.Text = Convert.ToString(age) + " лет";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime sDay = DateTime.Today;
            label1.Text = "День " + sDay.Day; //hijriDate.Day
            label2.Text = "Месяц " + sDay.Month; //int month = moment.Month;
            label3.Text = "Год " + sDay.Year; //date1.Year
            label4.Text = Convert.ToString(sDay.DayOfWeek);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox1.Cut();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = ""; label2.Text = ""; label3.Text = ""; label4.Text = "";
        }
    }
}