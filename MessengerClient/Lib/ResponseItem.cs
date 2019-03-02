using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class ResponseItem
    {
        private byte[] Bytes { get; set; }

        public ResponseItem(byte[] bytes)
        {
            this.Bytes = bytes;
        }

        public static explicit operator string(ResponseItem responseItem)
        {
            return new string(Encoding.UTF8.GetChars(responseItem.Bytes));
        }

        public static explicit operator ushort(ResponseItem responseItem)
        {
            if (responseItem.Bytes.Length > 1)
                return (BitConverter.IsLittleEndian) ? BitConverter.ToUInt16(responseItem.Bytes.Reverse().ToArray(), 0)
                                                     : BitConverter.ToUInt16(responseItem.Bytes, 0);
            else
                return (ushort)responseItem.Bytes[0];
        }

        public static explicit operator uint(ResponseItem responseItem)
        {
            if (responseItem.Bytes.Length > 1)
                return (BitConverter.IsLittleEndian) ? BitConverter.ToUInt32(responseItem.Bytes.Reverse().ToArray(), 0) 
                                                     : BitConverter.ToUInt32(responseItem.Bytes, 0);
            else
                return (uint)responseItem.Bytes[0];
        }

        public static explicit operator bool(ResponseItem responseItem)
        {
            if (responseItem.Bytes.Length > 1)
                throw new ArgumentException("Item too large to convert to boolean.");
            else
                return responseItem.Bytes[0] != (byte)0;
        }
    }
}
