using GereciadorDePatrimonio.Domain.Marcas.Interfaces;
using GereciadorDePatrimonio.Domain.Marcas.Models;
using GereciadorDePatrimonio.Domain.Patrimonios.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using GereciadorDePatrimonio.Domain.Patrimonios.Interfaces;

namespace GereciadorDePatrimonio.ApplicationServices.Services
{
    public class MarcaAppService : IMarcaAppService
    {
        private readonly IMarcaRepository _marcaRepository;
        private readonly IPatrimonioAppService _patrimonioService;

        public MarcaAppService(
            IPatrimonioAppService patrimonioService,
            IMarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
            _patrimonioService = patrimonioService;
        }

        public void AdicionarNovo(ref Marca marca)
        {
            var nome = marca.Nome;

            var marcaExistente = _marcaRepository.Buscar(e => e.Nome == nome).FirstOrDefault();

            // TODO: Adicionar notification pattern
            if (marcaExistente != null)
            {
                marca = marcaExistente;
                return;
            }

            _marcaRepository.AdicionarNovo(marca);
        }

        public void Atualizar(Marca marca)
        {
            _marcaRepository.Atualizar(marca);
        }

        public IEnumerable<Patrimonio> BuscarPatrimoniosPorMarca(Guid id)
        {
            return _patrimonioService.BuscarPorMarca(id);
        }

        public Marca BuscarPorId(Guid id)
        {
            return _marcaRepository.Buscar(e => e.Id.Equals(id)).FirstOrDefault();
        }

        public void Deletar(Guid id)
        {
            _marcaRepository.Deletar(id);
        }

        public IEnumerable<Marca> ListarTodos()
        {
            return _marcaRepository.ListarTodos(); 
        }
    }
}
