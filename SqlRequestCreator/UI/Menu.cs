using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using SqlRequestCreator.UI;

namespace SqlRequestCreator
{
    public partial class SqlRequestCreatorF : ParentForm.Forms.FormParent
    {
        public SqlRequestCreatorF()
        {
            InitializeComponent();
        }


        private void butLanguageChange_Click(object sender, EventArgs e)
        {

        }

        private void butCreateTable_Click(object sender, EventArgs e)
        {
            TableCreatingF TC = new TableCreatingF();
            TC.Show();
            this.Hide();
        }

        private void SqlRequestCreatorF_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void SqlRequestCreatorF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
