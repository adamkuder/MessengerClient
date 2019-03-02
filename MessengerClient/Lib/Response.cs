using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public enum ResponseType : ushort
    {
        SignUp       = 0x00,
        Message      = 0x02,
        LogIn        = 0x01,
        GetContacts  = 0x03,
        AddContact   = 0x04,
        StatusUpdate = 0x05,
    };

    public class Response
    {
        ResponseType type;
        ResponseItem[] body;        

        #region Properties
        public ResponseType Type
        {
            get { return type; }
        }

        public int Length
        {
            get { return body.Length; }
        }
        #endregion Properties

        public Response(byte[] data)
        {
            type = (ResponseType)data[0];
            body = ResponseParser.Parse(data.Skip(1));
        }

        #region Operators
        public ResponseItem this[int i]
        {
            get
            {
                return body[i];
            }
        }
        #endregion Operators
    }
}
