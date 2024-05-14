using Microsoft.AspNetCore.Mvc;
using mytodolist.Business;
using mytodolist.Data.DTO;
using System.Collections.Generic;

namespace mytodolist.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("v{version:apiVersion}/api/Tarefa")]
    public class TarefaController : ControllerBase
    {

        private readonly ILogger<TarefaController> _logger;

        public TarefaController(ILogger<TarefaController> logger, ITarefaBusiness TarefaBusiness)
        {
            _logger = logger;
            _TarefaBusiness = TarefaBusiness;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<ListaTarefaDTO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult FindAll()
        {
            return Ok(_TarefaBusiness.FindAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(ListaTarefaDTO))]
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


        [HttpGet("{sortDirection}/{pageSize}/{currentPage}")]
        [ProducesResponseType(200, Type = typeof(PagedSearchVO<ListaTarefaDTO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult FindByPagedSearch([FromQuery] string name, string sortDirection, int pageSize, int currentPage)
        {
            return Ok(_TarefaBusiness.FindWithPagedSearch(name, sortDirection, pageSize, currentPage));
        }

        [HttpPost()]
        [ProducesResponseType(200, Type = typeof(ListaTarefaDTO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult CreateTarefa([FromBody] ListaTarefaDTO Tarefa)
        {
            if (Tarefa == null) return NotFound();

            return Ok(_TarefaBusiness.Create(Tarefa));
        }

        [HttpPut()]
        [ProducesResponseType(200, Type = typeof(ListaTarefaDTO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult UpdateTarefa([FromBody] ListaTarefaDTO Tarefa)
        {
            if (Tarefa == null) return NotFound();

            return Ok(_TarefaBusiness.Update(Tarefa));
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(200, Type = typeof(List<ListaTarefaDTO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult ActiveTarefa(long id)
        {
            return Ok(_TarefaBusiness.ActiveUser(id));
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