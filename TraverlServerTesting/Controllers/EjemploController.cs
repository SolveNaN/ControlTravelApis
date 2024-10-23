using TraverlServerTesting.Data;
using TraverlServerTesting.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ControWellServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EjemploController(ApplicationDbContext context)
        {

            _context = context;
        }
        //Estado de conexion con el servidor
        [HttpGet]
        [Route("ConexionServidor")]
        public async Task<ActionResult<string>> GetConexionServidor()
        {
            return Ok("Conectado");
        }
        //Estados de conexion con la tabla de la base de datos
        [HttpGet]
        [Route("ConexionDB")]
        public async Task<ActionResult<string>> GetConexionDB()
        {
            try
            {
                var usuarios = await _context.Ejemplos.ToListAsync();
                return Ok("Buena Calidad");

            }
            catch (Exception ex)
            {
                return BadRequest("Mala calidad");
            }
        }
        //Aqui comienza el CRUD
        [HttpGet("Listado")]
        public async Task<ActionResult<List<Ejemplo>>> GetEjemplos()
        {
            var lista = await _context.Ejemplos.ToListAsync();
            return Ok(lista);
        }

        [HttpGet]
        [Route("ListadoTipos")]
        public async Task<ActionResult<List<string>>> GetTipos()
        {
            try
            {
                var clasificacion = new List<string>
                {
                    "Hoteles", "Restaurantes","Museos","Monumentos","Parques y Jardines","Playas y Zonas Costeras","Centros Culturales","Reservas Naturales y Parques Nacionales",
                    "Centros de Esparcimiento y Entretenimiento","Sitios Religiosos","Parqueadero", "Transporte","Clima"
                };
                return Ok(clasificacion);

            }
            catch (Exception ex)
            {
                return BadRequest("Mala calidad");
            }
        }

        [HttpGet]
        [Route("CategoriaHotel")]
        public async Task<ActionResult<List<string>>> GetCategoriaHotel()
        {
            try
            {
                var clasificacion = new List<string>
                    {"Habitación Individual (Single Room)", "Habitación Doble (Double Room)", "Habitación Twin (Twin Room)", "Habitación Triple (Triple Room)",
                    "Habitación Cuádruple (Quad Room)", "Suite", "Junior Suite", "Suite Presidencial", "Habitación Deluxe",
                    "Habitación Ejecutiva", "Habitación Familiar", "Habitación de Conexión (Connecting Room)", "Habitación Accesible",
                    "Habitación de Lujo (Luxury Room)", "Habitación con Vista (View Room)"};
                return Ok(clasificacion);

            }
            catch (Exception ex)
            {
                return BadRequest("Mala calidad");
            }
        }
        [HttpGet]
        [Route("CategoriaRestaurante")]
        public async Task<ActionResult<List<string>>> GetCategoriaRestaurante()
        {
            try
            {
                var clasificacion = new List<string>
                    {"Entrantes (Appetizers)", "Sopas (Soups)", "Ensaladas (Salads)", "Platos Fuertes (Main Courses)", "Guarniciones (Side Dishes)", "Postres (Desserts)",
                    "Bebidas (Beverages)", "Licores (Liquors)", "Bebidas Calientes (Hot Beverages)", "Bebidas Frías (Cold Beverages)", "Aperitivos (Snacks)", "Tapas (Small Plates)",
                    "Mariscos (Seafood)", "Carnes (Meat Dishes)", "Pasta y Arroces (Pasta and Rice)",
                    "Vegetarianos (Vegetarian Dishes)", "Veganos (Vegan Dishes)"};
                return Ok(clasificacion);

            }
            catch (Exception ex)
            {
                return BadRequest("Mala calidad");
            }
        }

        [HttpGet]
        [Route("ConsutarId/{id}")]
        public async Task<ActionResult<List<Ejemplo>>> GetSingleEjemplo(int id)
        {
            var miobjeto = await _context.Ejemplos.FirstOrDefaultAsync(ob => ob.Id == id);
            if (miobjeto == null)
            {
                return NotFound(" :/");
            }

            return Ok(miobjeto);
        }

        [HttpPost("Crear")]
        public async Task<ActionResult<string>> CreateEjemplo(Ejemplo objeto)
        {
            try
            {
                _context.Ejemplos.Add(objeto);
                await _context.SaveChangesAsync();
                return Ok("Creado con éxio");
            }
            catch (Exception ex)
            {
                return BadRequest("Error durante el proceso de almacenamiento");
            }

        }
        [HttpPost("AgregarListado")]
        public async Task<ActionResult<string>> AgregarListadoTanque(List<Ejemplo> listado)
        {
            try
            {
                foreach (var item in listado)
                {
                    var miobjeto = await _context.Ejemplos.FirstOrDefaultAsync(ob => ob.Nombre == item.Nombre);
                    if (miobjeto == null)
                    {
                        _context.Ejemplos.Add(item);
                        await _context.SaveChangesAsync();
                    }
                }
                return Ok("Creado con éxio");
            }
            catch (Exception ex)
            {
                return BadRequest("Error durante el proceso de almacenamiento");
            }
        }
        [HttpPut("Actualizar/{id}")]
        public async Task<ActionResult<List<Ejemplo>>> UpdateEjemplo(Ejemplo objeto)
        {

            var DbObjeto = await _context.Ejemplos.FindAsync(objeto.Id);
            if (DbObjeto == null)
                return BadRequest("no se encuentra");
            //DbObjeto.Nombre = objeto.Nombre;
            await _context.SaveChangesAsync();
            return Ok(await _context.Ejemplos.ToListAsync());
        }


        [HttpDelete]
        [Route("Eliminar/{id}")]
        public async Task<ActionResult<string>> DeleteEjemplo(int id)
        {
            var DbObjeto = await _context.Ejemplos.FirstOrDefaultAsync(Ob => Ob.Id == id);
            if (DbObjeto == null)
            {
                return NotFound("no existe :/");
            }

            try
            {
                _context.Ejemplos.Remove(DbObjeto);
                await _context.SaveChangesAsync();

                return Ok("Eliminado correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest("No fué posible eliminar el objeto");
            }

        }
    }
}
