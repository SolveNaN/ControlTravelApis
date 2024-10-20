namespace TraverlServerTesting.Models
{
    public class Usuario
    {
        //datos del usuario
        public int Id { get; set; }
        public string? Correo { get; set; } 
        public string? TelefonoCelular { get; set; } 
        public string? Nombre { get; set; } 
        public string? Apellido { get; set; } 
        public string? NoIdentidad { get; set; }      
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;
        //datos de la sesion
        public string? PasswordUser { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public string? Token { get; set; }
        public string? Rol { get; set; } 
        public string? CodigoVerificacion { get; set; }
    }
}
