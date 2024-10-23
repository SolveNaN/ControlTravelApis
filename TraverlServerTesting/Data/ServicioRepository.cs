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
            },
            new Servicio {
                    Id = 101,
                    Nombre="Atesanias La esquina",
                    Descripcion1 ="Recuerdos para todos",
                    UnidadId=101,

                },
                new Servicio {
                    Id = 102,
                    Nombre="Piezas arqueológicas",
                    Descripcion1 =" Incluye urnas y vasijas con formas humanas y animales, así como trazos geométricos",
                    UnidadId=107,
                },
                new Servicio {
                    Id = 103,
                    Nombre="Exposiciones permanentes",
                    Descripcion1 ="Relatan la historia y cultura de la etnia indígena Guayupe",
                    UnidadId=107,
                },
                new Servicio {
                    Id = 104,
                    Nombre="Recorridos guiados",
                    Descripcion1 ="Ofrecen una visión detallada de las piezas y su contexto histórico",
                    UnidadId=107,
                },
                new Servicio {
                    Id = 105,
                    Nombre="Sala de audiovisuales",
                    Descripcion1 =" Presenta videos y presentaciones interactivas sobre la cultura Guayupe",
                    UnidadId=107,
                },
                new Servicio {
                    Id = 106,
                    Nombre="Talleres educativos",
                    Descripcion1 =" Actividades para niños y adultos que fomentan el aprendizaje sobre la historia local",
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
                new Servicio {
                    Id = 112,
                    Nombre="Habitación Doble",
                    Descripcion1 ="Una habitación con una cama doble, ideal para parejas.",
                    UnidadId=108,
                },
                new Servicio {
                    Id = 113,
                    Nombre="Habitación Triple",
                    Descripcion1 ="Una habitación con una cama doble y una cama extra, perfecta para tres personas.",
                    UnidadId=108,
                },
                new Servicio {
                    Id = 114,
                    Nombre="Habitación Familiar",
                    Descripcion1 ="Una habitación más grande con una cama doble y una o más camas adicionales, adecuada para familias.",
                    UnidadId=108,
                },
                new Servicio {
                    Id = 115,
                    Nombre="Suite Presidencial",
                    Descripcion1 ="Una suite lujosa con mayores comodidades, incluyendo un área de estar y baño más grande.",
                    UnidadId=108,
                },

                new Servicio {
                    Id=116,
            Nombre="Portal del sol",
            Titulo="Habitacion 1 ",
            SubTitulo="Habitación Estándar",
            Descripcion1="La Habitación Estándar ofrece un ambiente acogedor y funcional. Equipadas con una cama matrimonial o dos camas individuales, estas habitaciones son ideales para viajeros solos o en pareja.",
            Descripcion2="Disponen de un escritorio de trabajo, televisión de pantalla plana y baño privado con artículos de tocador. La decoración es moderna y minimalista, creando un espacio perfecto para descansar después de un día de exploración.",
            UrlImg1 = "https://www.sofitelbarucalablanca.com/wp-content/uploads/sites/19/2023/04/DUF_8644-v-ok-1170x780.jpg",
            UrlImg2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQx3zfiM5DnlrdwBBfChNElnjFiv9aL5Yy9fVrkpSL6MVLT1moZGoFzdyDquP7Rmy2QwE&usqp=CAU",
            UrlImg3 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRMs3LrlUpZAv2XdgDHxNGyANOhJ9H-xm99wledrq7STBxqxyJ1qesuyERD27qMo6DuWKs&usqp=CAU",
            Valor="450",
            UnidadId=112
                },
                new Servicio {
                    Id=117,           
            Nombre="Portal del sol",
            Titulo="Habitacion 1 ",
            SubTitulo="Habitación Estándar",
            Descripcion1="La Habitación Estándar ofrece un ambiente acogedor y funcional. Equipadas con una cama matrimonial o dos camas individuales, estas habitaciones son ideales para viajeros solos o en pareja.",
            Descripcion2="Disponen de un escritorio de trabajo, televisión de pantalla plana y baño privado con artículos de tocador. La decoración es moderna y minimalista, creando un espacio perfecto para descansar después de un día de exploración.",
            UrlImg1 = "https://th.bing.com/th?id=OIP.wJLz7YmzEq7__L9ccwr_WQHaE8&w=306&h=204&c=8&rs=1&qlt=90&o=6&cb=13&pid=3.1&rm=2",
            UrlImg3 = "https://www.sofitelbarucalablanca.com/wp-content/uploads/sites/19/2023/04/DUF_8644-v-ok-1170x780.jpg",
            UrlImg2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQx3zfiM5DnlrdwBBfChNElnjFiv9aL5Yy9fVrkpSL6MVLT1moZGoFzdyDquP7Rmy2QwE&usqp=CAU",
            Valor="350",
            UnidadId=112
                },
                new Servicio {
                    Id=118,
            Nombre="Portal del sol",
            Titulo="Habitacion 1 ",
            SubTitulo="Habitación Estándar",
            Descripcion1="La Habitación Estándar ofrece un ambiente acogedor y funcional. Equipadas con una cama matrimonial o dos camas individuales, estas habitaciones son ideales para viajeros solos o en pareja.",
            Descripcion2="Disponen de un escritorio de trabajo, televisión de pantalla plana y baño privado con artículos de tocador. La decoración es moderna y minimalista, creando un espacio perfecto para descansar después de un día de exploración.",
            UrlImg1 = "https://th.bing.com/th?id=OIP.2Jf2sAwUUePiMobe-BBJMAHaE7&w=306&h=204&c=8&rs=1&qlt=90&o=6&cb=13&pid=3.1&rm=2",
            UrlImg3 = "https://www.sofitelbarucalablanca.com/wp-content/uploads/sites/19/2023/04/DUF_8644-v-ok-1170x780.jpg",
            UrlImg2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQx3zfiM5DnlrdwBBfChNElnjFiv9aL5Yy9fVrkpSL6MVLT1moZGoFzdyDquP7Rmy2QwE&usqp=CAU",
            Valor="450",
            UnidadId=112
                },
                 new Servicio {
                    Id=118,
            Titulo="Habitacion 4 ",
             Nombre="Portal del sol",
            SubTitulo="Habitación Estándar",
            Descripcion1="La Habitación Estándar ofrece un ambiente acogedor y funcional. Equipadas con una cama matrimonial o dos camas individuales, estas habitaciones son ideales para viajeros solos o en pareja.",
            Descripcion2="Disponen de un escritorio de trabajo, televisión de pantalla plana y baño privado con artículos de tocador. La decoración es moderna y minimalista, creando un espacio perfecto para descansar después de un día de exploración.",
            UrlImg1 = "https://th.bing.com/th?id=OIP.nfepFd1KATgmLo93pip8yQHaFj&w=288&h=216&c=8&rs=1&qlt=90&o=6&cb=13&pid=3.1&rm=2",
            UrlImg3 = "https://www.sofitelbarucalablanca.com/wp-content/uploads/sites/19/2023/04/DUF_8644-v-ok-1170x780.jpg",
            UrlImg2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQx3zfiM5DnlrdwBBfChNElnjFiv9aL5Yy9fVrkpSL6MVLT1moZGoFzdyDquP7Rmy2QwE&usqp=CAU",
            Valor="550",
            UnidadId=112
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
