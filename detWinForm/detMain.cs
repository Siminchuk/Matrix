using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detWinForm
{
    class detMain
    {
        
        
        Random r = new Random();
        public double[,] tabl;
        int k;
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
        public void buttonTrue( int textBoxHigh, string textBoxDet)
        {
            int b = Convert.ToInt32(textBoxHigh);
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
                tabl = new double[b, b];
                for (int i = 0; i < b; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        tabl[i, j] = r.Next(0, 10);
                    }
                }
                textBoxDet = Convert.ToString(Determinant1(tabl));
            }
        }
    }
}
