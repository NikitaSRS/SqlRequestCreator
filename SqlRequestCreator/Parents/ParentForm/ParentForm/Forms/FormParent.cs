using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentForm.Forms
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.Text = "MS SQL RC";
            this.Size = new Size(1600, 900);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           /* string message = "TbI dolbaeb ? Huli ty syuda zhmesh ? Eban'ko blyat?";
            string caption = "Eban'ko?";
            var result = MessageBox.Show(message, caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.No);
                MessageBox.Show("Pidora otvet");
                Application.Exit();
            if (result == DialogResult.Yes)
                MessageBox.Show("Pizda");
            Application.Exit();*/

        }

        private void FormParent_Load(object sender, EventArgs e)
        {
            timer.Interval = 10;
            timer.Enabled = true;
            timer.Start();
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lDateTime.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }
    }
}
