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
    class Program
    {
        static void Main(string[] args)
        {
            var enderecoDoArquivo = "contas.txt"; //o arquivo esta na pasta Bin/Debug do projeto ByteBank.ImportacaoExportacao e se chama apenas contas
            var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);
            var buffer = new byte[1024];  // 1KB = 1024 Bytes
            var numeroDeBytesLidos = -1;
            var textoComQuebraDeLinha = "Primeira linha \nSegunda linha!";
            var textocomContraBarraNNaEscrita = "Primeira linha \\n ainda na primeira linha!";


            Console.WriteLine(textoComQuebraDeLinha);
            Console.WriteLine(textocomContraBarraNNaEscrita);
            Console.ReadLine();

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                EscreverBuffer(buffer);
            };
            


            Console.ReadLine();
        }

        static  void EscreverBuffer(byte[] buffer)
        {
            var utf8 = Encoding.Default;
            var texto = utf8.GetString(buffer);

            Console.Write(texto);

            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }
    }
}
