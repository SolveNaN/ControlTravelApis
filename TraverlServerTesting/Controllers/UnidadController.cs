using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraverlServerTesting.Data;
using TraverlServerTesting.Models;
using Microsoft.EntityFrameworkCore;

namespace TraverlServerTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadController : ControllerBase
    {
        private readonly UnidadRepository unidadRepository = new UnidadRepository();


        // Obtener todas las unidades
        [HttpGet("Listado")]
        public ActionResult<List<Unidad>> GetUnidades()
        {
            return Ok(unidadRepository.GetAllUnidades());
        }


        // Consultar una unidad
        [HttpGet]
        [Route("Consultar/{id}")]
        public async Task<ActionResult<Unidad>> GetUnidadById(int id)
        {
            var unidad = unidadRepository.GetUnidadById(id);
            if (unidad == null)
            {
                return NotFound("No se encontró la unidad.");
            }

            return Ok(unidad);
        }


        // Crear una nueva unidad
        [HttpPost("Crear")]
        public async Task<ActionResult<string>> CreateUnidad(Unidad unidad)
        {
            unidadRepository.AddUnidad(unidad);
            return Ok("Unidad creada con éxito.");
        }


        // Eliminar una unidad
        [HttpDelete]
        [Route("Eliminar/{id}")]
        public async Task<ActionResult<string>> DeleteUnidad(int id)
        {
            var unidadDb = unidadRepository.GetUnidadById(id);
            if (unidadDb == null)
            {
                return NotFound("Unidad no encontrada.");
            }

            unidadRepository.DeleteUnidad(id);
            return Ok("Unidad eliminada correctamente.");
        }
    }
}
