using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SingIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingInForm SingInFormShow = new SingInForm();
            SingInFormShow.Show();
        }

        private void SingUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingUpForm SingUpFormShow = new SingUpForm();
            SingUpFormShow.Show();
        }
    }
}
