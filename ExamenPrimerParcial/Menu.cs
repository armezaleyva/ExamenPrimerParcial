using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial {
    class Menu {
        public string Nombre { get; set; }
        public string Identificador { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }
        public List<Platillo> Platillos { get; set; }

        public Menu() {
            Nombre = "Nuevo menú";
            Platillos = new List<Platillo>();
        }
    }
}
