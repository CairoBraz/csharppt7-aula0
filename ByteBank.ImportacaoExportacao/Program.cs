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
            using (var leitor = new StreamReader(fluxoDeArquivo))           //StreamReader(fluxoDeArquivo-> Encoding default , StreamReader(fluxoDeArquivo, Encoding.UTF32) -> escolhe um encoding
            {
                while (!leitor.EndOfStream)
                {
                    //var linha = leitor.Read();              //Ler apenas o primeiro byte. O retorno é um int
                    //var linha = leitor.ReadToEnd();         // Ler todo o arquivo, montar uma string única e salvar na variável linha. Usar com cuidado.
                    var linha = leitor.ReadLine();            //Ler a linha do arquivo
                    var contaCorrente = ConverterStringParaContaCorrente(linha);

                    var msg = $"TItular: {contaCorrente.Titular.Nome},Conta número { contaCorrente.Numero}, ag. { contaCorrente.Agencia}, Saldo { contaCorrente.Saldo}";

                    Console.WriteLine(msg);
                    //Console.WriteLine(linha);
                }
             }
            Console.ReadLine();
        }
        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            string[] campos = linha.Split(',');

            var agencia = int.Parse(campos[0]);
            var numeroConta = int.Parse(campos[1]);
            var saldo = double.Parse(campos[2].Replace('.', ','));
            var nomeTitular = campos[3];

            var resultado = new ContaCorrente(agencia, numeroConta);
            var titular = new Cliente();
            titular.Nome = nomeTitular;

            resultado.Depositar(saldo);
            resultado.Titular = titular;



             return resultado;

        }
    }
 }
