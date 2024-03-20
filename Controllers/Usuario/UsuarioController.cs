using Microsoft.AspNetCore.Mvc;
using VinciPartern.Aplicacao.Comando.Usuario;

namespace VinciPartern.Api.Controllers.Usuario
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        [Route("/obterUsuarioPorId")]
        public IActionResult ObterUsuarioPorId(ConsultaObterUsuarioPorId consulta)
        {
            return Ok(consulta);
        }

        [HttpPost]
        [Route("/incluir")]
        public IActionResult Incluir(ComandoIncluir comando)
        {
            return Ok(comando);
        }
    }
}
