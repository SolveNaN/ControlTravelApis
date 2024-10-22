using TraverlServerTesting.Models;

namespace TraverlServerTesting.Data
{
    public class ServicioRepository
    {
        private readonly List<Servicio> servicios = new List<Servicio>
    {


            // Servicios para la unidad 1 (Restaurante La Costa)
            new Servicio
            {
                Id = 1,
                Nombre = "Tacos de Pescado",
                Descripcion1 = "Deliciosos tacos de pescado fresco, acompañados de salsa de mango.",
                UnidadId = 1,
                CategoriaId = 1 // Platos
            },
            new Servicio
            {
                Id = 2,
                Nombre = "Ensalada César",
                Descripcion1 = "Ensalada fresca con lechuga romana, crutones y aderezo César.",
                UnidadId = 1,
                CategoriaId = 1 // Platos
            },
            new Servicio
            {
                Id = 5,
                Nombre = "Tarta de Queso",
                Descripcion1 = "Tarta de queso suave con base de galleta y mermelada de frutos rojos.",
                UnidadId = 1,
                CategoriaId = 2 // Postres
            },
            new Servicio
            {
                Id = 6,
                Nombre = "Helado Artesanal",
                Descripcion1 = "Helado hecho en casa con sabores variados, incluyendo vainilla y chocolate.",
                UnidadId = 1,
                CategoriaId = 2 // Postres
            },
            new Servicio
            {
                Id = 8,
                Nombre = "Margarita",
                Descripcion1 = "Refrescante bebida de tequila con limón y sal en el borde.",
                UnidadId = 1,
                CategoriaId = 3 // Bebidas
            },
            new Servicio
            {
                Id = 9,
                Nombre = "Limonada Natural",
                Descripcion1 = "Limonada fresca hecha con limones naturales y un toque de menta.",
                UnidadId = 1,
                CategoriaId = 3 // Bebidas
            },



            // Servicios para la unidad 2 (Hotel Boutique El Encanto)
            new Servicio
            {
                Id = 1,
                Nombre = "Servicio de Limpieza Diario",
                Descripcion1 = "Limpieza de la habitación y cambio de sábanas todos los días.",
                CategoriaId = 4 // Alojamiento
            },
            new Servicio
            {
                Id = 2,
                Nombre = "Servicio a la Habitación",
                Descripcion1 = "Comida y bebidas entregadas directamente a su habitación.",
                CategoriaId = 4 // Alojamiento
            },
            new Servicio
            {
                Id = 3,
                Nombre = "Masaje Relajante",
                Descripcion1 = "Disfrute de un masaje relajante para aliviar el estrés.",
                CategoriaId = 5 // Bienestar
            },
            new Servicio
            {
                Id = 4,
                Nombre = "Tratamiento Facial",
                Descripcion1 = "Servicio de cuidado facial para rejuvenecer la piel.",
                CategoriaId = 5 // Bienestar
            }


    };

        // Obtener todos los servicios
        public List<Servicio> GetAllServicios()
        {
            return servicios;
        }

        // Obtener servicios por UnidadId
        public List<Servicio> GetServiciosByUnidadId(int unidadId)
        {
            return servicios.Where(s => s.UnidadId == unidadId).ToList();
        }

        // Obtener servicios por CategoriaId
        public List<Servicio> GetServiciosByCategoriaId(int categoriaId)
        {
            return servicios.Where(s => s.CategoriaId == categoriaId).ToList();
        }

        // Crear nuevo servicio
        public void AddServicio(Servicio nuevoServicio)
        {
            servicios.Add(nuevoServicio);
        }

        // Obtener servicio por ID
        public Servicio GetServicioById(int id)
        {
            return servicios.FirstOrDefault(s => s.Id == id);
        }

        // Eliminar servicio
        public bool DeleteServicio(int id)
        {
            var servicio = GetServicioById(id);
            if (servicio != null)
            {
                servicios.Remove(servicio);
                return true;
            }
            return false;
        }
    }
}
