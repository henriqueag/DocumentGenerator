﻿using System.Threading.Tasks;
using GeneratePersonApi.Entities;
using Microsoft.AspNetCore.Mvc;
using GeneratePersonApi.Services.Interfaces;
using GeneratePersonApi.Entities.Enum;

namespace GeneratePersonApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonGenereteController : ControllerBase
    {
        private IPessoaService _service;
        private IEnderecoService _enderecoService;

        public PersonGenereteController(IPessoaService service, IEnderecoService enderecoService)
        {
            _service = service;
            _enderecoService = enderecoService;
            new EstadosBR();
        }

        [HttpGet("OnePerson")]
        public async Task<IActionResult> GetPessoa([FromQuery] int? idade = null, [FromQuery] EstadosBR? estado = null, [FromQuery] string cidade = null, [FromQuery] bool gerarComPonto = true)
        {
            try
            {
                var model = await _service.GerarPessoaAsync(idade, estado, cidade, gerarComPonto);
                if (model is null)
                {
                    return NotFound();
                }
                return Ok(model.ToApi());
            }
            catch (System.Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("ListPerson")]
        public async Task<IActionResult> GetListPessoas([FromQuery] int qtdPessoas, [FromQuery] int? idade = null, [FromQuery] EstadosBR? estado = null, [FromQuery] string cidade = null, [FromQuery] bool gerarComPonto = true)
        {
            try
            {
                var model = await _service.GerarListPessoaAsync(qtdPessoas, idade, estado, cidade, gerarComPonto);
                if (model is null)
                {
                    return NotFound();
                }
                return Ok(model.ToApi());
            }
            catch (System.Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("Cidades")]
        public IActionResult GetCidades([FromQuery] EstadosBR? estadosBR)
        {
            var cidades = _enderecoService.GetCidades(estadosBR);
            return Ok(cidades);
        }

        [HttpGet("Estados")]
        public IActionResult GetEstados()
        {
            var estados = _enderecoService.GetEstados();
            return Ok(estados);
        }
    }
}
