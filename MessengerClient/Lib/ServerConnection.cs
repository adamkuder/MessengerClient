using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Lib
{
    public class ServerConnection
    {
        public string Address { private get; set; }
        public int Port { private get; set; }

        TcpClient socket;
        NetworkStream stream;
        Thread listenerThread;
        ResponseQueue responseQueue;

        public event ResponseEventHandler ResponseAvailable;

        public ServerConnection(string address, int port)
        {
            Address = address;
            Port = port;

            listenerThread = new Thread(new ThreadStart(Listen));
            responseQueue = new ResponseQueue();

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
                responseQueue.Add(buffer);
                // ResponseAvailable?.Invoke(this, new ResponseEventArgs(buffer));
            }
        }

        public void Send(string request)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(request);

            stream.Write(bytes, 0, bytes.Length);
        }

        public async Task<Response> GetResponse(ResponseType type)
        {
            //return await Task.FromResult(responseQueue.Get(type));
            return await Task.FromResult(responseQueue.Get(type));
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
