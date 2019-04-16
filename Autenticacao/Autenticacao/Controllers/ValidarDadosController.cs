using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autenticacao.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Autenticacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidarDadosController : ControllerBase
    {
        [HttpGet]
        [Route("usuario")]
        public ActionResult<IEnumerable<string>> AutenticarUsuario([FromQuery] Usuario usuario)
        {
            return Ok();
        }
    }
}