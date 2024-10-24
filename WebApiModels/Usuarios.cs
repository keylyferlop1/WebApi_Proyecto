using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiModels
{
    public class Usuarios
    {
        public int ID_Usuario { get; set; }
        public string Usuario { get; set; }
        public string clave { get; set; }
        public string Rol { get; set; }
        public bool Estado { get; set; }
    }
}
