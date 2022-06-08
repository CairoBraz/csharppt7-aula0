﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> idades = new Lista<int>();

            idades.Adicionar(5);
            idades.Adicionar(10);
            idades.AdicionarVarios(3, 4, 10, 23);

            int idadeSoma = 0;

            for (int i = 0; i < idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];
            }
            
            Console.WriteLine(SomarVarios(1, 2, 4, 5, 6));
            Console.WriteLine(SomarVarios(55, 10, 20, 99, 100));

            Console.ReadLine();

        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(15);

            listaDeIdades.AdicionarVarios(20, 25, 30);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade na posição {i}: {idade}");
            }

        }

        static void TestalistaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.MeuMetodo();
            lista.MeuMetodo(numeroQualquer: 25);

            ContaCorrente contaDoGui = new ContaCorrente(1111, 11111111);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(458, 898984),
                new ContaCorrente(654, 283928)
            };

            lista.AdicionarVarios(
                contaDoGui,
                new ContaCorrente(458, 898984),
                new ContaCorrente(654, 283928),
                new ContaCorrente(654, 283928)
                );

            lista.AdicionarVarios(contas);




            //ContaCorrente contaDoGui = new ContaCorrente(1111, 11111111);
            lista.Adicionar(contaDoGui);

            lista.Adicionar(new ContaCorrente(458, 898984));
            lista.Adicionar(new ContaCorrente(654, 283928));
            lista.Adicionar(new ContaCorrente(349, 890454));
            lista.Adicionar(new ContaCorrente(458, 898984));
            lista.Adicionar(new ContaCorrente(654, 283928));
            lista.Adicionar(new ContaCorrente(349, 890454));

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i}: Conta {itemAtual.Numero} e  Agência {itemAtual.Agencia}");
            }



            // e assim por diante


            lista.Remover(contaDoGui);

            Console.WriteLine("Após remover");
            Console.ReadLine();
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaArrayDeContasCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(789, 45612),
                new ContaCorrente(456, 12378),
                new ContaCorrente(123, 78945)
            };


            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"O número da conta de índice {indice} é {contaAtual.Numero}");

            }

            Console.ReadLine();
        }

        static void TestaArrayInt()
        {

            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28; //SE UM ÍNDICE NÃO FOR ATRIBUÍDO, ELE SERÁ PREENCHIDO COM O VALOR PADRÃO DO TIPO DO ARRAY.

            int idadeNoIndice4 = idades[4];

            Console.WriteLine(idades[4]);
            Console.WriteLine(idadeNoIndice4);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando a idade no índice {indice}");
                Console.WriteLine($"A idade no índice {indice} é {idade}.");

                acumulador += idades[indice];
            };

            Console.WriteLine("A média de idade é: " + (acumulador / idades.Length));

            Console.ReadLine();
        }
    }
}
