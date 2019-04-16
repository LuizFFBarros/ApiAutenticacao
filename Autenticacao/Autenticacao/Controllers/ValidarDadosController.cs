using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Autenticacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidarDadosController : ControllerBase
    {
        [HttpPost]
        [Route("usuario")]
        public ActionResult<IEnumerable<string>> AutenticarUsuario([FromBody] string livroJson)
        {
            return Ok();
        }
    }
}