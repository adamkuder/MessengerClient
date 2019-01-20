using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public static class ResponseParser
    {
        const char DELIMITER = '\r';

        public static string[] Parse(IEnumerable<char> body)
        {
            StringBuilder builder = new StringBuilder();
            List<string> result = new List<string>();

            foreach (char c in body)
            {
                if (c != DELIMITER)
                {
                    builder.Append(c);
                }
                else
                {
                    result.Add(builder.ToString());
                    builder.Clear();
                }
            }

            result.Add(builder.ToString());

            return result.ToArray();
        }
    }
}
