﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SistemadeVenta.DLL.Servicios.Contrato;
using SistemaVenta.DTO;
using SistemaVenta.DAL.Repositorios.Contrato;
using SistemaVenta.Model;
using Microsoft.EntityFrameworkCore;

namespace SistemadeVenta.DLL.Servicios
{
    public class CategoriaService:ICategoriaService
    {
        private readonly IGenericRepository<Categoria> _categoriaRepositorio;

        private readonly IMapper _mapper;

        public CategoriaService(IGenericRepository<Categoria> categoriaRepositorio, IMapper mapper)
        {
            _categoriaRepositorio = categoriaRepositorio;
            _mapper = mapper;
        }

        public async Task<List<CategoriaDTO>> Lista()
        {
            try 
            {
                var listaCategorias = await _categoriaRepositorio.Consultar();
                return _mapper.Map<List<CategoriaDTO>>(listaCategorias.ToList());
            }
            catch
            {
                throw;
            }
        }
    }
}
