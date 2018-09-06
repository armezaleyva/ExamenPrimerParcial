using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial {
    class Platillo {
        public string Nombre { get; set; }
        public string Identificador { get; set; }
        public string Descripcion { get; set; }

        private float _precio;
        public float Precio {
            get {
                return _precio;
            }
            set {
                if (value < 50) {
                    _precio = 50;
                }
                else {
                    _precio = value;
                }
            }
        }
        public List<Ingrediente> Ingredientes { get; set; }

        public Platillo() {
            Ingredientes = new List<Ingrediente>();
        }
    }
}
