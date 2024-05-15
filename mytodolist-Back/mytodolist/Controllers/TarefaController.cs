using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using mytodolist.Business;
using mytodolist.Data.DTO;
using mytodolist.Hypermedia.Filters;
using System.Collections.Generic;

namespace mytodolist.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("v{version:apiVersion}/api/tarefa")]
    public class TarefaController : ControllerBase
    {

        private readonly ILogger<TarefaController> _logger;
        private ITarefaBusiness _TarefaBusiness;

        public TarefaController(ILogger<TarefaController> logger, ITarefaBusiness TarefaBusiness)
        {
            _logger = logger;
            _TarefaBusiness = TarefaBusiness;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<TarefaDTO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult FindAll()
        {
            return Ok(_TarefaBusiness.FindAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(TarefaDTO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult FindById(long id)
        {
            var Tarefa = _TarefaBusiness.FindById(id);

            if (Tarefa == null) return NotFound();

            return Ok(Tarefa);
        }


        [HttpPost()]
        [ProducesResponseType(200, Type = typeof(TarefaDTO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult CreateTarefa([FromBody] TarefaDTO tarefa)
        {
            if (tarefa == null) return NotFound();

            return Ok(_TarefaBusiness.Create(tarefa));
        }

        [HttpPut()]
        [ProducesResponseType(200, Type = typeof(TarefaDTO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult UpdateTarefa([FromBody] TarefaDTO tarefa)
        {
            if (tarefa == null) return NotFound();

            return Ok(_TarefaBusiness.Update(tarefa));
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(200, Type = typeof(List<TarefaDTO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult ActiveTarefa(long id)
        {
            return Ok(_TarefaBusiness.AtivarTarefa(id));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult DeleteTarefa(long id)
        {
            _TarefaBusiness.Delete(id);
            return NoContent();
        }
    }
}