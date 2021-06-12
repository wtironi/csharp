using Curso.api.Models.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.api.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    public class usuarioController : ControllerBase
    {
        [HttpPost]
        [Route("logar")]
        //criação de rota
        public IActionResult Logar( LoginViewModelInput loginViewModelInput)
        {
            return Ok(loginViewModelInput);
        }

        /*[HttpPost]
        [Route("registrar")]
        //criação de rota
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            return Created("", loginViewModelInput);
        }*/
    }
}
