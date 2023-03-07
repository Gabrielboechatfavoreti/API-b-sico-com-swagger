using Microsoft.AspNetCore.Mvc;

namespace API_1._0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControllerFuncionarios: ControllerBase
    {
        List<Funcionarios> funcionario = new List<Funcionarios>
        {
            new Funcionarios {Nome= "joao",idade= 21,salario = 1000,departamento= "RH" },
            new Funcionarios {Nome= "Gabriel",idade= 32,salario = 2000,departamento= "OP" },
            new Funcionarios {Nome= "Daniel",idade= 35,salario = 3000,departamento= "RH" },
            new Funcionarios {Nome= "Bob",idade= 25,salario = 1000,departamento= "RH" }

        };

        [HttpGet("FuncionariosTodos")]

        public List<Funcionarios>GetFuncionarios()
        { 
            return funcionario;
        }
        [HttpGet("Departamento")]
        public List<Funcionarios> GetFuncionarios(string departamento )
        {
            return funcionario.Where(x => x.departamento == departamento).ToList();
        }

    }
}
