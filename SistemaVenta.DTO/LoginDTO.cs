﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.DTO
{//NOS PERMITE RECIBIR LAS CREDENCIALES
    public class LoginDTO
    {
        public string Correo { get; set; }
        public string Clave { get; set; }
    }
}
