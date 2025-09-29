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

        public int count = 1;

        private void checkBoxYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YAYAYAYAYAY YIPPEEEEEE", "Happiest day of my life", MessageBoxButtons.OK);
            MessageBox.Show("You are now Tea's valentine!", "Happiest day of my life", MessageBoxButtons.OK);
            this.Close();
        }

        private void checkBoxNo_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append("PLEASE. ");
            }
            MessageBox.Show(sb.ToString().Trim(), "Are you sure?", MessageBoxButtons.RetryCancel);
            
            count++;
            this.checkBoxNo.Checked = false;
        }
    }
}
