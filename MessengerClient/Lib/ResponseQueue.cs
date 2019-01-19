using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    class ResponseQueue
    {
        List<Response> queue;

        public ResponseQueue()
        {
            queue = new List<Response>();
        }

        public void Add(byte[] data) // (object sender, ResponseEventArgs e)
        {
            queue.Add(new Response(data));
        }

        public Response Get(ResponseType type)
        {
            Response response;

            while (true)
            {
                if (queue.Any((Response r) => (r.Type == type)))
                {
                    response = queue.Find(r => r.Type == type);
                    queue.Remove(response);
                    break;
                }
            }

            return response;
        }
    }
}
