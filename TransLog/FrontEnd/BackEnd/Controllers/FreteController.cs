using BackEnd.Models.Request;
using BackEnd.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class FreteController : ControllerBase
    {
        [HttpGet]
        [Route("obterFrete")]
        public IActionResult ObterFrete([FromQuery] Freterequest freterequest)
        {
            try
            {                        
                var altura = freterequest.Altura;
                var comprimento = freterequest.Comprimento;
                var largura = freterequest.Largura;
                var distancia = freterequest.Distancia;
                var peso = freterequest.Peso;

                var response = new FreteResponse();
              

                var valorDoFrete = (distancia * 0.50) +(peso * 1) + (largura * altura * 2 *comprimento);

                response.FreteTotal = valorDoFrete; 
                return Ok(response.FreteTotal);
            }
            catch (Exception ex)
            {
                throw;
            }
          
        }
       
    }
}
