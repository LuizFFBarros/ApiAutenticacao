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

        List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario{ Codigo = 1, Nome = "Luiz"},
            new Usuario{ Codigo = 2, Nome = "Augusto"},
            new Usuario{ Codigo = 3, Nome = "Jose"},
        };

        [HttpGet]
        [Route("usuario")]
        public ActionResult<IEnumerable<string>> AutenticarUsuario([FromQuery] Usuario usuario)
        {

            return Ok(usuarios.Any(a =>a.Codigo == usuario.Codigo));
        }
    }

}