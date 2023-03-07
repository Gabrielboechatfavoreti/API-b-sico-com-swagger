using Microsoft.AspNetCore.Mvc;

namespace API_1._0.Controllers
{
    [ApiController]
    [Route("[controller]")]


    public class PrediosController : ControllerBase
    {
        List<Predios> predios1 = new List<Predios>
        {
          new Predios {nomedopredio = "predio1",andares = 13},

          new Predios {nomedopredio = "predio2",andares = 12},

          new Predios {nomedopredio = "predio3",andares = 15},

          new Predios {nomedopredio = "predio4",andares = 14},

        };

        [HttpGet("PrediosBase")]

        public List<Predios> GetPredios()
        {
            return predios1;    
        }




    }
}
