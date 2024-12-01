using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userError = new UserErrorHandler();
            var serverError = new ServerErrorHandler();
            userError.SetNextHandler(serverError);
            var serverErrorRequest = new Request();
            serverErrorRequest.Type = "Ошибка сервера";
            serverErrorRequest.Message = "Сервер не работает";
            var userErrorRequest = new Request();
            userErrorRequest.Type = "Ошибка пользователя";
            userErrorRequest.Message = "Пользователь не работает";
            var unknownRequest = new Request();
            unknownRequest.Type = "Unknown";
            unknownRequest.Message = "Unknown";
            userError.Handle(serverErrorRequest);
            userError.Handle(userErrorRequest);
            userError.Handle(unknownRequest);
            Console.Read();
        }
    }
}
