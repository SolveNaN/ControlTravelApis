using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraverlServerTesting.Data;
using TraverlServerTesting.Models;
using Microsoft.EntityFrameworkCore;
namespace TraverlServerTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ServicioController(ApplicationDbContext context)
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
        //Aqui comienza el CRUD
        [HttpGet("ListadoServicios")]
        public async Task<ActionResult<List<Servicio>>> GetServicios()
        {
            var lista = new List<Servicio>()
            {
                new Servicio {
                    Id = 1,
                    Nombre="Atesanias La esquina",
                    Descripcion1 ="Recuerdos para todos",
                    UnidadId=1,

                },
                new Servicio {
                    Id = 2,
                    Nombre="Piezas arqueológicas",
                    Descripcion1 =" Incluye urnas y vasijas con formas humanas y animales, así como trazos geométricos",
                    UnidadId=7,
                },
                new Servicio {
                    Id = 3,
                    Nombre="Exposiciones permanentes",
                    Descripcion1 ="Relatan la historia y cultura de la etnia indígena Guayupe",
                    UnidadId=7,
                },
                new Servicio {
                    Id = 4,
                    Nombre="Recorridos guiados",
                    Descripcion1 ="Ofrecen una visión detallada de las piezas y su contexto histórico",
                    UnidadId=7,
                },
                new Servicio {
                    Id = 5,
                    Nombre="Sala de audiovisuales",
                    Descripcion1 =" Presenta videos y presentaciones interactivas sobre la cultura Guayupe",
                    UnidadId=7,
                },
                new Servicio {
                    Id = 6,
                    Nombre="Talleres educativos",
                    Descripcion1 =" Actividades para niños y adultos que fomentan el aprendizaje sobre la historia local",
                    UnidadId=7,
                },
                new Servicio {
                    Id = 7,
                    Nombre="Caño Cristales",
                    Descripcion1 ="Conocido como el río de los cinco colores, ofrece vistas impresionantes con sus aguas multicolores",
                    UnidadId=8,
                },
                new Servicio {
                    Id = 8,
                    Nombre="Senderismo",
                    Descripcion1 ="Varias rutas de senderismo que permiten explorar la exuberante naturaleza del parque",
                    UnidadId=8,
                },
                new Servicio {
                    Id = 9,
                    Nombre="Observación de aves",
                    Descripcion1 ="Un paraíso para los observadores de aves, con una gran variedad de especies endémicas y migratorias",
                    UnidadId=8,
                },
                new Servicio {
                    Id = 10,
                    Nombre="Cascadas y lagunas",
                    Descripcion1 ="Diversas cascadas y lagunas que son perfectas para disfrutar de la naturaleza y tomar fotos",
                    UnidadId=8,
                },
                new Servicio {
                    Id = 11,
                    Nombre="Ecoturismo",
                    Descripcion1 =" Actividades como el baño pasivo y recreativo, interpretación del patrimonio arqueológico y fotografía de la flora y fauna",
                    UnidadId=8,
                },
                new Servicio {
                    Id = 12,
                    Nombre="Habitación Doble",
                    Descripcion1 ="Una habitación con una cama doble, ideal para parejas.",
                    UnidadId=8,
                },
                new Servicio {
                    Id = 13,
                    Nombre="Habitación Triple",
                    Descripcion1 ="Una habitación con una cama doble y una cama extra, perfecta para tres personas.",
                    UnidadId=8,
                },
                new Servicio {
                    Id = 14,
                    Nombre="Habitación Familiar",
                    Descripcion1 ="Una habitación más grande con una cama doble y una o más camas adicionales, adecuada para familias.",
                    UnidadId=8,
                },
                new Servicio {
                    Id = 15,
                    Nombre="Suite Presidencial",
                    Descripcion1 ="Una suite lujosa con mayores comodidades, incluyendo un área de estar y baño más grande.",
                    UnidadId=8,
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
