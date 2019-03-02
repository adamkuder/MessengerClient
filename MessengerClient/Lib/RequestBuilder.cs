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
            SignUp      = 0x00,
            LogIn       = 0x01,
            LogOut      = 0x02,
            GetContacts = 0x03,
            AddContact  = 0x04,
            Message     = 0x06,
        };

        public static byte[] GetSignUpRequest(string email, string login, string password)
        {
            List<byte> request = new List<byte>();

            request.Add((byte)RequestType.SignUp);
            request.AddRange(Encoding.UTF8.GetBytes(email));
            request.Add((byte)DELIMITER);
            request.AddRange(Encoding.UTF8.GetBytes(login));
            request.Add((byte)DELIMITER);
            request.AddRange(Encoding.UTF8.GetBytes(password));

            return request.ToArray();
        }

        public static byte[] GetLogInRequest(string login, string password)
        {
            List<byte> request = new List<byte>();

            request.Add((byte)RequestType.LogIn);
            request.AddRange(Encoding.UTF8.GetBytes(login));
            request.Add((byte)DELIMITER);
            request.AddRange(Encoding.UTF8.GetBytes(password));

            return request.ToArray();
        }

        public static byte[] GetAddContactRequest(uint key, string contactLogin)
        {
            List<byte> request = new List<byte>();
            List<byte> keyToBytes = BitConverter.GetBytes(key).ToList();
            if (BitConverter.IsLittleEndian)
                keyToBytes.Reverse();

            request.Add((byte)RequestType.AddContact);
            request.AddRange(keyToBytes);
            request.Add((byte)DELIMITER);
            request.AddRange(Encoding.UTF8.GetBytes(contactLogin));

            return request.ToArray();
        }

        public static byte[] GetGetContactsRequest(uint key)
        {
            List<byte> request = new List<byte>();
            List<byte> keyToBytes = BitConverter.GetBytes(key).ToList();
            if (BitConverter.IsLittleEndian)
                keyToBytes.Reverse();

            request.Add((byte)RequestType.GetContacts);
            request.AddRange(keyToBytes);

            return request.ToArray();
        }

        public static byte[] GetMessageRequest(uint key, string recipient, string message)
        {
            List<byte> request = new List<byte>();
            List<byte> keyToBytes = BitConverter.GetBytes(key).ToList();
            if (BitConverter.IsLittleEndian)
                keyToBytes.Reverse();

            request.Add((byte)RequestType.Message);
            request.AddRange(keyToBytes);
            request.Add((byte)DELIMITER);
            request.AddRange(Encoding.UTF8.GetBytes(recipient));
            request.Add((byte)DELIMITER);
            request.AddRange(Encoding.UTF8.GetBytes(message));

            return request.ToArray();
        }
    }
}
