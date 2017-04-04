using System;
using System.Windows.Forms;

namespace detWinFormMain
{
    public partial class Form1 : Form
    {
        detMain detm;
        public string Det;
        public Form1()
        {
            InitializeComponent();
            detm = new detMain();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonTrue_Click(object sender, EventArgs e)
        {
            int High = Convert.ToInt32(textBoxHigh.Text);
            detm.buttonTrue(High);
            textBoxDet.Text = Convert.ToString(detm.Det);
            if (High > 0)
            {
                if (dataGridViewMatrix.ColumnCount > 0)
                {
                    dataGridViewMatrix.Columns.Clear();
                    dataGridViewMatrixT.Columns.Clear();
                }
                for (int i = 0; i < detm.L; i++)
                {
                    dataGridViewMatrix.Columns.Add((i + 1).ToString(), " ");
                }
                for (int i = 0; i < detm.H; i++)
                {
                    for (int j = 0; j < detm.L; j++)
                    {
                        detm.SS[j] = detm.tabl[i, j].ToString();
                    }
                    dataGridViewMatrix.Rows.Add(detm.SS);
                }
                for (int i = 0; i < detm.L; i++)
                {
                    dataGridViewMatrixT.Columns.Add((i + 1).ToString(), " ");

                }
                for (int i = 0; i < detm.H; i++)
                {
                    for (int j = 0; j < detm.L; j++)
                    {
                        detm.SS[j] = detm.tabl[j, i].ToString();
                    }
                    dataGridViewMatrixT.Rows.Add(detm.SS);
                }
            }
            else
            { }
            
        }
    }
}
