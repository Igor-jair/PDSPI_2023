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
        public IOrderedQueryable<Fabricante> fabricantes;
        public IOrderedQueryable<Categoria> categorias;
        public IOrderedQueryable<Produto> produtos;
        public string filtro;
    }
}