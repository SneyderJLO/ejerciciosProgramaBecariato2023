using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "En un soleado día de verano," +
                " las aves cantaban alegremente en los árboles cercanos," +
                " mientras que las flores desplegaban sus vibrantes colores en el jardín." +
                " Los niños jugaban en el parque, riendo y corriendo, mientras que las familias" +
                " disfrutaban de un relajante picnic bajo la sombra." +
                " Un anciano paseaba con su perro por el camino empedrado," +
                " saludando a los vecinos con una sonrisa amistosa. De repente," +
                " una brisa fresca sopló suavemente, llevándose consigo" +
                " el cálido aroma de las flores. El cielo azul se extendía " +
                "infinitamente, decorado con esponjosas nubes blancas. " +
                "¿Qué mejor manera de pasar un día maravilloso que estar " +
                "rodeado de la belleza y la alegría de la naturaleza?";

            string[] fuente = texto.Split(new char[] { '.', ',', '?', '¿', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string buscar = "un";
            var consultaPalabras = from palabra in fuente
                                   where palabra.ToLowerInvariant() == buscar.ToLowerInvariant()
                                   select palabra;

            foreach (var item in consultaPalabras)
            {
                Console.WriteLine(item);
            }
            int contadorPalabra = consultaPalabras.Count();
            Console.WriteLine(contadorPalabra);

        }
    }
}
