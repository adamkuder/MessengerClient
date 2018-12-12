using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Lib
{
    public static class Sender
    {
        public static string SendAndReceive(string message)
        {
            TcpClient connection = Server.GetConnection();
            NetworkStream stream = connection.GetStream();
            byte[] dataSent = Encoding.UTF8.GetBytes(message);
            byte[] dataReceived = new byte[1024];
            // int bytesReceived = 0;

            stream.Write(dataSent, 0, dataSent.Length);
            stream.Read(dataReceived, 0, 1024);
            
            stream.Close();

            return Encoding.UTF8.GetString(dataReceived);
        }
    }
}
