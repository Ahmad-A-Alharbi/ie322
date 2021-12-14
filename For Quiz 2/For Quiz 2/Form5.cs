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
    public partial class frmcmb : Form
    {
        Random y = new Random();
        
        public frmcmb()
        {
            InitializeComponent();
        }

        private void Btngeraterandom_Click(object sender, EventArgs e)
        {
            Btngeraterandom.Text = Convert.ToString(y.Next(1, 100));
        }

        private void btnrandom_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);
            btnrandom.BackColor = Color.FromArgb(r, g, b);
            largb.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
            
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }

        private void largb_Click(object sender, EventArgs e)
        {

        }
    }
}
