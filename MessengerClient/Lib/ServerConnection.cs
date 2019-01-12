using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Lib
{
    public class ServerConnection
    {
        public string Address { private get; set; }
        public int Port { private get; set; }

        TcpClient socket;
        NetworkStream stream;
        Thread listenerThread;

        public event ResponseEventHandler ResponseAvailable;

        public ServerConnection(string address, int port)
        {
            Address = address;
            Port = port;

            listenerThread = new Thread(new ThreadStart(Listen));

            Open();
        }

        void Open()
        {
            socket = new TcpClient(Address, Port);
            stream = socket.GetStream();
            listenerThread.Start();
        }

        void Listen()
        {
            byte[] buffer;

            while (true)
            {
                buffer = new byte[4096];
                stream.Read(buffer, 0, 4096);
                ResponseAvailable?.Invoke(this, new ResponseEventArgs(buffer));
            }
        }
    }

    public delegate void ResponseEventHandler(object sender, ResponseEventArgs e);

    public class ResponseEventArgs : EventArgs
    {
        public readonly byte[] data;

        public ResponseEventArgs(byte[] data)
        {
            this.data = data;
        }
    }
}
