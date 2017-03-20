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
    public partial class tabl : Form
    {
        Form1 k;
        public tabl()
        {
            InitializeComponent();
            k = new Form1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabl_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(k.tabl);
        }
    }
}
