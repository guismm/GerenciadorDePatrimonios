using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using GereciadorDePatrimonio.ApplicationServices.ViewModels;
using GereciadorDePatrimonio.Domain.Marcas.Interfaces;
using GereciadorDePatrimonio.Domain.Marcas.Models;
using Microsoft.AspNetCore.Mvc;

namespace GereciadorDePatrimonio.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarcasController : Controller
    {
        public readonly IMarcaAppService _marcasService;
        private readonly IMapper _mapper;

        public MarcasController(IMapper mapper, IMarcaAppService marcasService)
        {
            _mapper = mapper;
            _marcasService = marcasService;
        }

        [Route("")]
        public IActionResult ListarTodos()
        {
            return Json(_marcasService.ListarTodos());
        }

        [HttpPost]
        [Route("")]
        public IActionResult Adicionar(MarcaViewModel vm)
        {
            Marca marca = _mapper.Map<Marca>(vm);

            _marcasService.AdicionarNovo(ref marca);

            if (marca.Id.Equals(Guid.Empty))
                BadRequest();
            
            return Created(Url.Action("BuscarPorId", new { id = marca.Id }), marca);
        }

        [Route("{id}")]
        public IActionResult BuscarPorId(Guid id)
        {
            return Json(_marcasService.BuscarPorId(id));
        }

        [Route("{id}/patrimonios")]
        public IActionResult BuscarPatrimonioPormarca(Guid id)
        {
            return Json(_marcasService.BuscarPatrimoniosPorMarca(id));
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Atualizar(Guid id, [FromBody] MarcaViewModel vm)
        {
            vm.Id = id;

            Marca marca = _mapper.Map<Marca>(vm);

            _marcasService.Atualizar(marca);

            return Ok(_mapper.Map<MarcaViewModel>(marca));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Deletar(Guid id)
        {
            _marcasService.Deletar(id);

            return NoContent();
        }

    }
}