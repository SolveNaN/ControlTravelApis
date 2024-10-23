using TraverlServerTesting.Models;

namespace TraverlServerTesting.Data
{
    public class UnidadRepository
    {

        private readonly List<Unidad> unidades = new List<Unidad>
        {
            new Unidad
            {
                Id = 1,
                Titulo = "Restaurante La Costa",
                Descripcion1 = "Deliciosos mariscos y un ambiente acogedor.",
                UrlImg1 = "assets/images/restaurante-la-costa.jpg",
                Tipo = "Restaurantes"
            },
            new Unidad
            {
                Id = 2,
                Titulo = "Hotel Boutique El Encanto",
                Descripcion1 = "Un hotel íntimo y acogedor con un toque de lujo y atención personalizada.",
                UrlImg1 = "assets/images/hotel-boutique-el-encanto.jpg",
                Tipo = "Hoteles"
            },
            new Unidad
    {
                    Id = 101,
        Titulo = "Parque Principal de Acacias",
        Descripcion1 = "Un lugar ideal para relajarse y disfrutar del entorno.",
        UrlImg1 = "assets/images/parque-principal-acacias.jpg",
        Tipo = "Parque"
    },
    new Unidad
    {
         Id = 102,
        Titulo = "Mirador Turístico de San Martín",
        Descripcion1 = "Ofrece vistas panorámicas impresionantes.",
        UrlImg1 = "assets/images/mirador-san-martin.jpg",
        Tipo = "Mirador"
    },
    new Unidad
    {
         Id = 103,
        Titulo = "Parque los Fundadores",
        Descripcion1 = "Un parque histórico con áreas verdes y actividades recreativas.",
        UrlImg1 = "assets/images/parque-los-fundadores.jpg",
        Tipo = "Parque"
    },
    new Unidad
    {
         Id = 104,
        Titulo = "Mirador la Piedra del Amor",
        Descripcion1 = "Un mirador popular con vistas espectaculares.",
        UrlImg1 = "assets/images/mirador-piedra-amor.jpg",
        Tipo = "Mirador"
    },
    new Unidad
    {
         Id = 105,
        Titulo = "Parque las Malocas",
        Descripcion1 = "Un parque con espacios para deportes y actividades al aire libre.",
        UrlImg1 = "assets/images/parque-las-malocas.jpg",
        Tipo = "Parque"
    },
    new Unidad
    {
        Id = 106,
        Titulo = "Monumentos de Villavicencio",
        Descripcion1 = "Incluye varios monumentos históricos y culturales.",
        UrlImg1 = "assets/images/monumentos-villavicencio.jpg",
        Tipo = "Monumento"
    },
    new Unidad
    {
        Id = 107,
        Titulo = "Museo Arqueológico Guayupe",
        Descripcion1 = "Un museo que ofrece una visión de la historia y cultura local.",
        UrlImg1 = "assets/images/museo-guayupe.jpg",
        Tipo = "Museo"
    },
    new Unidad
    {
        Id = 108,
        Titulo = "Parque Nacional Natural Sierra de La Macarena",
        Descripcion1 = "Famoso por el Caño Cristales, un destino natural impresionante.",
        UrlImg1 = "assets/images/parque-sierra-macarena.jpg",
        Tipo = "Parque Nacional"
    },
    new Unidad
    {
        Id = 109,
        Titulo = "Caño Cristales (Río de los Cinco Colores)",
        Descripcion1 = "Un impresionante río conocido por sus aguas multicolores.",
        UrlImg1 = "assets/images/cano-cristales.jpg",
        Tipo = "Río"
    },
    new Unidad
    {
        Id = 110,
        Titulo = "Ruta Turística del Meta",
        Descripcion1 = "Una ruta que te lleva a varios destinos turísticos interesantes en la región.",
        UrlImg1 = "assets/images/ruta-turistica-meta.jpg",
        Tipo = "Ruta"
    },
    new Unidad
    {
        Id = 111,
        Titulo = "Gran Hotel Acacias",
        Descripcion1 = "Este hotel ofrece habitaciones cómodas con baño privado, TV satelital, aire acondicionado, escritorio y snacks. También cuenta con Wi-Fi en las habitaciones y áreas comunes",
        UrlImg1 = "assets/images/ruta-turistica-meta.jpg",
        Tipo = "Hoteles"
    }
        };

        // Leer
        public List<Unidad> GetAllUnidades()
        {
            return unidades;
        }

        // Crear
        public void AddUnidad(Unidad nuevaUnidad)
        {
            unidades.Add(nuevaUnidad);
        }

        public Unidad GetUnidadById(int id)
        {
            return unidades.FirstOrDefault(u => u.Id == id);
        }

        // Eliminar
        public bool DeleteUnidad(int id)
        {
            var unidad = GetUnidadById(id);
            if (unidad != null)
            {
                unidades.Remove(unidad);
                return true;
            }
            return false;
        }

    }
}
