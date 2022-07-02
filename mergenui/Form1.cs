using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace mergenui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static bool dash_splash = true;
        private static bool _login = false;
        public static string username;

        public static void _ex()
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            guna2Panel2.Visible = false;
            guna2GradientPanel1.Visible = false;
            gunaLabel3.Visible = false;
            gunaLabel4.Visible = false;
            gunaLabel5.Visible = false;
            gunaLabel6.Visible = false;
            gunaLabel7.Visible = false;
            gunaLabel11.Visible = false;
            guna2TextBox1.Visible = false;
            guna2TextBox2.Visible = false;
            gunaLabel8.Visible = false;
            gunaLabel9.Visible = false;
            gunaLabel10.Visible = false;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            timer6.Start();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            guna2Transition1.ShowSync(guna2GradientPanel1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            guna2Transition2.ShowSync(gunaLabel3);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            guna2Transition3.ShowSync(gunaLabel4);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            guna2Transition4.ShowSync(gunaLabel5);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Stop();
            guna2Transition5.ShowSync(gunaLabel6);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            animation_next.Start();
        }
        
        private void animation_next_Tick(object sender, EventArgs e)
        {

            if (dash_splash == true)
            {
                guna2Transition6.HideSync(guna2Button1);
                guna2Transition6.HideSync(gunaLabel3);
                guna2Transition6.HideSync(gunaLabel4);
                guna2Transition6.HideSync(gunaLabel5);
                guna2Transition6.HideSync(gunaLabel6);
                guna2Transition6.HideSync(gunaLabel7);
                animation_next.Stop();
                timer7.Start();
                dash_splash = false;
            }
            else if (dash_splash == false)
            {

                if (guna2TextBox1.Text == "micro" && guna2TextBox2.Text == "123")
                {
                    _login = true;
                    timer9.Start();
                }
                else
                {
                    _login = false;
                    timer9.Start();
                }
                animation_next.Stop();
            }
        }

        private void guna2Transition6_AnimationCompleted(object sender, Guna.UI2.AnimatorNS.AnimationCompletedEventArg e)
        {
            
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            timer6.Stop();
            guna2Transition7.ShowSync(gunaLabel7);
        }

        private void guna2Transition6_AllAnimationsCompleted(object sender, EventArgs e)
        {

        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            dash_splash = false;
            timer7.Stop();
            guna2Panel2.Visible = true;
            guna2Button1.Text = "Login";
            guna2Transition5.ShowSync(guna2Button1);
            timer8.Start();
            
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            timer8.Stop();
            guna2Transition8.ShowSync(guna2TextBox1);
            guna2Transition8.ShowSync(guna2TextBox2);
            guna2Transition8.ShowSync(gunaLabel8);
            guna2Transition8.ShowSync(gunaLabel9);
            guna2Transition8.ShowSync(gunaLabel10);
            Form1 frm1 = new Form1();
            guna2Transition8.HideSync(frm1);
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (_login == true)
            {
                _mainform mf = new _mainform();
                    mf.Show();
                this.Close();
                timer9.Stop();
            }
            else
            {
                gunaLabel11.ForeColor = Color.FromArgb(173, 22, 30);
                gunaLabel11.Text = "Username or password is invalid, try again.";
                guna2Transition9.ShowSync(gunaLabel11);
            }
            timer9.Stop();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            _ex();
        }
    }
}
