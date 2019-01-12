using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    class ResponseQueue
    {
        List<Response> queue;

        public ResponseQueue()
        {
            queue = new List<Response>();
        }

        public void Add(object sender, ResponseEventArgs e)
        {
            queue.Add(new Response(e.data));
        }

        public Response Get(ResponseType type)
        {
            return queue.Find(response => (response.Type == type));
        }
    }
}
