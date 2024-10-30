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
