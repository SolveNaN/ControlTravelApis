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
            }



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
