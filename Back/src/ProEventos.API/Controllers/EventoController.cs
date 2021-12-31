using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
       
      IEnumerable<Evento>  _eventos = new Evento[]{ new Evento(){EventoId=1,
                                              Local="Salvador",
                                              DataEvento="2022-01-01",
                                              Tema="Ano Novo",
                                              qtdPessoas=1000,
                                              Lote="123",
                                              ImagemURL=""
                                            },
                                      new Evento(){EventoId=2,
                                                Local="Lauro de Freitas",
                                                DataEvento="2022-01-01",
                                                Tema="Ano Novo dos velhos",
                                                qtdPessoas=500,
                                                Lote="1",
                                                ImagemURL=""
                                            }
                                            
                                };

        public EventoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            
            return _eventos;

        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            
            return _eventos.Where(e => e.EventoId == id);

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
