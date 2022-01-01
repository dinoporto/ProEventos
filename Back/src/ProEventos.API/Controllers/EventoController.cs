using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        private readonly DataContext contexto;

        public EventoController(DataContext contexto)
        {
            this.contexto = contexto;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return contexto.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {

            return contexto.Eventos.FirstOrDefault(e => e.EventoId == id);

        }

        [HttpPost]
        public string FakeInsert()
        {

            return "eu inseri o ódio.";

        }

        [HttpPut("{id}")]
        public string FakePut(int id)
        {

            return $"eu inseri o ódio com id = {id}";

        }

        [HttpDelete("{id}")]
        public string FakeDelete(int id)
        {

            return $"eu deletei o ódio com id = {id}";

        }
    }
}
