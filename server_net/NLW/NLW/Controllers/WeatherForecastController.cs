using Microsoft.AspNetCore.Mvc;

namespace NLW.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        public class Anuncio
        {
            public int id { get; set; }
            public string name { get; set; }
        }



        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult<List<Anuncio>> Get()
        {
            var anuncios = new List<Anuncio>();

            anuncios.Add(new Anuncio() { id = 1, name = "Anuncio 1" });
            anuncios.Add(new Anuncio() { id = 2, name = "Anuncio 2" });
            anuncios.Add(new Anuncio() { id = 3, name = "Anuncio 3" });

            return Ok(anuncios);
        }
    }
}