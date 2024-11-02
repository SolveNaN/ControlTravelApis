using DocumentFormat.OpenXml.Office2010.Excel;
using TraverlServerTesting.Models;

namespace TraverlServerTesting.Data
{
    public class CategoriaRepository
    {
        private readonly List<Categoria> categorias = new List<Categoria>
        {


            // Categorías para la unidad 1 (Restaurante La Costa)
            new Categoria
            {
                Id = 1,
                UnidadId = 1,
                Nombre = "Platos (Dishes)",
                Tipo = "Platos",
                UrlImg1 = "assets/images/la-costa-platos.jpg"
            },
            new Categoria
            {
                Id = 2,
                UnidadId = 1,
                Nombre = "Postres (Desserts)",
                Tipo = "Postres",
                UrlImg1 = "assets/images/la-costa-postres.jpg"
            },
            new Categoria
            {
                Id = 3,
                UnidadId = 1,
                Nombre = "Bebidas (Beverages)",
                Tipo = "Bebidas",
                UrlImg1 = "assets/images/la-costa-bebidas.jpg"
            },



            // Categorías para la unidad 2 (Hotel Boutique El Encanto)
            new Categoria
            {
                Id = 4,
                UnidadId = 2,
                Nombre = "Habitaciones Deluxe",
                Tipo = "Alojamiento",
                UrlImg1 = "assets/images/hotel-boutique-el-encanto-deluxe.jpg"
            },
            new Categoria
            {
                Id = 5,
                UnidadId = 2,
                Nombre = "Servicio de Spa",
                Tipo = "Bienestar",
                UrlImg1 = "assets/images/hotel-boutique-el-encanto-spa.jpg"
            },
            new Categoria
            {
                Id = 500,
                UnidadId = 503,
                Nombre = "Canchas Sintéticas",
                Tipo = "Instalaciones",
                UrlImg1 = "centro-deportivo-el-reino-canchas.jpg"
            },
            new Categoria
            {
                Id = 501,
                UnidadId = 503,
                Nombre = "Bar y Área de Descanso",
                Tipo = "Servicios",
                UrlImg1 = "centro-deportivo-el-reino-bar.jpg"
            },



            // Museos (600 - 699)
            new Categoria
            {
                Id = 600,
                UnidadId = 600,
                Nombre = "Exposiciones y Recorridos",
                Tipo = "Cultura y Historia",
                Descripcion1 = "Exploración de las exposiciones permanentes y recorridos guiados para entender la historia Guayupe.",
            },
            new Categoria
            {
                Id = 601,
                UnidadId = 600,
                Nombre = "Actividades Educativas",
                Tipo = "Educación",
                Descripcion1 = "Talleres y presentaciones audiovisuales que fomentan el aprendizaje interactivo de la cultura Guayupe.",
            },



            // Playas (700 - 799)
            new Categoria
            {
                Id = 700,
                UnidadId = 700,
                Nombre = "Deportes Acuáticos",
                Tipo = "Recreación",
                Descripcion1 = "Actividades como kayak, paddleboard y buceo para disfrutar de las aguas cristalinas de la playa.",
                UrlImg1 = "https://cdn.thursosurf.com/wp-content/uploads/2020/10/26094921/Thurso-Surf-Blog-Stand-Up-Paddle-Traction-Pad-How-to-Choose-the-Right-One-couple-paddles-in-SUP-kayaks-1.jpg",
                UrlImg2 = "https://blog.marti.mx/wp-content/uploads/2023/01/razones-para-probar-kayak-720x480.webp",
                UrlImg3 = "https://santamartatrip.com/sites/default/files/cocoon/kayak-tour-chicas.jpeg"
            },
            new Categoria
            {
                Id = 701,
                UnidadId = 700,
                Nombre = "Relajación y Bienestar",
                Tipo = "Turismo",
                Descripcion1 = "Espacios de descanso, masajes frente al mar y zonas de spa para relajarse en la playa.",
                UrlImg1 = "https://media.istockphoto.com/id/490937016/es/foto/paquete-de-spa-de-cortes%C3%ADa-en-la-parte-superior-del-malo.jpg?s=612x612&w=0&k=20&c=jpc4AzT5kTBnNCpHtYRErKM5pQQ7tVd5F-A_mNzmiis=",
                UrlImg2 = "https://www.arenarena.com/wp-content/uploads/2024/07/449695337_1683204655750462_4035830687506700320_n.jpg",
                UrlImg3 = "https://www.revista-ballesol.com/wp-content/uploads/2023/07/mujer-relajada-disfrutando-mar-1-1068x712.jpg"
            },



            // Centros_Culturales (800 - 899)
            new Categoria
            {
                Id = 800,
                UnidadId = 801,
                Nombre = "Arte y Cultura Indígena",
                Tipo = "Cultural",
                Descripcion1 = "Exposiciones de arte tradicional, rituales y talleres de artesanía para conocer la cultura indígena Maguare.",
                UrlImg1 = "https://cultura.gov.py/wp-content/uploads/2012/03/Madre-Cuzque%C3%B1a.-Juan-de-la-Cruz-Machicado.jpg",
                UrlImg2 = "https://i0.wp.com/ladiligencialibros.com/wp-content/uploads/2022/04/Algunas-paginas-interiores_Boca-de-maguare-1-min.jpg?fit=900%2C900&ssl=1",
                UrlImg3 = "https://maguared.gov.co/wp-content/uploads/2016/07/maritza_diaz3.jpg"
            },
            new Categoria
            {
                Id = 801,
                UnidadId = 801,
                Nombre = "Naturaleza y Espiritualidad",
                Tipo = "Turismo",
                Descripcion1 = "Actividades al aire libre y ceremonias espirituales en conexión con la naturaleza.",
                UrlImg1 = "https://miputumayo.com.co/wp-content/uploads/2014/11/IMAGEN-14811002-2.png-1.jpg",
                UrlImg2 = "https://freight.cargo.site/t/original/i/25469a497f0cbf5a12f4e9997efbe639b6943bec5b12faaabe6c7d3117596ecc/Poster-2de066bf2f-poster.jpg",
                UrlImg3 = "https://freight.cargo.site/t/original/i/1ad98a6080e7ecda9cf729355c5a4f0cc62728cf6d52dc68dae0611d18909d80/Photo-1-Yuri_still_1.jpg"
            },



        };

        // Leer todas las categorías
        public List<Categoria> GetAllCategorias()
        {
            return categorias;
        }

        // Obtener categorías por ID de unidad (filtrar por unidad)
        public List<Categoria> GetCategoriasByUnidadId(int unidadId)
        {
            return categorias.Where(c => c.UnidadId == unidadId).ToList();
        }

        // Crear nueva categoría
        public void AddCategoria(Categoria nuevaCategoria)
        {
            categorias.Add(nuevaCategoria);
        }

        // Obtener categoría por ID
        public Categoria GetCategoriaById(int id)
        {
            return categorias.FirstOrDefault(c => c.Id == id);
        }

        // Eliminar categoría
        public bool DeleteCategoria(int id)
        {
            var categoria = GetCategoriaById(id);
            if (categoria != null)
            {
                categorias.Remove(categoria);
                return true;
            }
            return false;
        }
    }
}
