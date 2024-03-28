using BackEnd.Models.Response;
using BackEnd.Request;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FreteController : ControllerBase
    {
        [HttpGet]
        [Route("freteObter")]
        public IActionResult ObterCarteirinha([FromQuery] FreteRequest request)
        {
            try 
            {
                var altura = request.Altura;
                var largura = request.Largura;
                var comprimento = request.Comprimento;
                var distancia = request.Distancia;
                var peso = request.Peso;

                double custoTotal = (distancia * 0.5)+(peso * 1) + (comprimento * largura * altura * 2.0);
                var response = new FreteResponse();

                response.CustoFrete = custoTotal;
                return Ok(response.CustoFrete);
                
            }
            catch (Exception ex) 
            {
                throw;
            }
            
        }

       
    }
}
