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
    public partial class frmradio : Form
    {
        public frmradio()
        {
            InitializeComponent();
        }

        private void btnRed_CheckedChanged(object sender, EventArgs e)
        {
            if (btnRed.Checked == true)
                btnRed.ForeColor = Color.FromName("Red");
            else
                btnRed.ForeColor = Color.FromName("Black");
        }

        private void btnGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (btnGreen.Checked == true)
                btnGreen.ForeColor = Color.FromName("Green");
            else
                btnGreen.ForeColor = Color.FromName("Black");
        }

        private void btnBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (btnBlue.Checked == true)
                btnBlue.ForeColor = Color.FromName("Blue");
            else
                btnBlue.ForeColor = Color.FromName("Black");
        }

        private void btnYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (btnYellow.Checked == true)
                btnYellow.ForeColor = Color.FromName("Yellow");
            else
                btnYellow.ForeColor = Color.FromName("Black");
        }

        private void btnRed2_CheckedChanged(object sender, EventArgs e)
        {
            btnRed2.ForeColor = Color.FromName("Red");
        }

        private void btnGreen2_CheckedChanged(object sender, EventArgs e)
        {
            btnGreen2.ForeColor = Color.FromName("Green");
        }

        private void btnBlue2_CheckedChanged(object sender, EventArgs e)
        {
            btnBlue2.ForeColor = Color.FromName("Blue");
        }

        private void btnYellow2_CheckedChanged(object sender, EventArgs e)
        {
            btnYellow2.ForeColor = Color.FromName("Yellow");
        }

        private void btnrest_Click(object sender, EventArgs e)
        {
            btnRed.Checked = false;
            btnGreen.Checked = false;
            btnBlue.Checked = false;
            btnYellow.Checked = false;
            btnRed.ForeColor = Color.FromName("Black");
            btnGreen.ForeColor = Color.FromName("Black");
            btnBlue.ForeColor = Color.FromName("Black");
            btnYellow.ForeColor = Color.FromName("Black");

            btnRed2.Checked = false;
            btnGreen2.Checked = false;
            btnBlue2.Checked = false;
            btnYellow2.Checked = false;
            btnRed2.ForeColor = Color.FromName("Black");
            btnGreen2.ForeColor = Color.FromName("Black");
            btnBlue2.ForeColor = Color.FromName("Black");
            btnYellow2.ForeColor = Color.FromName("Black");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
