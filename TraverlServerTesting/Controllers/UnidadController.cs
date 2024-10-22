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
        private readonly ApplicationDbContext _context;

        public UnidadController(ApplicationDbContext context)
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
        public async Task<ActionResult<List<Unidad>>> GetEjemplos()
        {

            var lista = new List<Unidad>
            {
                new Unidad
    {
                    Id = 1,
        Titulo = "Parque Principal de Acacias",
        Descripcion1 = "Un lugar ideal para relajarse y disfrutar del entorno.",
        UrlImg1 = "assets/images/parque-principal-acacias.jpg",
        Tipo = "Parque"
    },
    new Unidad
    {
         Id = 2,
        Titulo = "Mirador Turístico de San Martín",
        Descripcion1 = "Ofrece vistas panorámicas impresionantes.",
        UrlImg1 = "assets/images/mirador-san-martin.jpg",
        Tipo = "Mirador"
    },
    new Unidad
    {
         Id = 3,
        Titulo = "Parque los Fundadores",
        Descripcion1 = "Un parque histórico con áreas verdes y actividades recreativas.",
        UrlImg1 = "assets/images/parque-los-fundadores.jpg",
        Tipo = "Parque"
    },
    new Unidad
    {
         Id = 4,
        Titulo = "Mirador la Piedra del Amor",
        Descripcion1 = "Un mirador popular con vistas espectaculares.",
        UrlImg1 = "assets/images/mirador-piedra-amor.jpg",
        Tipo = "Mirador"
    },
    new Unidad
    {
         Id = 5,
        Titulo = "Parque las Malocas",
        Descripcion1 = "Un parque con espacios para deportes y actividades al aire libre.",
        UrlImg1 = "assets/images/parque-las-malocas.jpg",
        Tipo = "Parque"
    },
    new Unidad
    {
        Id = 6,
        Titulo = "Monumentos de Villavicencio",
        Descripcion1 = "Incluye varios monumentos históricos y culturales.",
        UrlImg1 = "assets/images/monumentos-villavicencio.jpg",
        Tipo = "Monumento"
    },
    new Unidad
    {
        Id = 7,
        Titulo = "Museo Arqueológico Guayupe",
        Descripcion1 = "Un museo que ofrece una visión de la historia y cultura local.",
        UrlImg1 = "assets/images/museo-guayupe.jpg",
        Tipo = "Museo"
    },
    new Unidad
    {
        Id = 8,
        Titulo = "Parque Nacional Natural Sierra de La Macarena",
        Descripcion1 = "Famoso por el Caño Cristales, un destino natural impresionante.",
        UrlImg1 = "assets/images/parque-sierra-macarena.jpg",
        Tipo = "Parque Nacional"
    },
    new Unidad
    {
        Id = 9,
        Titulo = "Caño Cristales (Río de los Cinco Colores)",
        Descripcion1 = "Un impresionante río conocido por sus aguas multicolores.",
        UrlImg1 = "assets/images/cano-cristales.jpg",
        Tipo = "Río"
    },
    new Unidad
    {
        Id = 10,
        Titulo = "Ruta Turística del Meta",
        Descripcion1 = "Una ruta que te lleva a varios destinos turísticos interesantes en la región.",
        UrlImg1 = "assets/images/ruta-turistica-meta.jpg",
        Tipo = "Ruta"
    },
    new Unidad
    {
        Id = 11,
        Titulo = "Gran Hotel Acacias",
        Descripcion1 = "Este hotel ofrece habitaciones cómodas con baño privado, TV satelital, aire acondicionado, escritorio y snacks. También cuenta con Wi-Fi en las habitaciones y áreas comunes",
        UrlImg1 = "assets/images/ruta-turistica-meta.jpg",
        Tipo = "Hoteles"
    }
            };
            return Ok(lista);

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
