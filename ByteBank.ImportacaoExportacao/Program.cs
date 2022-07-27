using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.SistemaAgencia;
using System.IO; //Imput e Output

namespace ByteBank.ImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //CriarArquivo();
            //CriarArquivoComWriter();
            TestaEscrita();

            Console.WriteLine("Aplicação finalizada...");
            Console.ReadLine();
        }
    }
 }
