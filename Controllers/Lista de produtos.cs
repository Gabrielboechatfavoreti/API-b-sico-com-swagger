using Microsoft.AspNetCore.Mvc;

namespace API_1._0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListaDeProdutos: ControllerBase
    {
        List<Produtos> produtos = new List<Produtos>
        {
            new Produtos {produto = "Leite Italac", Codigo= 1,valor= 4.5 },

            new Produtos { produto= "Leite Selita",Codigo=  2, valor= 5.0},

            new Produtos { produto= "Leite do bibi",Codigo=  3, valor= 100.0},
            
            new Produtos { produto= "Carne",Codigo=  5, valor= 30.0},


        };

        [HttpGet("produtos")]
        public List<Produtos> GetProdutos()
        {
            return produtos;
        }
        [HttpGet("SomenteLeite")]
        public List<Produtos> GetLeite(string produto)
        {
            return produtos.Where(x => x.produto.Contains(produto)).ToList();
        }


    }
}
