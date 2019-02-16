using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Contact
    {
        public string Login { get; private set; }
        public bool Online { get; set; }

        public Contact(string login)
        {
            this.Login = login;
            this.Online = false;
        }

        public override string ToString()
        {
            return String.Format("Contact:[{0}]", Login);
        }
    }
}
