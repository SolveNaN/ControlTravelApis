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
                Id = 600,
                UnidadId=600,
                CategoriaId = 600,
                Nombre="Exposiciones permanentes",
                Descripcion1 ="Relatan la historia y cultura de la etnia indígena Guayupe",
                Valor = "Ver Mas",
                UrlImg1 = "https://musa.com.co/CMS/modules/picture_gallery/files/2016-07-07_06_25_44CQ-835-DETALLE.jpg",
                UrlImg2 = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEjpECGXRuuiJeZDqxIVgzV7O6hrMx_iTf_J1TczExofPai4qs-aIkgf9imXF98DodC0b-eBy7Lp1NOFiJIVXyqr7Jx_Q6Y2ZYk_8rQ1MvPbLTfhM4Qb_9Vb7uaussuB5o3VnIjmGsVAHjM/s1600/FB_IMG_1554756654800.jpg",
                UrlImg3 = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEiLGhQzqBPEXvAMCUJ9yCahUEL6kF35VW_n-gwU1m4hmgj_fc8BIS1Tk5mOrSR7YVMDBB3iuNhsj8GcrYSMqWQUlQ50nYhNL3-FF82PNyEX7mTrNU8GK_yR8py8oTdKkjl-2NFvlS2I3vA/s1600/IMG_0861.JPG"
            },
            new Servicio {
                Id = 601,
                UnidadId=600,
                CategoriaId = 600,
                Nombre="Recorridos guiados",
                Descripcion1 ="Ofrecen una visión detallada de las piezas y su contexto histórico",
                Valor = "Ver Mas",
                UrlImg1 = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgqejwDq4QYjIDffb6_rCyKO1-9F57U2IHkLuz3XRLUjtna1r69W_t1FJeCBduLqO9UMGnd2A5DoWqnZWh9SeiQgA840xifX4CsSoTagv3cXyiHCYc0wQmZlRrsLHr84yIbEOF54-rAhyg/s1600/IMG_0822.JPG",
                UrlImg2 = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEiLGhQzqBPEXvAMCUJ9yCahUEL6kF35VW_n-gwU1m4hmgj_fc8BIS1Tk5mOrSR7YVMDBB3iuNhsj8GcrYSMqWQUlQ50nYhNL3-FF82PNyEX7mTrNU8GK_yR8py8oTdKkjl-2NFvlS2I3vA/s1600/IMG_0861.JPG",
                UrlImg3 = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEjQbKZPpJHzWqrLQbUXi3uRG57EKzGM_lFxb2kh6GWerUz7LCwUTRxAXjT_ms30DBraLWrU9myEXxxlUmlgX9JSsed20suqnlRjMVKNRXp7o38nfuD9zJhOI4pXKT8ovcA-I2G9zhq1G9k/s1600/IMG_0833.JPG"
            },
            new Servicio {
                Id = 602,
                UnidadId=600,
                CategoriaId = 601,
                Nombre="Sala de audiovisuales",
                Valor = "Ver Mas",
                Descripcion1 ="Presenta videos y presentaciones interactivas sobre la cultura Guayupe",
                UrlImg1 = "https://i.ytimg.com/vi/8nDe0QsCBdo/hq720.jpg?sqp=-oaymwEhCK4FEIIDSFryq4qpAxMIARUAAAAAGAElAADIQj0AgKJD&rs=AOn4CLCknL1OQJpya3HZjG1MgjkWlLdiRg",
                UrlImg2 = "https://www.viveelmeta.com/wp-content/uploads/2018/09/Campo-Revelado-Egar-1.jpg",
                UrlImg3 = "https://scontent.fbga1-3.fna.fbcdn.net/v/t39.30808-6/459483689_949067777263720_8903809313511113739_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=833d8c&_nc_ohc=_2vco_GeuhIQ7kNvgEtFQH3&_nc_zt=23&_nc_ht=scontent.fbga1-3.fna&_nc_gid=A3fTyDwgn_6bJ1e2C7JCt4A&oh=00_AYCNYafCF_CJYP9dQsrHxE3UOhISSZANVuYr_PoDnXCcUg&oe=672C0548"
            },
            new Servicio {
                Id = 603,
                UnidadId=600,
                CategoriaId = 601,
                Nombre="Talleres educativos",
                Descripcion1 =" Actividades para niños y adultos que fomentan el aprendizaje sobre la historia local",
                Valor = "Ver Mas",
                UrlImg1 = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEjXjAmgkhn-uhF7CP4o9s4PxsXYPKq0qU034CnIGul-vXf5K44qghxLAFDqgefYXQS13zipMLigcZ1EljDW8GeUMP8GFsV2mnSWqbiui5JfkoYFgxjOl7AXy5nkZeYw9rJV5nJeP7hLm9H4/s1600/fotos+113.JPG",
                UrlImg2 = "https://i.promecal.es/IMG/2014/28543D99-DDF8-3020-16307BDF28408E90.JPG",
                UrlImg3 = "https://scontent.fbga1-3.fna.fbcdn.net/v/t39.30808-6/449831138_1447367525923485_4883570110595610841_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=833d8c&_nc_ohc=rdmdefXntbEQ7kNvgFEhvJS&_nc_zt=23&_nc_ht=scontent.fbga1-3.fna&_nc_gid=ANxjjblAOjgWrQ_yLYpz47q&oh=00_AYAZQ9j8ru2RHHNCazvkz9xUL6_bmCDCQ61JEJonalnmjQ&oe=672C0011"
            },



            // Playas (700 - 799)
            new Servicio
            {
                Id = 700,
                UnidadId = 700,
                CategoriaId = 700,
                Nombre = "Alquiler de Kayaks",
                Descripcion1 = "Alquiler de kayaks para explorar las aguas de Playa Merecure.",
                UrlImg1 = "https://corticata.com/wp-content/uploads/2022/09/alquiler-kayak-1.jpg",
                UrlImg2 = "https://alua.es/wp-content/uploads/2022/09/Kayak-Alquiler.webp",
                UrlImg3 = "https://kayakelpajar.com/wp-content/uploads/2021/04/2.jpg",
                Valor = "Ver Mas"
            },
            new Servicio
            {
                Id = 701,
                UnidadId = 700,
                CategoriaId = 700,
                Nombre = "Paddleboarding",
                Descripcion1 = "Equipo disponible para practicar paddleboarding en el mar.",
                UrlImg1 = "https://suplovers.co/_astro/punte-piedra-card.9mkr-KMp_Z20SSGU.webp",
                UrlImg2 = "https://suplovers.co/_astro/boards-1.B2Mur7Cj_Zv7vJM.webp",
                UrlImg3 = "https://kayaksupilhagrande.com/wp-content/uploads/2021/04/IMG_20210123_083353-scaled.jpg",
                Valor = "Ver Mas"
            },
            new Servicio
            {
                Id = 702,
                UnidadId = 700,
                CategoriaId = 701,
                Nombre = "Masajes frente al mar",
                Descripcion1 = "Servicio de masajes en la playa para una experiencia de bienestar única.",
                UrlImg1 = "https://media-cdn.tripadvisor.com/media/photo-s/0d/7a/1d/98/relajate-con-un-espectacular.jpg",
                UrlImg2 = "https://media-cdn.tripadvisor.com/media/photo-s/04/6e/ee/c4/cocoplum-beach-hotel.jpg",
                UrlImg3 = "https://i.blogs.es/ce21f2/masaje-20playa/1366_2000.jpg",
                Valor = "Ver Mas"
            },
            new Servicio
            {
                Id = 703,
                UnidadId = 700,
                CategoriaId = 701,
                Nombre = "Zonas de Picnic",
                Descripcion1 = "Áreas para picnic en la playa, perfectas para disfrutar de una comida al aire libre.",
                UrlImg1 = "https://cdn0.matrimonio.com.co/vendor/7202/3_2/960/jpeg/picnic-colombia-3_10_147202-162755655476565.jpeg",
                UrlImg2 = "https://rollingplayas.com/wp-content/uploads/2022/08/picnic4.jpg",
                UrlImg3 = "https://cdn0.matrimonio.com.co/vendor/5638/3_2/960/jpg/file-1717778969863_10_175638-171777897158816.jpeg",
                Valor = "Ver Mas"
            },



            // Centros_Culturales (800 - 899)
            new Servicio
            {
                Id = 800,
                UnidadId = 801,
                CategoriaId = 800,
                Nombre = "Visitas Guiadas",
                Descripcion1 = "Tours guiados que exploran la historia, cultura y tradiciones del resguardo Maguare.",
                UrlImg1 = "https://manguaregira.wordpress.com/wp-content/uploads/2012/07/img_1443.jpg?w=300&h=200",
                UrlImg2 = "https://static.wixstatic.com/media/a7501f_f30fdbe219f248238db793d16856df49~mv2.jpg/v1/fill/w_750,h_500,al_c,q_90/a7501f_f30fdbe219f248238db793d16856df49~mv2.jpg",
                UrlImg3 = "https://i0.wp.com/elcuartomosquetero.com/wp-content/uploads/2020/10/IMG_4206-2.jpg?resize=696%2C738&ssl=1",
                Valor = "Ver Mas"
            },
            new Servicio
            {
                Id = 801,
                UnidadId = 801,
                CategoriaId = 800,
                Nombre = "Talleres de Artesanía",
                Descripcion1 = "Talleres para aprender técnicas de artesanía tradicional, como tejido y cerámica.",
                UrlImg1 = "https://vanidad.es/images/carpeta_relacionados/2019/09/11/150826_artesania_portada.jpg",
                UrlImg2 = "https://www.en-otavalo.com/wp-content/uploads/2023/10/TallerPeguche-1024x734.webp",
                UrlImg3 = "https://artesaniasdecolombia.com.co/Documentos/Contenido/9305_taller-ceramica-rosa-maria-jerez-artesanias-colombia-2013.jpg",
                Valor = "Ver Mas"
            },
            new Servicio
            {
                Id = 802,
                UnidadId = 801,
                CategoriaId = 801,
                Nombre = "Ceremonias Espirituales",
                Descripcion1 = "Ceremonias guiadas por líderes indígenas para conectarse con la naturaleza y el espíritu.",
                UrlImg1 = "https://villavicencio.gov.co/wp-content/uploads/2021/05/22.png",
                UrlImg2 = "https://freight.cargo.site/t/original/i/ddc844af9f19fa848fb95a6eaec7232eee4cb9ed29e6662a04a42a96375bbd55/Corto-documental-El-canto-del-maguare.-Palabra-de-consejo-de-Dujdulli_1_FotoAgendaPropia.jpeg",
                UrlImg3 = "https://www.lifeder.com/wp-content/uploads/2017/10/Bestknate-danza-baile-indigena.jpg",
                Valor = "Ver Mas"
            },
            new Servicio
            {
                Id = 803,
                UnidadId = 801,
                CategoriaId = 801,
                Nombre = "Senderismo por la Reserva",
                Descripcion1 = "Recorridos guiados por la reserva para descubrir la flora y fauna local.",
                UrlImg1 = "https://static.wixstatic.com/media/51f90f_0f7d4171eb834293b19a34520184a95d~mv2.jpg/v1/fill/w_2500,h_1666,al_c/51f90f_0f7d4171eb834293b19a34520184a95d~mv2.jpg",
                UrlImg2 = "https://www.fucsia.co/resizer/v2/OKISJA752JG7BA6NGKWVF3PFKQ.jpeg?auth=f30ac1f92d3996be89fbe95c2b44c4b9db00cb2fbedcbb2622693a02f6caa8d4&smart=true&quality=75&width=1920&height=1080",
                UrlImg3 = "https://travelgrafia.co/wp-content/uploads/2021/12/Top-Mejores-trekking-Colombia.jpg",
                Valor = "Ver Mas"
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
