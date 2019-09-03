using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private IConfiguration _config;

        public CardController(IConfiguration configuration)
        {
            _config = configuration;
        }

        public readonly IProcedureRepositorio _procedureRepositorio;

        public CardController(IProcedureRepositorio _repositorio)
        {
            _procedureRepositorio = _repositorio;
        }

        [HttpGet]
        public IActionResult GetDados(
            [FromQuery]int CodEmpresa,
            [FromQuery]string CodEntidade,
            [FromQuery]int CodProduto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var produtos = _procedureRepositorio.GetProcedures(CodEmpresa, CodEntidade, CodProduto);

            return new ObjectResult(produtos);
        }
    }
}