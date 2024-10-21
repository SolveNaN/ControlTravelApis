namespace TraverlServer.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public Unidad? Unidad { get; set; }
        public int? UnidadId { get; set; }
        public string? Nombre { get; set; }      
        public string? SubTitulo { get; set; }
        public string? Tipo { get; set; } // para definir tipos de habitacion,plato,transporte
        public string? Descripcion1 { get; set; }
        public string? Descripcion2 { get; set; }
        public string? Valor { get; set; }
        public string? Estado { get; set; }//Disponible, No Disponible
        public string? UrlImg1 { get; set; }
        public string? UrlImg2 { get; set; }
        public string? UrlImg3 { get; set; }
        public string? UrlImg4 { get; set; }
        public string? UrlImg5 { get; set; }
    }
}
