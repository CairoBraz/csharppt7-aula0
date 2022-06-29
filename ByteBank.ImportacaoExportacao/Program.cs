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
            var enderecoDoArquivo = "contas.txt";           //o arquivo esta na pasta Bin/Debug do projeto ByteBank.ImportacaoExportacao e se chama apenas contas

            using(var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    //var linha = leitor.Read();              //Ler apenas o primeiro byte. O retorno é um int
                    //var linha = leitor.ReadToEnd();         // Ler todo o arquivo, montar uma string única e salvar na variável linha. Usar com cuidado.
                    var linha = leitor.ReadLine();            //Ler a linha do arquivo
                    Console.WriteLine(linha);
                }
             }

            Console.ReadLine();

        }
    }
 }
