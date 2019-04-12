using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TreinamentoCSharp.Dominio;
using TreinamentoCSharp.Infra;

namespace TreinamentoCSharp.Controllers
{
    [Route("api/sala")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        private readonly Contexto _contexto;

        public SalaController(Contexto contexto)
        {
            this._contexto = contexto;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Sala> salas = this._contexto.Sala.ToList();

            if (salas.Count == 0)
                return NotFound();
                
            return Ok(salas);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
