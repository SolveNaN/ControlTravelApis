using TraverlServerTesting.Models;

namespace TraverlServerTesting.Data
{
    public class ServicioRepository
    {
        private readonly List<Servicio> servicios = new List<Servicio>
    {



            //Hoteles (0 - 99)
            // Hotel 0
            new Servicio {
                Id = 0,
                Nombre="Habitación Doble",
                Descripcion1 ="Una habitación con una cama doble, ideal para parejas.",
                UnidadId=0,
                Valor="Ver Mas"
            },
            new Servicio {
                Id = 1,
                Nombre="Habitación Triple",
                Descripcion1 ="Una habitación con una cama doble y una cama extra, perfecta para tres personas.",
                UnidadId=0,
                Valor="Ver Mas"
            },
            // Hotel 1
            new Servicio {
                Id = 2,
                Nombre="Habitación Familiar",
                Descripcion1 ="Una habitación más grande con una cama doble y una o más camas adicionales, adecuada para familias.",
                UnidadId=1,
                Valor="Ver Mas"
            },
            new Servicio {
                Id = 3,
                Nombre="Suite Presidencial",
                Descripcion1 ="Una suite lujosa con mayores comodidades, incluyendo un área de estar y baño más grande.",
                UnidadId=1,
                Valor="Ver Mas"
            },
            // Hotel 2
            new Servicio {
                Id=4,
                Nombre="Habitación Estándar",
                Titulo="Habitacion 1 ",
                SubTitulo="Habitación Estándar",
                Descripcion1="La Habitación Estándar ofrece un ambiente acogedor y funcional. Equipadas con una cama matrimonial o dos camas individuales, estas habitaciones son ideales para viajeros solos o en pareja.",
                Descripcion2="Disponen de un escritorio de trabajo, televisión de pantalla plana y baño privado con artículos de tocador. La decoración es moderna y minimalista, creando un espacio perfecto para descansar después de un día de exploración.",
                UrlImg1 = "https://www.sofitelbarucalablanca.com/wp-content/uploads/sites/19/2023/04/DUF_8644-v-ok-1170x780.jpg",
                UrlImg2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQx3zfiM5DnlrdwBBfChNElnjFiv9aL5Yy9fVrkpSL6MVLT1moZGoFzdyDquP7Rmy2QwE&usqp=CAU",
                UrlImg3 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRMs3LrlUpZAv2XdgDHxNGyANOhJ9H-xm99wledrq7STBxqxyJ1qesuyERD27qMo6DuWKs&usqp=CAU",
                Valor="Ver Mas",
                UnidadId=2
            },
            new Servicio {
                Id=5,
                Nombre="Habitacion Familiar",
                Titulo="Habitacion Familiar ",
                SubTitulo="Habitación Estándar",
                Descripcion1="La Habitación Estándar ofrece un ambiente acogedor y funcional. Equipadas con una cama matrimonial o dos camas individuales, estas habitaciones son ideales para viajeros solos o en pareja.",
                Descripcion2="Disponen de un escritorio de trabajo, televisión de pantalla plana y baño privado con artículos de tocador. La decoración es moderna y minimalista, creando un espacio perfecto para descansar después de un día de exploración.",
                UrlImg1 = "https://www.servicedapartments.co.in/image/serviced-apartments-dubai/dhs013-1-bedroom-apartment-with-pool-downtown/8.jpg",
                UrlImg2 = "https://stat.ameba.jp/user_images/20190721/14/ochie1/7f/52/j/o3264183614508633128.jpg",
                UrlImg3 = "https://i.travelapi.com/lodging/9000000/8830000/8828700/8828677/a28243bb_z.jpg",
                Valor="Ver Mas",
                UnidadId=2
            },



            // Restaurantes (100 - 199)
            // Restaurante 100
            new Servicio
            {
                Id = 100,
                Nombre = "Tacos de Pescado",
                Descripcion1 = "Deliciosos tacos de pescado fresco, acompañados de salsa de mango.",
                UnidadId = 100,
                UrlImg1 = "https://th.bing.com/th/id/OIP.k7WlLUu_yR4v82RLFe13iQHaFj?rs=1&pid=ImgDetMain",
                UrlImg2 = "https://th.bing.com/th/id/R.938772792075070ec6388913e20e78cf?rik=0RiIRTZ4CgOykA&pid=ImgRaw&r=0",
                UrlImg3 = "https://assets.unileversolutions.com/recipes-v2/243872.jpg",
                Valor = "Ver Mas"
            },
            new Servicio
            {
                Id = 101,
                Nombre = "Ensalada César",
                Descripcion1 = "Ensalada fresca con lechuga romana, crutones y aderezo César.",
                UrlImg1 = "https://recetasdepollo.online/wp-content/uploads/2017/09/ensalada-cesar-con-pollo.jpg",
                UrlImg2 = "https://noro.mx/wp-content/uploads/2021/07/ensalada-cesar-origen.jpg",
                UrlImg3 = "https://www.tuiris.com/wp-content/uploads/2017/04/ensalada-caesar.jpg",
                Valor = "Ver Mas",
                UnidadId = 100,
            },
            // Restaurante 101
            new Servicio
            {
                Id = 102,
                Nombre = "Tarta de Queso",
                Descripcion1 = "Tarta de queso suave con base de galleta y mermelada de frutos rojos.",
                UrlImg1 = "https://www.annarecetasfaciles.com/files/tarta-de-queso-de-la-vina.jpg",
                UrlImg2 = "https://alpina.com/media/mageplaza/blog/post/t/a/tarta-de-queso-preparala-con-estos-sencillos-trucos.jpg",
                UrlImg3 = "https://s.libertaddigital.com/2021/12/30/1920/1080/fit/tarta-de-queso-cuarc-crema.jpg",
                Valor = "Ver Mas",
                UnidadId = 101,
            },
            new Servicio
            {
                Id = 102,
                Nombre = "Helado Artesanal",
                Descripcion1 = "Helado hecho en casa con sabores variados, incluyendo vainilla y chocolate.",
                UrlImg1 = "https://www.rionegro.com.ar/wp-content/uploads/binrepository/image_content_10201161_20181012090146.jpg",
                UrlImg2 = "https://img.freepik.com/fotos-premium/helado-casero-chocolate-vainilla_202873-2527.jpg",
                UrlImg3 = "https://www.comedera.com/wp-content/uploads/2022/05/Helado-de-vainilla-sin-azucar.jpg",
                Valor = "Ver Mas",
                UnidadId = 101,

            },
            // Restaurante 102
            new Servicio
            {
                Id = 103,
                Nombre = "Margarita",
                Descripcion1 = "Refrescante bebida de tequila con limón y sal en el borde.",
                UrlImg1 = "https://th.bing.com/th/id/R.b957e147649130d9ba8119a74485e6b6?rik=Kzcnf2LO0%2bqFvg&pid=ImgRaw&r=0",
                UrlImg2 = "https://www.finedininglovers.com/es/sites/g/files/xknfdk1706/files/styles/recipes_1200_800_fallback/public/2023-03/margarita%C2%A9iStock.jpg?itok=Ir0T3tYT",
                UrlImg3 = "https://elmatadorrestaurant.com/wp-content/uploads/2020/07/House-Margarita-1.jpg",
                UnidadId = 102,
                Valor="Ver Mas"
            },
            // Restaurante 103
            new Servicio
            {
                Id = 104,
                Nombre = "Limonada Natural",
                Descripcion1 = "Limonada fresca hecha con limones naturales y un toque de menta.",
                UnidadId = 102,
                UrlImg1 = "https://www.clarin.com/img/2018/11/22/irNt-ISOZ_720x0__1.jpg",
                UrlImg2 = "https://www.pequerecetas.com/wp-content/uploads/2021/05/limonada-como-se-hace.jpg",
                UrlImg3 = "https://i.pinimg.com/originals/c0/a9/0c/c0a90c866a4460ff02ad44954f8cf1e4.jpg",
                Valor="Ver Mas"
            },



            // Monumentos (500 - 599)




            // Museos (600 - 699)
            // Museo 600
            new Servicio {
                Id = 601,
                Nombre="Exposiciones permanentes",
                Descripcion1 ="Relatan la historia y cultura de la etnia indígena Guayupe",
                UnidadId=600,
            },
            new Servicio {
                Id = 602,
                Nombre="Recorridos guiados",
                Descripcion1 ="Ofrecen una visión detallada de las piezas y su contexto histórico",
                UnidadId=600,
            },
            new Servicio {
                Id = 603,
                Nombre="Sala de audiovisuales",
                Descripcion1 =" Presenta videos y presentaciones interactivas sobre la cultura Guayupe",
                UnidadId=600,
            },
            new Servicio {
                Id = 604,
                Nombre="Talleres educativos",
                Descripcion1 =" Actividades para niños y adultos que fomentan el aprendizaje sobre la historia local",
                UnidadId=600,
            },



            // Servicios para la unidad 2 (Hotel Boutique El Encanto)
            new Servicio
            {
                Id = 19,
                Nombre = "Servicio de Limpieza Diario",
                Descripcion1 = "Limpieza de la habitación y cambio de sábanas todos los días.",
                CategoriaId = 4 // Alojamiento
            },
            new Servicio
            {
                Id = 20,
                Nombre = "Servicio a la Habitación",
                Descripcion1 = "Comida y bebidas entregadas directamente a su habitación.",
                CategoriaId = 4 // Alojamiento
            },
            new Servicio
            {
                Id = 39,
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
            },
            new Servicio {
                Id = 101,
                Nombre="Atesanias La esquina",
                Descripcion1 ="Recuerdos para todos",
                UnidadId=107,
            },
            new Servicio {
                Id = 102,
                Nombre="Piezas arqueológicas",
                Descripcion1 =" Incluye urnas y vasijas con formas humanas y animales, así como trazos geométricos",
                UnidadId=107,
            },
            
            new Servicio {
                Id = 107,
                Nombre="Caño Cristales",
                Descripcion1 ="Conocido como el río de los cinco colores, ofrece vistas impresionantes con sus aguas multicolores",
                UnidadId=108,
            },
            new Servicio {
                Id = 108,
                Nombre="Senderismo",
                Descripcion1 ="Varias rutas de senderismo que permiten explorar la exuberante naturaleza del parque",
                UnidadId=108,
            },
            new Servicio {
                Id = 109,
                Nombre="Observación de aves",
                Descripcion1 ="Un paraíso para los observadores de aves, con una gran variedad de especies endémicas y migratorias",
                UnidadId=108,
            },
            new Servicio {
                Id = 110,
                Nombre="Cascadas y lagunas",
                Descripcion1 ="Diversas cascadas y lagunas que son perfectas para disfrutar de la naturaleza y tomar fotos",
                UnidadId=108,
            },
            new Servicio {
                Id = 111,
                Nombre="Ecoturismo",
                Descripcion1 =" Actividades como el baño pasivo y recreativo, interpretación del patrimonio arqueológico y fotografía de la flora y fauna",
                UnidadId=108,
            },
                
            new Servicio
            {
                Id = 500,
                Nombre = "Alquiler de Cancha Sintética",
                Descripcion1 = "Renta de cancha sintética por horas, ideal para partidos de fútbol entre amigos.",
                CategoriaId = 500,
                UnidadId = 503,
                UrlImg1 = "centro-deportivo-el-reino-alquiler-cancha-1.jpg",
                UrlImg2 = "centro-deportivo-el-reino-alquiler-cancha-2.jpg",
                UrlImg3 = "centro-deportivo-el-reino-alquiler-cancha-3.jpg",
                Valor = "40000"
            },
            new Servicio
            {
                Id = 501,
                Nombre = "Entrenamiento Personalizado",
                Descripcion1 = "Sesiones de entrenamiento deportivo personalizadas con un instructor certificado.",
                CategoriaId = 500,
                UnidadId = 503,
                UrlImg1 = "centro-deportivo-el-reino-entrenamiento-personalizado-1.jpg",
                UrlImg2 = "centro-deportivo-el-reino-entrenamiento-personalizado-2.jpg",
                UrlImg3 = "centro-deportivo-el-reino-entrenamiento-personalizado-3.jpg",
                Valor = "30000"
            },
            new Servicio
            {
                Id = 502,
                Nombre = "Bebidas Refrescantes",
                Descripcion1 = "Variedad de bebidas, incluyendo jugos naturales, refrescos y cervezas.",
                CategoriaId = 501,
                UnidadId = 503,
                UrlImg1 = "centro-deportivo-el-reino-bebidas-refrescantes-1.jpg",
                UrlImg2 = "centro-deportivo-el-reino-bebidas-refrescantes-2.jpg",
                UrlImg3 = "centro-deportivo-el-reino-bebidas-refrescantes-3.jpg",
                Valor = "4000"
            },
            new Servicio
            {
                Id = 503,
                Nombre = "Snacks Saludables",
                Descripcion1 = "Opciones de snacks saludables como barras energéticas, frutas y frutos secos.",
                CategoriaId = 501,
                UnidadId = 503,
                UrlImg1 = "centro-deportivo-el-reino-snacks-saludables-1.jpg",
                UrlImg2 = "centro-deportivo-el-reino-snacks-saludables-2.jpg",
                UrlImg3 = "centro-deportivo-el-reino-snacks-saludables-3.jpg",
                Valor = "2000"
            },

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
