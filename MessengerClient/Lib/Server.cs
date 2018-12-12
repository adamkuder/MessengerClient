using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Lib
{
    public static class Server
    {
        public static string Address { private get; set; }
        public static int Port { private get; set; }

        public static TcpClient GetConnection()
        {
            return new TcpClient(Address, Port);
        }

        static bool validateAddress()
        {
            return true;
        }

        static bool validatePort()
        {
            return true;
        }
    }
}
