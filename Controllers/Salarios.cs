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
            new Funcionarios {Nome= "Bob",idade= 25,salario = 5000,departamento= "RH" }

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
        [HttpGet("SalarioMaior")]
        public Funcionarios GetFuncionarios1()
        {
            int salarioM = 0;
            int posicao=0;

            for (var i = 0; i < funcionario.Count; i++)
            {
                if (i == 0) 
                {
                    salarioM=funcionario[i].salario;
                    posicao = i;
                }
                else if (salarioM < funcionario[i].salario) 
                {
                    salarioM = funcionario[i].salario;             
                    posicao=i;
                }
                
            }
            return funcionario[posicao];
        }
        [HttpGet("SalarioMenor")]

        public Funcionarios GetFuncionarios5()
        {
            int salarioMenor = 0;
            int posicao = 0;

            for (var i = 0; i > funcionario.Count; i++)
            {
                if(i==0)
                {
                    salarioMenor = funcionario[i].salario;
                    posicao = i;
                }
                else if (salarioMenor < funcionario[i].salario)
                {
                    salarioMenor = funcionario[i].salario;
                    posicao = i;
                }

               
            }
            return funcionario[posicao];
        }












    }
}
