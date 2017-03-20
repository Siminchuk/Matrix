﻿using System;
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

        private void txtBox_Leave(TextBox txtBox, string value)
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
        public double Determinant(double[,] input)
        {
            int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
            if (order > 2)
            {
                double value = 0;
                for (int j = 0; j < order; j++)
                {
                    double[,] Temp = CreateSmallerMatrix(input, 0, j);
                    value = value + input[0, j] * (SignOfElement(0, j) * Determinant(Temp));
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
            
            tabl = new double[b, b];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    tabl[i, j] = r.Next(0, 10);
                   
                }
                
            }
            
            textBox4.Text = Convert.ToString(Determinant(tabl));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Створення нового екземпляру форми
                tabl fm1 = new tabl();
                // Відображення форми
                fm1.Show();
            }
        }
    }
}