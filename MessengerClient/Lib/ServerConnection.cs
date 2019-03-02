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

        public event NotificationEventHandler StatusUpdateAvailable;
        public event NotificationEventHandler MessageAvailable;

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
            int bytesRead;

            while (true)
            {
                buffer = new byte[4096];
                bytesRead = stream.Read(buffer, 0, 4096);
                Response response = new Response(buffer.Take(bytesRead).ToArray());

                if (response.Type == ResponseType.StatusUpdate)
                {
                    StatusUpdateAvailable?.Invoke(this, new NotificationEventArgs(response));
                }
                else if (response.Type == ResponseType.Message)
                {
                    MessageAvailable?.Invoke(this, new NotificationEventArgs(response));
                }
                else
                {
                    responseQueue.Add(response);
                }
            }
        }

        public void Send(byte[] request)
        {
            stream.Write(request, 0, request.Length);
        }

        public async Task<Response> GetResponse(ResponseType type)
        {
            return await Task.FromResult(responseQueue.Get(type));
        }
    }

    public delegate void NotificationEventHandler(object sender, NotificationEventArgs e);

    public class NotificationEventArgs : EventArgs
    {
        public readonly Response notification;

        public NotificationEventArgs(Response notification)
        {
            this.notification = notification;
        }
    }
}
