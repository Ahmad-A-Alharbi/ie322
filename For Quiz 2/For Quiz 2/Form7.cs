using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Quiz_2
{
    public partial class Frmarray : Form
    {
        Int32[] iArray2 = new Int32[5];
        Int32[] iArray3 = new Int32[] { 21, 22, 23, 24, 25 };

        Int32[] iArray4 = new Int32[] { 11, 12, 13, 14, 15 };
        Int32[] iArray5 = { 31, 32, 33, 34, 35 };

        Int32[] iArray = new Int32[5] { 21, 22, 23, 24, 25 };

     


        public Frmarray()
        {
            InitializeComponent();
            //Int32[] iArray1;//
            //Array1 = new Int32[5];//



        }

        private void Frmarray_Load(object sender, EventArgs e)
        {

        }

        private void btnArray_Click(object sender, EventArgs e)
        {


            for (Int32 i = 1; i < 5; i++)
            {
                iArray[i] = 5 * i;
                MessageBox.Show(Convert.ToString(iArray[i]));
            }
        }

        private void btnarray2_Click(object sender, EventArgs e)
        {
            foreach (Int32 j in iArray3)
            {
                MessageBox.Show(Convert.ToString(j));
            }
        }

        private void btnarray3_Click(object sender, EventArgs e)
        {


        }

        private void listBoxrandom_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
    }
}
