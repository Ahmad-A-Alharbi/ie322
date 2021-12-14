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
    public partial class frmcombo : Form
    {
        public frmcombo()
        {
            InitializeComponent();

            cmbdays.Items.Add("Sunday");

            cmbdays.Items.Add("Monday");

            cmbdays.Items.Add("Tuesday");

            cmbdays.Items.Add("Wednesday");

            cmbdays.Items.Add("Thursday");

            cmbdays.Items.Add("Friday");

            cmbdays.Items.Add("Saturday");

            cmbdays.Items.Add("Funday");

            cmbdays.Items.Add("Examday");

        }

        private void frmcombo_Load(object sender, EventArgs e)
        {

        }

        private void btnshow1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbdays.Text);
        }

        private void btnRemovebyname_Click(object sender, EventArgs e)
        {
            cmbdays.Items.Remove("Friday");

        }

        private void btnRemovebyindex_Click(object sender, EventArgs e)
        {
            cmbdays.Items.RemoveAt(1);
        }

        private void btnremovelist_Click(object sender, EventArgs e)
        {
            if (cmbdays.Items.Count >= 1)
            {
                cmbdays.Items.RemoveAt(cmbdays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Can't remove last item");
            }
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cmbdays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
