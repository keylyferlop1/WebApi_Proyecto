﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 

namespace WebApiModels
{
    public class Productos
    {
        public int ID_Producto {  get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set;}
    }
}
