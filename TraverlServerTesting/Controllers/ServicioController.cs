using Microsoft.AspNetCore.Mvc;
using TraverlServerTesting.Data;
using TraverlServerTesting.Models;
namespace TraverlServerTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        private readonly ServicioRepository servicioRepository = new ServicioRepository();


        // Obtener todos los servicios
        [HttpGet("Listado")]
        public ActionResult<List<Servicio>> GetServicios()
        {
            return Ok(servicioRepository.GetAllServicios());
        }


        // Obtener los servicios de una Unidad
        [HttpGet]
        [Route("ListadoPorUnidad/{unidadId}")]
        public ActionResult<List<Servicio>> GetServiciosByUnidad(int unidadId)
        {
            var servicios = servicioRepository.GetServiciosByUnidadId(unidadId);
            if (servicios == null || !servicios.Any())
            {
                return NotFound($"No se encontraron servicios para la unidad con ID {unidadId}.");
            }

            return Ok(servicios);
        }


        // Obtener los servicios de una Categoria
        [HttpGet]
        [Route("ListadoPorCategoria/{categoriaId}")]
        public ActionResult<List<Servicio>> GetServiciosByCategoria(int categoriaId)
        {
            var servicios = servicioRepository.GetServiciosByCategoriaId(categoriaId);
            if (servicios == null || !servicios.Any())
            {
                return NotFound($"No se encontraron servicios para la categoria con ID {categoriaId}.");
            }

            return Ok(servicios);
        }


        // Consultar un servicio
        [HttpGet]
        [Route("Consultar/{id}")]
        public ActionResult<Servicio> GetServicioById(int id) 
        {
            var servicio = servicioRepository.GetServicioById(id);
            if (servicio == null)
            {
                return NotFound("Servicio no encontrado.");
            }

            return Ok(servicio);
        }


        // Crear un nuevo servicio
        [HttpPost("Crear")]
        public ActionResult<string> CreateServicio(Servicio servicio)
        {
            servicioRepository.AddServicio(servicio);
            return Ok("Servicio creado con éxito.");
        }


        // Eliminar un servicio
        [HttpDelete]
        [Route("Eliminar/{id}")]
        public ActionResult<string> DeleteServicio(int id)
        {
            var servicio = servicioRepository.GetServicioById(id);
            if (servicio == null)
            {
                return NotFound("Servicio no encontrado.");
            }

            servicioRepository.DeleteServicio(id);
            return Ok("Servicio eliminado correctamente.");
        }
    }
}
