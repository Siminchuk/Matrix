using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        public double[,] tabl;
        
        int k;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void txtBox_Leave(TextBox txtBox, string value)
        {
            try
            {
                Convert.ToDouble(txtBox.Text); // спроба конвертувати текст в число
            }
            catch // у випадку виникнення помилки
            {
                MessageBox.Show("Введіть число!"); // виведення повідомлення
                txtBox.Text = value; // встановлення заданого значення
                txtBox.Focus(); // повернення фокусу в поле введення
            }
        }
        private void button1_Leave(object sender, EventArgs e)
        {

        }
        public int SignOfElement(int i, int j)
        {
            if ((i + j) % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public double[,] CreateSmallerMatrix(double[,] input, int i, int j)
        {
            int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
            double[,] output = new double[order - 1, order - 1];
            int x = 0, y = 0;
            for (int m = 0; m < order; m++, x++)
            {
                if (m != i)
                {
                    y = 0;
                    for (int n = 0; n < order; n++)
                    {
                        if (n != j)
                        {
                            output[x, y] = input[m, n];
                            y++;
                        }
                    }
                }
                else
                {
                    x--;
                }
            }
            return output;
        }
        public double Determinant1(double[,] input)
        {
            int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
            if (order > 2)
            {
                double value = 0;
                for (int j = 0; j < order; j++)
                {
                    double[,] Temp = CreateSmallerMatrix(input, 0, j);
                    value = value + input[0, j] * (SignOfElement(0, j) * Determinant1(Temp));
                }
                return value;
            }
            else if (order == 2)
            {
                return ((input[0, 0] * input[1, 1]) - (input[1, 0] * input[0, 1]));
            }
            else
            {
                return (input[0, 0]);
            }
        }
        
        private void textBox3_Leave(object sender, EventArgs e)
        {
            txtBox_Leave(textBox3, Convert.ToString(k));
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox3.Text);
            if (b ==0)
            {
                MessageBox.Show("Введіть розмірність матриці. Число більше 1!"); // виведення повідомлення
            }
            else if (b < 0)
            {
                MessageBox.Show("Розмірність матриці не має бути від'ємна!"); // виведення повідомлення
            }
            else
            {
                tabl = new double[b, b];
                for (int i = 0; i < b; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        tabl[i, j] = r.Next(0, 10);
                    }
                }
                textBox4.Text = Convert.ToString(Determinant1(tabl));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox3.Text);
            if (b ==0)
            {
                MessageBox.Show("Введіть розмірність матриці. Число більше 1!"); // виведення повідомлення
            }
            else if (b < 0)
            {
                MessageBox.Show("Розмірність матриці не має бути від'ємна!"); // виведення повідомлення
            }
            else
            {
                tabl = new double[b, b];
                for (int i = 0; i < b; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        tabl[i, j] = r.Next(0, 10);
                    }
                }
                textBox4.Text = Convert.ToString(Determinant1(tabl));
                if (dataGridView1.ColumnCount > 0)
                {
                    dataGridView1.Columns.Clear();
                }
                int l = tabl.GetLength(0);
                for (int i = 0; i < l; i++)
                {
                    dataGridView1.Columns.Add((i + 1).ToString(), " ");
                }
                int h = tabl.GetLength(1);
                for (int i = 0; i < h; i++)
                {
                    string[] ss = new string[l];
                    for (int j = 0; j < l; j++)
                    {
                        ss[j] = tabl[i, j].ToString();
                    }
                    dataGridView1.Rows.Add(ss);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox3.Text);
            if (b ==0)
            {
                MessageBox.Show("Не існує матриці для транспортування!");
            }
            else if (b < 0)
            {
                MessageBox.Show("Розмірність матриці не має бути від'ємна!"); // виведення повідомлення
            }
            else
            {
                tabl = new double[b, b];
                for (int i = 0; i < b; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        tabl[i, j] = r.Next(0, 10);

                    }
                }
                textBox4.Text = Convert.ToString(Determinant1(tabl));
                if (dataGridView1.ColumnCount > 0)
                {
                    dataGridView1.Columns.Clear();
                }
                int l = tabl.GetLength(0);
                for (int i = 0; i < l; i++)
                {
                    dataGridView1.Columns.Add((i + 1).ToString()," ");
                    
                }
                int h = tabl.GetLength(1);
                for (int i = 0; i < h; i++)
                {
                    string[] ss = new string[l];
                    for (int j = 0; j < l; j++)
                    {
                        ss[j] = tabl[j, i].ToString();
                    }
                    dataGridView1.Rows.Add(ss);
                }
            }
            
        }

        
    }
}
