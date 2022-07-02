using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mergenui
{
    public partial class Controls : Form
    {
        public Controls()
        {
            InitializeComponent();
        }

        private void Controls_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            timer1.Stop();
            frm.Show();

        }
    }
}
