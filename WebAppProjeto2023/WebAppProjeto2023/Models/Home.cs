using Modelo.Cadastros;
using Modelo.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProjeto2023.Models
{
    public class Home
    {
        public IQueryable<Fabricante> fabricantes;
        public IQueryable<Categoria> categorias;
        public IQueryable<Produto> produtos;
        public string filtro;

    }
}