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
<<<<<<< HEAD
        Random dimension = new Random();
        public double[,] tabl;
        double det;
        string[] matrix;
        int numberHigh;
        int numberLong;
        /// <summary>
        /// Детермінант матриці.
=======
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
>>>>>>> f14726cc9a7ea0b93fb09abf8cbb379a2fc1faf4
        /// </summary>
        public double Det
        {
            set { if (value > 0) det = value; }
            get { return det; }
        }
<<<<<<< HEAD
        /// <summary>
        /// Матриця.
        /// </summary>
        public string[] Matrix
=======

        public double High
>>>>>>> f14726cc9a7ea0b93fb09abf8cbb379a2fc1faf4
        {
            get { return matrix; }
        }
        /// <summary>
        /// Кількість символів в стовбчику матриці.
        /// </summary>
        public int NumberHigh
        {
            get { return numberHigh; } //доступ тільки для зчитування
        }
        /// <summary>
        /// Кількість символів в рядку матриці.
        /// </summary>
        public int NumberLong
        {
            get { return numberLong; } //доступ тільки для зчитування
        }
        /// <summary>
        /// Визначення знаку елемента матриці для обрахунку детермінанту.
        /// </summary>
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
        /// <summary>
        /// Побудова мінора попередньої матриці.
        /// </summary>
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
        /// <summary>
        /// Обчислення детермінанту заданої матриці.
        /// </summary>
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
                    tabl[i, j] = dimension.Next(0, 10);
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
                numberLong = tabl.GetLength(0);
                numberHigh = tabl.GetLength(1);
                for (int i = 0; i < numberHigh; i++)
                {
                    matrix = new string[numberLong];
                    for (int j = 0; j < numberLong; j++)
                    {
                        matrix[j] = tabl[i, j].ToString();
                    }
                    
                }
            }
        }
    }
}
