using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        public static void TesteGenerico<T2>(this string texto)
        {

        }


        static void Teste()
        {
            List<int> idades = new List<int>();
            idades.Add(4);
            idades.Add(5);

            //ListExtensoes<int>.AdicionarVarios(idades, 2, 3, 4, 5);
            idades.AdicionarVarios(6, 7, 8, 9);

            List<string> fruta = new List<string>();
            fruta.Add("arroz");
            fruta.Add("pão");

            //ListExtensoes<string>.AdicionarVarios(fruta, "banana", "laranja");

            fruta.AdicionarVarios("uva", "Melância");


        }
    }
}
