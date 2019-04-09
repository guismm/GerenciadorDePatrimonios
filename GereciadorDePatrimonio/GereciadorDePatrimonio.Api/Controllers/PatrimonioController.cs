using AutoMapper;
using GereciadorDePatrimonio.ApplicationServices.ViewModels;
using GereciadorDePatrimonio.Domain.Patrimonios.Interfaces;
using GereciadorDePatrimonio.Domain.Patrimonios.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GereciadorDePatrimonio.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PatrimonioController : Controller
    {
        private readonly IMapper _mapper;
        public readonly IPatrimonioAppService _patrimonioService;

        public PatrimonioController(IPatrimonioAppService patrimonioService, IMapper mapper)
        {
            _patrimonioService = patrimonioService;
            _mapper = mapper;
        }


        [Route("")]
        public IActionResult ListarTodos()
        {
            return Json(_patrimonioService.ListarTodos());
        }

        [HttpPost]
        [Route("")]
        public IActionResult Adicionar(PatrimonioViewModel vm)
        {
            var patrimonio = _mapper.Map<Patrimonio>(vm);

            _patrimonioService.AdicionarNovo(ref patrimonio);

            if (patrimonio.Tombo == int.MinValue)
                BadRequest();

            return Created(Url.Action("BuscarPorId", new { id = patrimonio.Id }), patrimonio);
        }

        [Route("{id}")]
        public IActionResult BuscarPorId(Guid id)
        {
            return Json(_patrimonioService.BuscarPorId(id));
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Atualizar(Guid id, [FromBody] PatrimonioViewModel vm)
        {
            vm.Id = id;

            var patrimonio = _mapper.Map<Patrimonio>(vm);

            _patrimonioService.Atualizar(patrimonio);

            return Ok(_mapper.Map<PatrimonioViewModel>(patrimonio));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Deletar(Guid id)
        {
            _patrimonioService.Deletar(id);

            return NoContent();
        }


    }
}