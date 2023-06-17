using Microsoft.AspNetCore.Mvc;
using ProyectoBamby.Services.Interface;
using ProyectoBamby.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoBamby.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaServicio _marcaServicio;
        public MarcaController(IMarcaServicio nombreServicio)
        {
            this._marcaServicio = nombreServicio;
        }
        // GET: api/<MarcaController>
        [HttpGet]
        public async Task<IEnumerable<Marca>> Get()
        {
            return await this._marcaServicio.GetMarcas();
        }

        // GET api/<MarcaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MarcaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MarcaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MarcaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
