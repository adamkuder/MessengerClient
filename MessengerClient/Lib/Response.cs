using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public enum ResponseType : ushort
    {
        SignUp = 0x00,
        LogIn = 0x01,
    };

    public class Response
    {
        string[] body;
        ResponseType type;

        #region Properties
        public ResponseType Type
        {
            get { return type; }
        }
        #endregion Properties

        public Response(byte[] data)
        {
            char[] decodedData = Encoding.UTF8.GetChars(data);

            type = (ResponseType)decodedData[0];
            body = ResponseParser.Parse(decodedData.Skip(1));
        }

        #region Operators
        public string this[int i]
        {
            get
            {
                return body[i];
            }
        }
        #endregion Operators
    }
}
