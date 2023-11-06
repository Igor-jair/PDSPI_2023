using Servico.Cadastros;
using Modelo.Carrinho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppProjeto2023.Controllers
{
    public class CarrinhosController : Controller
    {
        ProdutoServico produtoServico = new ProdutoServico();
        private void PopularViewBag()
        {

            ViewBag.ItemCarrinhoId = new
            SelectList(produtoServico.ObterProdutosClassificadosPorNome(),
            "ProdutoId", "Nome");

        }
        public ActionResult Create()
        {

            IEnumerable<ItemCarrinho> carrinho = HttpContext.Session["carrinho"] as IEnumerable<ItemCarrinho>;

            if (carrinho == null)
            {

                carrinho = new List<ItemCarrinho>();
                HttpContext.Session["carrinho"] = carrinho;

            }
            PopularViewBag();
            return View(carrinho);

        }
        public ActionResult AddProduto(FormCollection collection)
        {
            List<ItemCarrinho> carrinho = HttpContext.Session["carrinho"] as
            List<ItemCarrinho>;
            var produto2 = produtoServico.ObterProdutoPorId(
            Convert.ToInt32(collection.Get("ItemCarrinhoId")));
            var qtd = Convert.ToInt32(collection.Get("Quantidade"));
            var itemCarrinho = new ItemCarrinho()
            {
                Produto = produto2,
                Quantidade = qtd,
                ValorUnitario = 1
            };

            carrinho.Add(itemCarrinho);
            HttpContext.Session["carrinho"] = carrinho;
            return RedirectToAction("Create");
        }
    }
}