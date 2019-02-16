using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public static class ResponseParser
    {
        const char DELIMITER = '\r';

        public static ResponseItem[] Parse(IEnumerable<byte> body)
        {
            List<byte> byteList = new List<byte>();
            List<ResponseItem> responseItemList = new List<ResponseItem>();

            foreach (byte b in body)
            {
                if (b != DELIMITER)
                {
                    byteList.Add(b);
                }
                else
                {
                    responseItemList.Add(new ResponseItem(byteList.ToArray()));
                    byteList.Clear();
                }
            }

            responseItemList.Add(new ResponseItem(byteList.ToArray()));

            return responseItemList.ToArray();
        }
    }
}
