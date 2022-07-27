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
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,7895,4785.40,Gustavo Santos";
                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew)) //.Create se já existir o arquivo, ele vai apagar o conteúdo e escrever
                                                                                                //.CreateNew se já exisiter o arquivo, ele vai lançar exceção.
            using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                escritor.Write("456,65465,456.0,Pedro");
            }

        }

        static void TestaEscrita()
        {
            var caminhoNovoArquivo = "teste.txt";
            
            using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using(var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 10000; i++)
                {
                    escritor.WriteLine($"Escrevendo na linha {i}");
                    escritor.Flush(); //Despeja o buffer para o Stream
                    Console.WriteLine("Aperte enter para escrever a próxima linha");
                    Console.ReadLine();
                }
            }
        }

    }
}