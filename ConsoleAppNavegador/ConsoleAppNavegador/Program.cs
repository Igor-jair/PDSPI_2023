using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNavegador
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a requisição
            WebRequest req = WebRequest.Create("https://portal.ifrn.edu.br/");

            // Aramazena a resposta
            WebResponse resp = req.GetResponse();

            // Cria uma cadeia de caracteres ASCII
            StreamReader reader = new StreamReader (resp.GetResponseStream(), Encoding.ASCII);

            // Apresenta na tela de console
            Console.WriteLine(reader.ReadToEnd());

            Console.ReadLine();
        }
    }
}
