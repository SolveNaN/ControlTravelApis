using TraverlServerTesting.Models;

namespace TraverlServerTesting.Data
{
    public class UnidadRepository
    {

        private readonly List<Unidad> unidades = new List<Unidad>
        {



            // Hoteles (0 - 99)
            new Unidad
            {
                Id = 0,
                Nombre ="Hotel Boutique El Encanto",
                Descripcion1 = "Un hotel íntimo y acogedor con un toque de lujo y atención personalizada.",
                UrlImg1 = "https://destinoencanto.com/wp-content/uploads/2022/10/ATMOS-VISTA-ALTA-PISCINA.jpg",
                UrlImg2 = "https://cdn0.bodas.com.mx/vendor/3321/3_2/960/jpg/img-20170906-wa0056_5_173321_v1.jpeg",
                UrlImg3 = "https://cdn0.bodas.com.mx/vendor/3321/3_2/960/jpg/img-20170906-wa0056_5_173321_v1.jpeg",
                Tipo = "Hoteles",
                LinkFacebook="/lugar/",
                Costo="Ver Mas",
            },
            new Unidad
            {
                Id = 1,
                Nombre = "Gran Hotel Acacias",
                Descripcion1 = "Este hotel ofrece habitaciones cómodas con baño privado, TV satelital, aire acondicionado, escritorio y snacks. También cuenta con Wi-Fi en las habitaciones y áreas comunes",
                UrlImg1 = "https://livingandtravel.com.mx/wp-content/uploads/2018/02/Hotel-Boutique-Casa-Lisa-2-1.jpg",
                UrlImg2 = "https://media-cdn.tripadvisor.com/media/photo-s/06/41/c6/2c/hotel-rosa-da-ilha.jpg",
                UrlImg3 = "https://www.ferias.tur.br/thumbnailcli/11568/900/500/g_333.jpg",
                Tipo = "Hoteles",
                LinkFacebook="/lugar/",
                Costo = "Ver Mas",
            },
            new Unidad
            {
                Id = 2,
                Nombre = "Hotel Puerta del Sol",
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
                Id = 3,
                Nombre = "Hotel Mar Azul",
                Descripcion1 = "Hotel Mar Azul tiene jardín, salón de uso común, terraza y bar en Acacías. El hotel dispone de piscina cubierta, karaoke y club infantil." ,
                UrlImg1 = "https://cf2.bstatic.com/xdata/images/hotel/max1024x768/437972694.jpg?k=3450a8e6e1b07701a0dc96784a0f9cb4bdc0b2f665d183773ef109010c0114ee&o=&hp=1",
                UrlImg2 = "https://cf2.bstatic.com/xdata/images/hotel/max1024x768/542788299.jpg?k=51f41f737f28d82acdee495a8502aa9c433582e3a46d7fdc24ef88132ac5e865&o=&hp=1",
                UrlImg3 = "https://cf2.bstatic.com/xdata/images/hotel/max1024x768/542788135.jpg?k=9d8f43f513229baa5c5414a25e91c849df587d147797ef205649ed3e58928951&o=&hp=1",
                Ubicacion = "Vereda Centro, KL 2, Via Acacías - Guamal, Acacías, Meta",
                Tipo = "Hoteles",
                LinkFacebook = "/lugar/",
                Costo = "Ver Mas"
            },
            new Unidad
            {
                Id = 4,
                Nombre = "HOTEL EL NARANJO",
                Descripcion1 = "En el hotel, todas las habitaciones tienen aire acondicionado, escritorio, balcón con vistas a la ciudad, baño privado, TV de pantalla plana, ropa de cama y toallas. Todas las unidades disponen de caja fuerte." ,
                UrlImg1 = "https://cf2.bstatic.com/xdata/images/hotel/max1024x768/495125309.jpg?k=76ed5df444a60fb5b290d6a5d8d3462046a14a2bc396cd26f43d3b28344f562f&o=&hp=1",
                UrlImg2 = "https://cf2.bstatic.com/xdata/images/hotel/max1024x768/495125398.jpg?k=25a4149cfde3d341588643d73c68f994b02233f05a0f3a3289102f4fa8747ab7&o=&hp=1",
                UrlImg3 = "https://cf2.bstatic.com/xdata/images/hotel/max1024x768/511106036.jpg?k=ff6a9ef0182ee33728e375caaf2d2b4bf60071a54e368c49f2b1cca8c66c6065&o=&hp=1",
                Ubicacion = "2317 Diagonal 15, Acacías",
                Tipo = "Hoteles",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },
            new Unidad
            {
                Id = 5,
                Nombre = "Hotel Wayra Club",
                Descripcion1 = "Hotel Wayra Club tiene piscina al aire libre, jardín, salón de uso común y terraza en Acacías. Este hotel de 4 estrellas ofrece restaurante y tiene habitaciones con aire acondicionado, wifi gratis y baño privado." ,
                UrlImg1 = "https://cf2.bstatic.com/xdata/images/hotel/max1024x768/494186300.jpg?k=91a70e6b85e2e68520b1e410be42bfd8738b9b06a636822269f8050d5b6971aa&o=&hp=1",
                UrlImg2 = "https://cf2.bstatic.com/xdata/images/hotel/max1024x768/349309731.jpg?k=6c4689db969b3489354b0a05bc8b3eabf9cae8b95891a3abd042760c2735714d&o=&hp=1",
                UrlImg3 = "https://cf2.bstatic.com/xdata/images/hotel/max1024x768/589841907.jpg?k=db6e24c345b80a460037e2ebaa631a9cbabe20f3fc2bd2977d46fa35456dcad2&o=&hp=1",
                Ubicacion = "Diagonal 15 No. 21-10, Acacías",
                Tipo = "Hoteles",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },
            new Unidad
            {
                Id = 6,
                Nombre = "Cabaña Campestre Familiar-Malecon-Hospedaj llanero",
                Descripcion1  = "Las condiciones de cancelación y de pago por adelantado pueden variar según el tipo de alojamiento. Consulta las condiciones que puede tener cada opción cuando la elijas.",
                UrlImg1 = "https://q-xx.bstatic.com/xdata/images/hotel/max1024/593447490.jpg?k=a17ea814fc99760241e6167f4354e48b066e1d2ad3b4c93d3bac0087157fd4f9&o=",
                UrlImg2 = "https://q-xx.bstatic.com/xdata/images/hotel/max1024/593447507.jpg?k=d2d1988da0a78fe60ddf717f549b69930e3ed7adf53edc67febd63d32d615b40&o=",
                UrlImg3 = "https://q-xx.bstatic.com/xdata/images/hotel/max1024/593447499.jpg?k=679a2c6b68e4f74f40cbfbebb62401ef97b046d0adf3912d55d5f06433badb09&o=",
                Ubicacion = "Acacias 507009",
                Tipo = "Hoteles",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },
            new Unidad
            {
                Id = 7,
                Nombre = "Hotel Iraqúa",
                Descripcion1 = "restaurante del Hotel Iraqua sirve cocina local, y a 2 km encontrará otros locales de restauración." ,
                UrlImg1 = "https://cf2.bstatic.com/xdata/images/hotel/max1024x768/20588721.jpg?k=52ba35c19c2681439f9dcc081592fbe737b93067e7531d2f3a6828223f75a70c&o=&hp=1",
                UrlImg2 = "https://cf2.bstatic.com/xdata/images/hotel/max1024x768/20588884.jpg?k=b098f07c5a48bb2048dde4b0174b17a6e2b5b04039a06dfd2d6c977129f5f9fe&o=&hp=1",
                UrlImg3 = "https://cf2.bstatic.com/xdata/images/hotel/max1024x768/20588877.jpg?k=3cffacc75f450c48e77d573bf0cab4175a7e8b1476f0820dc60e72d9f2b7fdca&o=&hp=1",
                Ubicacion= "Carrera 23 No. 9 - 74, Acacías",
                Tipo = "Hoteles",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },



            // Restaurantes (100 - 199)
            new Unidad
            {
                Id = 100,
                Nombre = "Restaurante La Costa",
                Descripcion1 = "Deliciosos mariscos y un ambiente acogedor.",
                UrlImg1 = "https://emociom.com/img/ofertas/Principal/2023/05/3/12866_2023_may_17_11_26_51.jpg",
                UrlImg2 = "https://aloalobahia.com/images/p/orirestauranos_aloalobahia.jpg",
                UrlImg3 = "https://i.pinimg.com/originals/4b/cc/c0/4bccc084ec818a058b7a304093c4a28c.jpg",
                Tipo = "Restaurantes",
                LinkFacebook="/lugar/",
                Costo="Ver Mas",
            },
            new Unidad
            {
                Id = 101,
                Nombre = "Paz Cucina con Amore",
                Descripcion1 = "Un restaurante italiano en Villavicencio que ofrece una experiencia gastronómica única",
                UrlImg1 = "https://asset1.zankyou.com/images/wervice-card-big/7e4/bcd4/1050/800/w/874316/-/1642884238.jpg",
                UrlImg2 = "https://elranking.mx/wp-content/uploads/2022/04/restaurantes-La-Paz-Puebla.png",
                UrlImg3 = "https://cdn.lovesavingsgroup.com/logos/cucina-amore.png",
                Tipo = "Restaurantes",
                LinkFacebook="/lugar/",
                Costo="Ver Mas",
            },
            new Unidad
            {
                Id = 102,
                Nombre = "Asadero El Amarradero del Mico",
                Descripcion1 = "n lugar ideal para disfrutar de churrascos y comida latina en Villavicencio",
                UrlImg1 = "https://asset1.zankyou.com/images/wervice-card-big/7e4/bcd4/1050/800/w/874316/-/1642884238.jpg",
                UrlImg2 = "https://elranking.mx/wp-content/uploads/2022/04/restaurantes-La-Paz-Puebla.png",
                UrlImg3 = "https://cdn.lovesavingsgroup.com/logos/cucina-amore.png",
                Tipo = "Restaurantes",
                LinkFacebook="/lugar/",
                Costo="Ver Mas",
            },
            new Unidad
            {
                Id=103,
                Nombre="Restaurante Familiar Amparo",
                Descripcion1="Ofrecen una variedad de comida casera",
                Ubicacion="Calle 12, 16-85, Acacias, Meta",
                UrlImg1="https://grupopampas.com.mx/wp-content/uploads/elementor/thumbs/Restaurante-Familiar-pfj4qur2i53mj7iebez44rox3t4p91c2gdfihvlq5c.png",
                UrlImg2="https://www.seniorlivingguide.com/wp-content/uploads/2020/08/Oakmont-of-Segovia-Photo-Gallery.005.jpeg",
                UrlImg3="https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Normal/f942ab4d-a3a8-11e8-b2ca-0242ac110002.jpg",
                Tipo="Restaurantes",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },



            // Sitios_Religiosos (200 - 299)
            new Unidad
            {
                Id = 200,
                Nombre = "Parroquia Nuestra Señora del Carmen",
                Descripcion1 = "La Parroquia Nuestra Señora del Carmen es la iglesia principal de Acacías, Meta, conocida por su arquitectura y su ambiente acogedor. Un lugar emblemático donde se celebran eventos y ceremonias religiosas importantes para la comunidad.",
                UrlImg1 = "https://static.wixstatic.com/media/297902_3be38e394fd74c45b6a3565b89c8d3d3~mv2.jpg/v1/fill/w_636,h_477,al_c,q_80,usm_0.66_1.00_0.01,enc_auto/297902_3be38e394fd74c45b6a3565b89c8d3d3~mv2.jpg",
                UrlImg2 = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/08/b7/7c/27/iglesia-catedral-nuestra.jpg?w=1100&h=-1&s=1",
                UrlImg3 = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/08/b7/7c/12/iglesia-catedral-nuestra.jpg?w=1100&h=-1&s=1",
                Ubicacion ="Cra. 15 #13 27, Acacías, Meta",
                Tipo = "Sitios_Religiosos",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },
            new Unidad
            {
                Id = 201,
                Nombre = "Nuestra Señora de la Paz",
                Descripcion1 = "Nuestra Señora de la Paz es un tranquilo lugar de devoción en Acacías, Meta, ideal para la reflexión y la oración en un ambiente de paz y armonía.",
                UrlImg1 = "https://horariosmisa.co/wp-content/uploads/2023/12/unnamed-file-1616-jpg.webp",
                UrlImg2 = "https://horariomisa.co/wp-content/uploads/2023/12/Is5vS_nuestra-senora-de-la-paz-acacias-meta.jpg",
                UrlImg3 = "https://horariomisa.co/wp-content/uploads/2023/12/Is5vS_nuestra-senora-de-la-paz-acacias-meta.jpg",
                Ubicacion ="a 33-107, Cl. 16 #331, Acacías, Meta",
                Tipo = "Sitios_Religiosos",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },
            new Unidad
            {
                Id = 202,
                Nombre = "Iglesia Divino Niño",
                Descripcion1 = "La Iglesia Divino Niño es conocida por su cálida atmósfera y su belleza sencilla. Un lugar querido por los habitantes locales para la celebración de misas y oraciones.",
                UrlImg1 = "https://horariomisa.co/wp-content/uploads/2023/12/vj4op_iglesia-divino-nino-acacias-meta.jpg",
                UrlImg2 = "https://th.bing.com/th/id/OIP.KdlrEgZaogeatGYis_PdPAHaEK?rs=1&pid=ImgDetMain",
                UrlImg3 = "https://horariomisa.co/wp-content/uploads/2023/12/vj4op_iglesia-divino-nino-acacias-meta.jpg",
                Ubicacion ="a 17a-85, Cl. 9 #17a-1, Acacías, Meta",
                Tipo = "Sitios_Religiosos",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },



            // Centros_Entretenimiento (300 - 399)
            new Unidad
            {
                Id = 300,
                Nombre = "Centro Deportivo El Reino",
                Descripcion1 = "El Centro Deportivo El Reino ofrece modernas canchas sintéticas ideales para fútbol, además de un acogedor bar para relajarse después del juego. Es perfecto para amigos y familias que buscan un espacio de entretenimiento saludable y dinámico.",
                UrlImg1 = "centro-deportivo-el-reino-1.jpg",
                UrlImg2 = "centro-deportivo-el-reino-2.jpg",
                UrlImg3 = "centro-deportivo-el-reino-3.jpg",
                Ubicacion ="Cl. 17 #20-311 a 20-1, Acacías, Meta",
                Tipo = "Centros_Entretenimiento",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },
            new Unidad
            {
                Id = 301,
                Nombre = "Concha Acústica de Acacías",
                Descripcion1 = "La Concha Acústica de Acacías es un espacio deportivo y cultural que cuenta con un estadio pequeño de fútbol sala que también sirve para baloncesto, una cancha sintética, y una pista de patinaje. Ideal para eventos recreativos y culturales, es un popular punto de encuentro en Acacías.",
                UrlImg1 = "concha-acustica-de-acacias-1.jpg",
                UrlImg2 = "concha-acustica-de-acacias-2.jpg",
                UrlImg3 = "concha-acustica-de-acacias-3.jpg",
                Ubicacion = "65, Acacías, Meta",
                Tipo = "Centros_Entretenimiento",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },



            // Parques_Jardines (400 - 499)
            new Unidad
            {
                Id = 400,
                Nombre = "Parque Principal de Acacias",
                Descripcion1 = "Un lugar ideal para relajarse y disfrutar del entorno.",
                UrlImg1 = "https://upload.wikimedia.org/wikipedia/commons/2/25/Plaza_in_center_of_Acac%C3%ADas.jpg",
                UrlImg2 = "https://media-cdn.tripadvisor.com/media/photo-s/05/3c/b0/be/acacias.jpg",
                UrlImg3 = "https://blog.redbus.co/wp-content/uploads/2021/09/acacias-1536x1024.jpg",
                Tipo = "Parques_Jardines",
                Ubicacion = "a 14-113 Calle 14 #141, Cl. 14 #16-2, Acacías, Meta",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },
            new Unidad
            {
                Id = 401,
                Nombre = "Parque los Fundadores",
                Descripcion1 = "Un parque histórico con áreas verdes y actividades recreativas.",
                UrlImg1 = "https://ruta65.co/wp-content/uploads/2022/04/IMG_20220323_135357-scaled.jpg",
                UrlImg2 = "https://www.oscarpabon.com/wp-content/uploads/2021/10/Parque-Fundadores-vive.jpg",
                UrlImg3 = "https://ruta65.co/wp-content/uploads/2022/04/IMG_20220323_135428-1024x769.jpg",
                Tipo = "Parques_Jardines",
                Ubicacion = "Villavicencio, Meta",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },
            new Unidad
            {
                Id = 402,
                Nombre = "Parque las Malocas",
                Descripcion1 = "Un parque con espacios para deportes y actividades al aire libre.",
                UrlImg1 = "https://3.bp.blogspot.com/-hKIjOO0Db_I/WbagOfTGMQI/AAAAAAAAA1U/xc-I3Pr0VzAhNPAVsgY11fPK1AodVPfoQCLcBGAs/s1600/parque-malocas-vuelo-secreto.jpg",
                UrlImg2 = "https://www.viajaporcolombia.com/empresa/sitio-turistico/954/malocas-4.jpg",
                UrlImg3 = "https://secureservercdn.net/198.71.233.135/868.1cf.myftpupload.com/wp-content/uploads/2019/07/fullsizeoutput_277e-1-830x471.jpeg",
                Tipo = "Parques_Jardines",
                Ubicacion = "Cam. Ganadero, Villavicencio, Meta",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },
            new Unidad
            {
                Id = 403,
                Nombre = "Parque Nacional Natural Sierra de La Macarena",
                Descripcion1 = "Famoso por el Caño Cristales, un destino natural impresionante.",
                UrlImg1 = "https://i.ytimg.com/vi/mrnGb8WuyWw/maxresdefault.jpg",
                UrlImg2 = "https://cdn.colombia.com/sdi/2014/03/13/parque-nacional-natural-sierra-de-la-macarena-853790.jpg",
                UrlImg3 = "https://miviaje.com/wp-content/uploads/2020/01/paisaje-sierra-macarena-colombia-768x512.jpg",
                Tipo = "Parques_Jardines",
                Ubicacion = "Meta",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },



            // Monumentos (500 - 599)
            new Unidad
            {
                Id = 500,
                Nombre = "Monumentos de Villavicencio",
                Descripcion1 = "Incluye varios monumentos históricos y culturales.",
                UrlImg1 = "assets/images/monumentos-villavicencio.jpg",
                Tipo = "Monumentos",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },



            // Museos (600 - 699)
            new Unidad
            {
                Id = 600,
                Nombre = "Museo Arqueológico Guayupe",
                Descripcion1 = "Un museo que ofrece una visión de la historia y cultura local.",
                UrlImg1 = "assets/images/museo-guayupe.jpg",
                Tipo = "Museos",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },



            // Playas (700 - 799)
            new Unidad
            {
                Id = 700,
                Nombre = "Playa merecure",
                Descripcion1 = "Playa Merecure es un lugar paradisíaco de arena blanca y aguas cristalinas, ideal para disfrutar del sol y relajarse en un entorno natural tranquilo.",
                UrlImg1 = "",
                UrlImg2 = "https://images.evisos.com.co/2009/06/24/merecure-parque-agroecologico-plan-pasadia_85fb04fd6_3.jpg",
                UrlImg3 = "https://media-cdn.tripadvisor.com/media/photo-s/07/27/ba/18/playa.jpg",
                Ubicacion = "3Q8J+MX, La Porfia, Villavicencio, Meta",
                Tipo = "Playas",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },



            // Centros_Culturales (800 - 899)
            new Unidad
            {
                Id = 801,
                Nombre = "Resguardo Indígena Maguare",
                Descripcion1 = "",
                UrlImg1 = "https://plazacapital.co/images/contenidos/Maloca.png",
                UrlImg2 = "https://plazacapital.co/media/k2/items/cache/a2e1c2d21129c22da8981a4c7bfdede0_XL.jpg?t=1730302375",
                UrlImg3 = "https://static.wixstatic.com/media/a7501f_6183585b841045638abe64f6013140c6~mv2.jpg/v1/fill/w_750,h_500,al_c,q_90/a7501f_6183585b841045638abe64f6013140c6~mv2.jpg",
                Ubicacion = "Unnamed Road, Villavicencio, Meta",
                Tipo = "Centros_Culturales",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },



            //Otros
            new Unidad
            {
                Id = 102,
                Nombre = "Mirador Turístico de San Martín",
                Descripcion1 = "Ofrece vistas panorámicas impresionantes.",
                UrlImg1 = "assets/images/mirador-san-martin.jpg",
                Tipo = "Mirador",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },
            new Unidad
            {
                Id = 104,
                Nombre = "Mirador la Piedra del Amor",
                Descripcion1 = "Un mirador popular con vistas espectaculares.",
                UrlImg1 = "assets/images/mirador-piedra-amor.jpg",
                Tipo = "Mirador",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },
            new Unidad
            {
                Id = 109,
                Nombre = "Caño Cristales (Río de los Cinco Colores)",
                Descripcion1 = "Un impresionante río conocido por sus aguas multicolores.",
                UrlImg1 = "assets/images/cano-cristales.jpg",
                Tipo = "Río",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },
            new Unidad
            {
                Id = 110,
                Nombre = "Ruta Turística del Meta",
                Descripcion1 = "Una ruta que te lleva a varios destinos turísticos interesantes en la región.",
                UrlImg1 = "assets/images/ruta-turistica-meta.jpg",
                Tipo = "Ruta",
                LinkFacebook="/lugar/",
                Costo="Ver Mas"
            },

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
