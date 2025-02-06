using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MiOpenApiDemo.Controllers
{
    [Route("api/protegido")]
    [ApiController]
    public class ProtegidoController : ControllerBase
    {
        private readonly ILogger<ProtegidoController> _logger;

        public ProtegidoController(ILogger<ProtegidoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetProtegido()
        {
            // Obtener el token del encabezado Authorization
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
            {
                // Loguear el token recibido en los logs
                _logger.LogInformation("Token recibido: {Token}", token);
            }
            else
            {
                _logger.LogWarning("No se recibió un token en la solicitud.");
            }

            return Ok("Acceso autorizado");

        }
    }
}
