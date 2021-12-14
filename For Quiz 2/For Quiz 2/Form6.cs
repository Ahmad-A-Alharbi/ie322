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
    public partial class Frmrandomcombo : Form
    {
        public Frmrandomcombo()
        {
            InitializeComponent();
        }

        private void cmbrandom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btngenratecmb_Click(object sender, EventArgs e)
        {
            cmbrandom.ResetText();
            cmbrandom.Items.Clear();
            Random r = new Random();
            for (int i = 0; i< r.Next(1,50) - 1;i++)
            {
                cmbrandom.Items.Add(r.Next(100, 9990));
            }
        }

        private void Frmrandomcombo_Load(object sender, EventArgs e)
        {

        }
    }
}
