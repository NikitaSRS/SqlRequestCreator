using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentElement
{
    public partial class UCTableCreating: UserControl
    {
        public UCTableCreating()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public string values()
        {
            return TBAttributes.Text + " " + CBTypes.Text + (TBSize.Text != "" ? $"({TBSize.Text} )" : "") + (CBPK.Checked == true ? " Primary key" : "") + (CBNULL.Checked == true ? " null" : " not null") + (CBidentity.Checked == true ? $" identity({TB1.Text},{TB2.Text})": "");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBidentity_CheckedChanged(object sender, EventArgs e)
        {
            if (CBidentity.Checked == true)
            {
                TB1.ReadOnly = false;
                TB2.ReadOnly = false;
            }
        }
    }
}
