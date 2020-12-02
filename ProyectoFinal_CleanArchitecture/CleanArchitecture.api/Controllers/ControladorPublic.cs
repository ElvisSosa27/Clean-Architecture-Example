using CleanArchitecture.Infrastructure.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControladorPublic : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPosts()
        {
            var publicaciones = new Repositorio_Publicar().GetPosts();
            return Ok(publicaciones);
        }
    }
}
