using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateChromeDriver;

namespace TesteConsulta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este projeto foi criado a fim de demostração de utilização da dll

            VersaoChromeDriver versao = new VersaoChromeDriver();

            Console.WriteLine($"O chrome driver correto para sua versão do chrome é {versao.versaoChromeDriver()}");


            Console.ReadLine();
                
                


        }
    }
}
