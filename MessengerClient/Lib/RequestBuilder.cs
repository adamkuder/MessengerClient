using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public static class RequestBuilder
    {
        const char DELIMITER = '\r';

        enum RequestType : ushort
        {
            SignUp    = 0x00,
            LogIn     = 0x01,
            LogOut    = 0x02,
        };

        public static string GetSignUpRequest(string email, string login, string password)
        {
            return (char)RequestType.SignUp + email + DELIMITER + login + DELIMITER + password;
        }

        public static string GetLogInRequest(string login, string password)
        {
            return (char)RequestType.LogIn + login + DELIMITER + password;
        }
    }
}
