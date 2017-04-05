using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detWinFormMain
{
    class detMain
    {
        Random r = new Random();
        // ім'я не інформативне. поле повинне бути приватним. для доступу оформи властивість
        public double[,] tabl;
        // не використовуєтья
        int k;
        // не використовуєтья
        double dt;
        // що це? 
        double det;
        string[] ss;
        // ім'я не інформативне 
        int h;
        // ім'я не інформативне
        int l;

        // ім'я не інформативне
        // додай документуючий коментар

        /// <summary>
        /// Це документуючий коментар. Він з'являється коли наводиш курсор на цю властивість об'єкта в програмному коді
        /// Наприклад наведи на Det в формі в коді textBoxDet.Text = Convert.ToString(detm.Det);
        /// </summary>
        public double Det
        {
            set { if (value > 0) det = value; }
            get { return det; }
        }

        public double High
        {
            get { return dt; } //доступ тільки для зчитування
        }
        public int H
        {
            get { return h; } //доступ тільки для зчитування
        }
        public int L
        {
            get { return l; } //доступ тільки для зчитування
        }
        public string [] SS
        {
            get { return ss; }
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
        public void recalculate(int b)
        {
            tabl = new double[b, b];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    tabl[i, j] = r.Next(0, 10);
                }
            }
        }
        public void buttonTrue(int b)
        {
            if (b == 0)
            {
                MessageBox.Show("Введіть розмірність матриці. Число більше 1!"); // виведення повідомлення
            }
            else if (b < 0)
            {
                MessageBox.Show("Розмірність матриці не має бути від'ємна!"); // виведення повідомлення
            }
            else
            {
                recalculate(b);
                det = Convert.ToDouble(Determinant1(tabl));
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
}
