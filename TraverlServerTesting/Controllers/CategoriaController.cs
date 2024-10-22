using Microsoft.AspNetCore.Mvc;
using TraverlServerTesting.Data;
using TraverlServerTesting.Models;

namespace TraverlServerTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly CategoriaRepository categoriaRepository = new CategoriaRepository();


        // Obtener todas las categorías
        [HttpGet("Listado")]
        public ActionResult<List<Categoria>> GetCategorias()
        {
            return Ok(categoriaRepository.GetAllCategorias());
        }


        // Obtener las categorías de una unidad
        [HttpGet("ListadoPorUnidad/{unidadId}")]
        public async Task<ActionResult<List<Categoria>>> GetCategoriasByUnidad(int unidadId)
        {
            var categorias = categoriaRepository.GetCategoriasByUnidadId(unidadId);
            if (categorias == null || categorias.Count == 0)
            {
                return NotFound("No se encontraron categorías para esta unidad.");
            }

            return Ok(categorias);
        }


        // Consultar una categoría
        [HttpGet]
        [Route("Consultar/{id}")]
        public async Task<ActionResult<Categoria>> GetCategoriaById(int id)
        {
            var categoria = categoriaRepository.GetCategoriaById(id);
            if (categoria == null)
            {
                return NotFound("No se encontró la categoría.");
            }

            return Ok(categoria);
        }


        // Crear una nueva categoría
        [HttpPost("Crear")]
        public async Task<ActionResult<string>> CreateCategoria(Categoria categoria)
        {
            categoriaRepository.AddCategoria(categoria);
            return Ok("Categoría creada con éxito.");
        }


        // Eliminar una categoría
        [HttpDelete]
        [Route("Eliminar/{id}")]
        public async Task<ActionResult<string>> DeleteCategoria(int id)
        {
            var categoriaDb = categoriaRepository.GetCategoriaById(id);
            if (categoriaDb == null)
            {
                return NotFound("Categoría no encontrada.");
            }

            categoriaRepository.DeleteCategoria(id);
            return Ok("Categoría eliminada correctamente.");
        }
    }
}
