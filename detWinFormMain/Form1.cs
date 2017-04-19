using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detWinFormMain
{
    public partial class Form1 : Form
    {
        detMain detm;
        public Form1()
        {
            InitializeComponent();
            detm = new detMain();
        }
        private void buttonTrue_Click(object sender, EventArgs e)
        {
            int High = Convert.ToInt32(textBoxHigh.Text);
            detm.buttonTrue(High);
            textBoxDet.Text = Convert.ToString(detm.Det);
            if (dataGridViewMatrix.ColumnCount > 0)
            {
                dataGridViewMatrix.Columns.Clear();
                dataGridViewMatrixT.Columns.Clear();
            }
            for (int i = 0; i < detm.NumberLong; i++)
            {
                dataGridViewMatrix.Columns.Add((i + 1).ToString(), " ");
            }
            for (int i = 0; i < detm.NumberHigh; i++)
            {
                for (int j = 0; j < detm.NumberLong; j++)
                {
                    detm.Matrix[j] = detm.tabl[i, j].ToString();
                }
                dataGridViewMatrix.Rows.Add(detm.Matrix);
            }
            for (int i = 0; i < detm.NumberLong; i++)
            {
                dataGridViewMatrixT.Columns.Add((i + 1).ToString(), " ");
            }
            for (int i = 0; i < detm.NumberHigh; i++)
            {
                for (int j = 0; j < detm.NumberLong; j++)
                {
                    detm.Matrix[j] = detm.tabl[j, i].ToString();
                }
                dataGridViewMatrixT.Rows.Add(detm.Matrix);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
