using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class ServerErrorHandler : Handler
    {
        public override void Handle(Request request)
        {
            if (request.Type == "Ошибка сервера")
            {
                Console.WriteLine("Ошибка сервера");
            }
            else if (handler != null)
            {
                handler.Handle(request);
            }
        }
    }
}
