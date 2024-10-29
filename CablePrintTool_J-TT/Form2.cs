using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CablePrintTool_J_TT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            const int MAXROW = 20;
            dgvCut.RowHeadersVisible = false;
            dgvCut.ColumnHeadersDefaultCellStyle.Font = new Font("MS Gothic", 26);
            dgvCut.RowsDefaultCellStyle.Font = new Font("MS Gothic", 26);

            for (int i = 0; i < MAXROW; i++)
            {
                if (i < MAXROW - 1)
                {
                    dgvCut.Rows.Add();
                }
                dgvCut[0, i].Value = i + 1;
                dgvCut[1, i].Value = MAXROW + i + 1;
                dgvCut[2, i].Value = MAXROW * 2 + i + 1;
                dgvCut[3, i].Value = MAXROW * 3 + i + 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
