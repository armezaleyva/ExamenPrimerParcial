using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial {
    class Program {
        static void Main(string[] args) {
            Ingrediente sup = new Ingrediente();
            sup.Nombre = "xddd";
            sup.Identificador = "AAAAA";
            Console.WriteLine(sup.Identificador);
            Console.WriteLine(sup.Nombre);
            Platillo plato = new Platillo();
            plato.Nombre = "salami";
            plato.Identificador = "fasgf";
            plato.Precio = 75f;
            plato.Ingredientes.Add(sup);
            plato.Descripcion = "fasfas";
            Console.WriteLine(plato.Nombre);
            Console.WriteLine(plato.Identificador);
            Console.WriteLine(plato.Descripcion);
            Console.WriteLine(plato.Precio);
            Console.WriteLine(plato.Ingredientes[0].Identificador);

            Menu menu = new Menu();
            Console.WriteLine("nombremenu" + menu.Nombre);
            menu.Platillos.Add(plato);
            Console.WriteLine(menu.Platillos[0].Nombre);
            Console.WriteLine(menu.Platillos[0].Ingredientes[0].Identificador);
            Console.ReadKey();
        }
    }
}
