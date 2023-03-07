using Microsoft.AspNetCore.Mvc;

namespace API_1._0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        List<Pessoa> pessoas = new List<Pessoa>
        {
            new Pessoa { Nome = "João", Idade = 24, Sexo = "Masculino"},
            
            new Pessoa{ Nome = "Joninha", Idade = 24, Sexo ="Feminino"},
            
            new Pessoa{ Nome = "Gabriel", Idade = 25, Sexo ="Masculino"}
        };

        [HttpGet("Pessoas")]
        public List<Pessoa> GetPessoas()
        {
            return pessoas;
        }

        [HttpGet("Primeiro-nome")]
        public Pessoa GetPessoaMyname(string nome)
        {
            return pessoas.FirstOrDefault(x => x.Nome == nome);

        }

    }
}