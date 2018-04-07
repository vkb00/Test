using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace КурсоваяC_шарп__v1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] num= new string[10];
        string[] temp_ch_true = new string[10];
        

        int[]  temp_in_true = new int[10];
       

        public void Num()
        {
            num[0] = "quest1.txt";
            num[1] = "quest2.txt";
            num[2] = "quest3.txt";
            num[3] = "quest4.txt";
            num[4] = "quest5.txt";
            num[5] = "quest6.txt";
            num[6] = "quest7.txt";
            num[7] = "quest8.txt";
            num[8] = "quest9.txt";
            num[9] = "quest10.txt";
        }
        public void Temp()
        {
            temp_ch_true[0] = "D";
            temp_ch_true[1] = "A";
            temp_ch_true[2] = "A";
            temp_ch_true[3] = "B";
            temp_ch_true[4] = "B";
            temp_ch_true[5] = "C";
            temp_ch_true[6] = "A";
            temp_ch_true[7] = "B";
            temp_ch_true[8] = "A";
            temp_ch_true[9] = "D";

            

            for (int i=0; i < 10; i++)
            {
                temp_in_true[i] = i;
               
            }
        }

        int d=1;
        int t = 0;
        int h=0;//переменная положительных ответов
        int g = 0;//переменная отрецательных ответов
        int[] rand = new int[10] {0,0,0,0,0,0,0,0,0,0};
        Random r = new Random();
        string[] tempch = new string[10];
        int[] tempin = new int[10];
        
            

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Visible = true;
            button1.Text = "Следующий!";
           
            if (t==0)
            label2.Visible = true;

            Num();
            Temp();
            if (t == 5)
            {
                tempin[t - 1] = rand[t - 1];
                tempch[t - 1] = textBox1.Text;
                
            }
            if (d<6)
            {

                

                rand[t] = r.Next(10);

                if (t==0)//условия чтобы рандом не повторялся
                {
                   
                    FileStream MainFile = new FileStream(num[rand[t]], FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamReader reader = new StreamReader(MainFile, Encoding.Default);
                    label1.Text = reader.ReadToEnd();
                    reader.Close();
                    

                }
                if(t==1)
                {
                    while (rand[t] == rand[t - 1]) 
                      rand[t] = r.Next(10);

                    
                    FileStream MainFile = new FileStream(num[rand[t]], FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamReader reader = new StreamReader(MainFile, Encoding.Default);
                    label1.Text = reader.ReadToEnd();
                    reader.Close();

                    tempin[t-1] = rand[t-1];
                    tempch[t - 1] = textBox1.Text;
                    
                    


                }
                if (t == 2)
                {
                    while (rand[t] == rand[t - 1] || rand[t] == rand[t - 2])
                        rand[t] = r.Next(10);

                  
                    FileStream MainFile = new FileStream(num[rand[t]], FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamReader reader = new StreamReader(MainFile, Encoding.Default);
                    label1.Text = reader.ReadToEnd();
                    reader.Close();

                    tempin[t - 1] = rand[t - 1];
                    tempch[t - 1] = textBox1.Text;
                    
                }
                if (t == 3)
                {
                    while (rand[t] == rand[t - 1] || rand[t] == rand[t - 2] || rand[t] == rand[t - 3])
                        rand[t] = r.Next(10);

                   
                    FileStream MainFile = new FileStream(num[rand[t]], FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamReader reader = new StreamReader(MainFile, Encoding.Default);
                    label1.Text = reader.ReadToEnd();
                    reader.Close();

                    tempin[t - 1] = rand[t - 1];
                    tempch[t - 1] = textBox1.Text;
                    
                }
                if (t == 4)
                {
                    while (rand[t] == rand[t - 1] || rand[t] == rand[t - 2] || rand[t] == rand[t - 3] || rand[t] == rand[t - 4])
                        rand[t] = r.Next(10);

                    
                    FileStream MainFile = new FileStream(num[rand[t]], FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamReader reader = new StreamReader(MainFile, Encoding.Default);
                    label1.Text = reader.ReadToEnd();
                    reader.Close();

                    tempin[t - 1] = rand[t - 1];
                    tempch[t - 1] = textBox1.Text;
                    
                }
                
                
                t++;
            }
            else
            {
                button1.Visible = false;
                button2.Visible = true;
                textBox1.Visible = false;
                label2.Text = "";
                label1.Text = " Ваши результаты:\n";
                for (int i = 0; i < 5; i++)
                {
                    if (temp_ch_true[tempin[i]] == tempch[i])
                    {
                        label1.Text += (" Номер вопроса: " + Convert.ToString(tempin[i] + 1) + " Ваш ответ " + tempch[i] + "; Правильно!" + "\n");
                        h++;
                    }
                    else
                    {
                        label1.Text += (" Номер вопроса: " + Convert.ToString(tempin[i] + 1) + " Ваш ответ " + tempch[i] + "; Неравильно!" + "\n");
                        g++;
                    }
                }
                if (h <= 2)
                    label1.Text += (" \n Количество вопросов: 5\n Количество правильных ответов: " + h + "\n Ваша оценка: 2");
                else
                    label1.Text += ("\n Количество вопросов: 5\n Количество правильных ответов: " + h + "\n Ваша оценка: " + h);

            }
            d++;
            textBox1.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                label2.Visible = true;
                button1.Enabled = false;

            }
            else
            {
                label2.Visible = false;
                button1.Enabled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            
            if ((e.KeyChar < 65 || e.KeyChar > 68) && l != 8 )//запись в поле текст бокс только определённых букв с помощью кодировки ASCII
                e.Handled = true;
        }

       

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button1.Enabled=true;
            button1.Text = "Начать тест";
            button2.Visible = false;
           
            for (int i = 0; i < 10; i++)
                rand[i] = 0;
            d = 1;
            t = 0;
            h = 0;
            g = 0;
            label1.Text = "";
            
        }
    }
}
