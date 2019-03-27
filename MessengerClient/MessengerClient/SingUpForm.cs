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
    public partial class SingUpForm : Form
    {
        public SingUpForm()
        {
            InitializeComponent();
        }
        ServerConnection connection = new ServerConnection("127.0.0.1", 54321);
        private async void RegisterButton_ClickAsync(object sender, EventArgs e)
        {
            this.Hide();
            string email = EmailTextBox.Text;
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            // budujemy z tego pakunek do wysłania
            string signUpRequest = RequestBuilder.GetSignUpRequest(email, login, password);
            // wysyłamy to, chłopcze    
            connection.Send(signUpRequest);
            // czekamy na odpowiedź odnośnie rejestracji
            Response response = await connection.GetResponse(ResponseType.SignUp);
            // jak się doczekamy, to już dalej z tym robimy co nam się podoba
            if (response[0][0] == 0)
            {
                SingInForm SingInFormShow = new SingInForm();
                SingInFormShow.Show();
            }
            else if (response[0][0] == 4)
            {
                MessageBox.Show("Zajety login");
            }
            else
            {
                MessageBox.Show("Coś poszło nie tak");
            }
            
        }
    }
}
