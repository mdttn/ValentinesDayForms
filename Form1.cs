using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValentinesDayForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int count = 0;

        private void checkBoxYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YAYAYAYAYAY YIPPEEEEEE", "Happiest day of my life", MessageBoxButtons.OK);
            MessageBox.Show("You are now Tea's valentine MWAH", "Happiest day of my life", MessageBoxButtons.OK);
            this.Close();
        }

        private void checkBoxNo_Click(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
            {
                MessageBox.Show("Please.", "Are you sure?", MessageBoxButtons.RetryCancel);
            }
            else if (count == 2)
            {
                MessageBox.Show("Pretty please.", "Are you sure?", MessageBoxButtons.RetryCancel);
            }
            else if (count == 3)
            {
                MessageBox.Show("PLEASE.", "ARE YOU SURE?", MessageBoxButtons.RetryCancel);
            }
            else if (count == 4)
            {
                MessageBox.Show("PLEASE PLEASE PLEASE PLEASE PLEASE.", "ARE YOU SURE?", MessageBoxButtons.RetryCancel);
            }
            else
            {
                MessageBox.Show("PLEASE PLEASE PLEASE PLEASE PLEASE PLEASE PLEASE PLEASE PLEASE PLEASE PLEASE PLEASE PLEASE PLEASE PLEASE PLEASE PLEASE PLEASE.",
                    "PLEASE.", MessageBoxButtons.RetryCancel);
            }
            this.checkBoxNo.Checked = false;
        }
    }
}
