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
    public partial class frmcheckbox : Form
    {
        public frmcheckbox()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (cheCoffe.Checked == true)
            {
                msg = cheCoffe.Text;
            }
            if (cheDount.Checked == true)
            {
                msg = msg + " " + cheDount.Text;
            }
            if (cheBrownie.Checked == true)
            {
                msg = msg + " " + cheBrownie.Text;
            }
            if (msg.Length > 0)
            {
                MessageBox.Show(msg + " Selected ");
            }
            else
            {
                MessageBox.Show("Nothing selected");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
