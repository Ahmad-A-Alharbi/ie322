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
    public partial class Frmain : Form
    {
        public Frmain()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login sucessful");
        }

        private void btnradio_Click(object sender, EventArgs e)
        {
            frmradio frm = new frmradio();
            frm.ShowDialog();
        }

        private void btnCheckBox_Click(object sender, EventArgs e)
        {
            frmcheckbox frm = new frmcheckbox();
            frm.ShowDialog();
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            frmcombo frm = new frmcombo();
            frm.ShowDialog();
        }

        private void btnCombo2_Click(object sender, EventArgs e)
        {
            frmcmb frm = new frmcmb();
            frm.ShowDialog();
        }

        private void btnrandomcombo_Click(object sender, EventArgs e)
        {
            Frmrandomcombo frm = new Frmrandomcombo();
            frm.ShowDialog();
        }

        private void buttonarray_Click(object sender, EventArgs e)
        {
            Frmarray frm = new Frmarray();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
