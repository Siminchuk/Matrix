﻿using System;
using System.Windows.Forms;

namespace detWinFormMain
{
    class detMain
    {
        Random r = new Random();
        public double[,] tabl;
        int k;
        int l ;
        int h;
        int dt=0;
        double det;
        string[] ss;
        string[] st;
        public int High
        {
            set { if (value > 0) dt = value; }
            get { return dt; }
        }
        public double Det
        {
            get { return det; } //доступ тільки для зчитування
        }
        public string[] SS
        {
            get { return ss; } //доступ тільки для зчитування
        }
        public int L
        {
            get { return l; } //доступ тільки для зчитування
        }
        public int H
        {
            get { return h; } //доступ тільки для зчитування
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
        public void recalculate()
        {
            tabl = new double[dt, dt];
            for (int i = 0; i < dt; i++)
            {
                for (int j = 0; j < dt; j++)
                {
                    tabl[i, j] = r.Next(0, 10);
                }
            }
            det = Convert.ToDouble(Determinant1(tabl));
        }
        public void buttonTrue(int High)
        {
            if (High == 0)
            {
                MessageBox.Show("Введіть розмірність матриці. Число більше 1!"); // виведення повідомлення
            }
            else if (High < 0)
            {
                MessageBox.Show("Розмірність матриці не має бути від'ємна!"); // виведення повідомлення
            }
            else
            {
                dt = High;
                recalculate();
                
            }
            l = tabl.GetLength(0);
            h = tabl.GetLength(1);
            for (int i = 0; i < h; i++)
            {
                ss = new string[l];
                for (int j = 0; j < l; j++)
                {
                    ss[j] = tabl[i, j].ToString();
                }
            }

        }
        
     }
}
