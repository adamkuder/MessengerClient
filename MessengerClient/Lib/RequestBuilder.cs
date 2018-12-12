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
            LogOn     = 0x01,
            LogOff    = 0x02,
        };

        public static string GetSignUpRequest(string email, string login, string password)
        {
            return (char)RequestType.SignUp + email + DELIMITER + login + DELIMITER + password;
        }
    }
}
