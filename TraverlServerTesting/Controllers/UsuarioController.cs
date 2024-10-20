using TraverlServerTesting.Models;
using TraverlServerTesting.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
namespace TraverlServerTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UsuarioController(ApplicationDbContext context)
        {

            _context = context;
        }


        [HttpGet("Datos")]
        public async Task<ActionResult<List<Usuario>>> GetCuenta()
        {
            var lista = await _context.Usuarios.ToListAsync();
            return Ok(lista);
        }

        public static Usuario usuario = new Usuario();
        [HttpPost("Registrar")]
        public async Task<ActionResult<string>> CreateCuenta(Usuario objeto)
        {
            try
            {
                CreatePasswordHash(objeto.PasswordUser, out byte[] passwordHash, out byte[] passwordSalt);
                usuario.Nombre = objeto.Nombre;
                usuario.Correo = objeto.Correo;
                usuario.PasswordHash = passwordHash;
                usuario.PasswordSalt = passwordSalt;
                usuario.Rol = objeto.Rol;
                usuario.PasswordUser = objeto.PasswordUser;
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                var respuesta = "Registrado Con Exito";

                return respuesta;
            }
            catch (Exception ex)
            {
                return BadRequest("Error dutante el registro");
            }

        }
        [HttpPost("Login")]
        public async Task<ActionResult<string>> InicioSesion(Usuario objeto)
        {
            var cuanta = await _context.Usuarios.Where(x => x.Correo == objeto.Correo).FirstOrDefaultAsync();
            if (cuanta == null)
            {
                return BadRequest("Usuario no encontrado");
            }
            if (!VerifyPasswordUser(objeto.PasswordUser, cuanta.PasswordUser))
            {
                return BadRequest("Contraseña incorrecta");
            }
            string token = CreateToken(cuanta);
            return Ok(token);

        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordUser(string password, string passwordDb)
        {
            if (password == passwordDb)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }


        private string CreateToken(Usuario user)
        {
            List<Claim> claims = new List<Claim>
     {
         new Claim(ClaimTypes.Name, user.Nombre+" "+user.Apellido),
         new Claim(ClaimTypes.Role,user.Rol)
     };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                "PROYECTO_CONTROL_TRAVEL_BLAPPI_UNION_DESARROLLADO_EN_EQUIPO_CONJUNTO_CLIENTE_SERVIDOR_BUC_OC_2024"));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
