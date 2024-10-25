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
                Nombre = "Restaurante La Costa",
                Descripcion1 = "Deliciosos mariscos y un ambiente acogedor.",
                UrlImg1 = "https://emociom.com/img/ofertas/Principal/2023/05/3/12866_2023_may_17_11_26_51.jpg",
                UrlImg2 = "https://aloalobahia.com/images/p/orirestauranos_aloalobahia.jpg",
                UrlImg3 = "https://i.pinimg.com/originals/4b/cc/c0/4bccc084ec818a058b7a304093c4a28c.jpg",
                Tipo = "Restaurantes",
                Costo="Ver",
                LinkFacebook="/lugar/"
            },
            new Unidad
            {
                Id = 2,
                Nombre = "Paz Cucina con Amore",
                Descripcion1 = "Un restaurante italiano en Villavicencio que ofrece una experiencia gastronómica única",
                UrlImg1 = "https://asset1.zankyou.com/images/wervice-card-big/7e4/bcd4/1050/800/w/874316/-/1642884238.jpg",
                UrlImg2 = "https://elranking.mx/wp-content/uploads/2022/04/restaurantes-La-Paz-Puebla.png",
                UrlImg3 = "https://cdn.lovesavingsgroup.com/logos/cucina-amore.png",
                Tipo = "Restaurantes",
                Costo="Ver"
            },
            new Unidad
            {
                Id = 4,
                Nombre = "Asadero El Amarradero del Mico",
                Descripcion1 = "n lugar ideal para disfrutar de churrascos y comida latina en Villavicencio",
                UrlImg1 = "https://asset1.zankyou.com/images/wervice-card-big/7e4/bcd4/1050/800/w/874316/-/1642884238.jpg",
                UrlImg2 = "https://elranking.mx/wp-content/uploads/2022/04/restaurantes-La-Paz-Puebla.png",
                UrlImg3 = "https://cdn.lovesavingsgroup.com/logos/cucina-amore.png",
                Tipo = "Restaurantes"
            },
            new Unidad
            {
                Id = 5,
                Titulo = "Hotel Boutique El Encanto",
                Nombre ="Hotel Boutique El Encanto",
                Descripcion1 = "Un hotel íntimo y acogedor con un toque de lujo y atención personalizada.",
                UrlImg1 = "https://destinoencanto.com/wp-content/uploads/2022/10/ATMOS-VISTA-ALTA-PISCINA.jpg",
                UrlImg2 = "https://cdn0.bodas.com.mx/vendor/3321/3_2/960/jpg/img-20170906-wa0056_5_173321_v1.jpeg",
                UrlImg3 = "https://cdn0.bodas.com.mx/vendor/3321/3_2/960/jpg/img-20170906-wa0056_5_173321_v1.jpeg",
                Tipo = "Hoteles",
                Costo="Ver Mas"
            },
            new Unidad
    {
                    Id = 101,
        Titulo = "Parque Principal de Acacias",
        Descripcion1 = "Un lugar ideal para relajarse y disfrutar del entorno.",
        UrlImg1 = "https://upload.wikimedia.org/wikipedia/commons/2/25/Plaza_in_center_of_Acac%C3%ADas.jpg",
        Tipo = "Parques y Jardines"
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
        Nombre="Gran Hotel Acacias",
        Descripcion1 = "Este hotel ofrece habitaciones cómodas con baño privado, TV satelital, aire acondicionado, escritorio y snacks. También cuenta con Wi-Fi en las habitaciones y áreas comunes",
        UrlImg1 = "https://livingandtravel.com.mx/wp-content/uploads/2018/02/Hotel-Boutique-Casa-Lisa-2-1.jpg",
        UrlImg2 = "https://media-cdn.tripadvisor.com/media/photo-s/06/41/c6/2c/hotel-rosa-da-ilha.jpg",
        UrlImg3 = "https://www.ferias.tur.br/thumbnailcli/11568/900/500/g_333.jpg",
        Tipo = "Hoteles",
        Costo="Ver Mas"
    },
    new Unidad
    {
        Id=112,
        Nombre="Hotel Puerta del Sol",
        SubTitulo="Subtitulo",
        Descripcion1= "Descripion detallada del hotel",
        Descripcion2 = "descripcion 2",
        Ubicacion=" Calle Ejemplo 123, Ciudad, País",
        UrlImg1 = "https://media-cdn.tripadvisor.com/media/vr-splice-j/06/19/c0/e5.jpg",        
        UrlImg2 = "https://media-cdn.tripadvisor.com/media/photo-s/08/f7/42/d9/pool.jpg",        
        UrlImg3 = "https://media-cdn.tripadvisor.com/media/photo-s/08/d3/5b/c9/hotel-maya-tulipanes.jpg",        
        Correo = "info@hotelpuertdelsol.com",
        Telefono = "+57 322 783 3578",
         Tipo = "Hoteles",
          LinkFacebook="/lugar/",
          Costo="Ver Mas"
    },
    new Unidad
    {
        Id=113,
        Nombre="Restaurante Familiar Amparo",
        Descripcion1="Ofrecen una variedad de comida casera",
        Ubicacion="Calle 12, 16-85, Acacias, Meta",
        UrlImg1="https://grupopampas.com.mx/wp-content/uploads/elementor/thumbs/Restaurante-Familiar-pfj4qur2i53mj7iebez44rox3t4p91c2gdfihvlq5c.png",
        UrlImg2="https://www.seniorlivingguide.com/wp-content/uploads/2020/08/Oakmont-of-Segovia-Photo-Gallery.005.jpeg",
        UrlImg3="https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Normal/f942ab4d-a3a8-11e8-b2ca-0242ac110002.jpg",
        Tipo="Restaurantes"
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
