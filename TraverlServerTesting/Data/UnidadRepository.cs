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
