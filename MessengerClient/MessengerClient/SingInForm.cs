using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;


namespace MessengerClient
{
    public partial class SingInForm : Form
    {
        public SingInForm()
        {
            InitializeComponent();
        }
        ServerConnection connection = new ServerConnection("127.0.0.1", 54321);
        private async void LogInButton_ClickAsync(object sender, EventArgs e)
        {
            
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            string logInRequest = RequestBuilder.GetLogInRequest(login, password);
            
            connection.Send(logInRequest);
            MessageBox.Show("TRY Connection");
            Response response = await connection.GetResponse(ResponseType.LogIn);
            MessageBox.Show("i have responce");
            if (response[0][0] == 0)
            {
                this.Hide();
                MessageBox.Show("Connection");
                ChatPage ChatPageShow = new ChatPage();
                ChatPageShow.Show();
                
            }
            else if (response[0][0] == 1 || response[0][0] == 2)
            {
                MessageBox.Show("nie prawidlowe haslo lub login");
            }
            else
            { MessageBox.Show("Cosik nie tak"); }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
