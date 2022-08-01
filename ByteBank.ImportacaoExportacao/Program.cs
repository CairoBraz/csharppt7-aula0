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
            //TestaEscrita();

            //using(var fs = new FileStream("testaTipos.txt", FileMode.Create))
            //using( var escritor = new StreamWriter(fs))
            //{
            //    escritor.WriteLine(true);
            //    escritor.WriteLine(false);
            //    escritor.WriteLine(123654849);
            //    escritor.WriteLine(522.45);
            //    escritor.WriteLine("Pedro Julio");
            //}

            //EscritaBinaria();
            //LeituraBinaria();
            //UsarStreamDeEntrada();


            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

            Console.WriteLine("Arquivo escrevendoComAClasseFile criado!");

            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui{ bytesArquivo.Lenght} bytes");


            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }
            
            Console.WriteLine("Escreva seu nome:");
            var nome = Console.ReadLine();
            Console.WriteLine($"O nome digitado foi: {nome}!");



            Console.WriteLine("Aplicação finalizada...");
            Console.ReadLine();
        }
    }
 }
