﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVenta.DTO;

namespace SistemadeVenta.DLL.Servicios.Contrato
{
   public interface ICategoriaService
    {
        Task<List<CategoriaDTO>> Lista();
    }
}
