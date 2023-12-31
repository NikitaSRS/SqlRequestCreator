﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SqlRequestCreator.UI;

using SqlRequestCreator.Util;

namespace SqlRequestCreator.UI
{
    public partial class TableCreatingF : ParentForm.Forms.FormParent
    {
        public string foreign_key = "";
        public TableCreatingF()
        {
            InitializeComponent();
            TBScheme.Text = "Scheme name...";
            TBTableName.Text = "Table name...";
            TBScheme.ForeColor = Color.Gray;
            TBTableName.ForeColor = Color.Gray;
            FLP.AutoScroll = true;
            FLP.FlowDirection = FlowDirection.TopDown;
            FLP.WrapContents = false;
            TableCreating TC = new TableCreating();
            FLP.Controls.Add(TC);
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            SqlRequestCreatorF menu = new SqlRequestCreatorF();
            this.Hide();
            menu.Show();

        }

        private void TableCreatingF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TBScheme_Enter(object sender, EventArgs e)
        {
            if (TBScheme.Text == "Scheme name...")
                TBScheme.Text = null;
            TBScheme.ForeColor = Color.Black;
        }

        private void TBTableName_Enter(object sender, EventArgs e)
        {
            if (TBTableName.Text == "Table name...")
                TBTableName.Text = null;
            TBTableName.ForeColor = Color.Black;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            TableCreating TC = new TableCreating();
            FLP.Controls.Add(TC);
        }

        private void butCompile_Click(object sender, EventArgs e)
        {
            int alpha = FLP.Controls.Count;
            int i = 0;
            string request = $"Create table {TBScheme.Text}.{TBTableName.Text} (\n";
            foreach(TableCreating TC in FLP.Controls)
            {
                request += (i == 0 ? TC.values() : $",\n{TC.values()}");
                i++;
            }
            if(TBAttrib != null && TBTable != null)
            {
                request += foreign_key;
            }
            MessageBox.Show(request + "\n);");
        }

        private void FLP_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void FLP_CursorChanged(object sender, EventArgs e)
        {

        }

        private void FLP_Enter(object sender, EventArgs e)
        {
        }

        private void CBAttr_Enter(object sender, EventArgs e)
        {
            CBAttr.Items.Clear();
            foreach (TableCreating TC in FLP.Controls)
            {
                CBAttr.Items.Add(TC.NameAttr());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreign_key += $",\nForeign key ({CBAttr.Text}) references {TBTable.Text} ({TBAttrib.Text})";
        }
    }
}
