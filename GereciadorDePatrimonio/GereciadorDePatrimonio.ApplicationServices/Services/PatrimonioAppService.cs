using GereciadorDePatrimonio.Domain.Patrimonios.Interfaces;
using GereciadorDePatrimonio.Domain.Patrimonios.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GereciadorDePatrimonio.ApplicationServices.Services
{
    public class PatrimonioAppService : IPatrimonioAppService
    {
        private readonly IPatrimonioRepository _patrimonioRepository;
        

        public PatrimonioAppService(
            IPatrimonioRepository usuarioRepository)
        {
            _patrimonioRepository = usuarioRepository;
        }

        public void AdicionarNovo(ref Patrimonio patrimonio)
        {
            patrimonio.Tombo = _patrimonioRepository.ListarTodos().Count() + 1; 

            _patrimonioRepository.AdicionarNovo(patrimonio);
        }

        public void Atualizar(Patrimonio patrimonio)
        {
            var old = _patrimonioRepository.BuscarAsNoTracking(e => e.Id.Equals(patrimonio.Id)).FirstOrDefault();

            patrimonio.Tombo = old.Tombo;

            _patrimonioRepository.Atualizar(patrimonio);
        }

        public Patrimonio BuscarPorId(Guid id)
        {
            return _patrimonioRepository.Buscar(e => e.Id.Equals(id)).FirstOrDefault();
        }

        public IEnumerable<Patrimonio> BuscarPorMarca(Guid marcaId)
        {
            return _patrimonioRepository.Buscar(e => e.MarcaId.Equals(marcaId));
        }

        public void Deletar(Guid id)
        {
            _patrimonioRepository.Deletar(id);
        }

        public IEnumerable<Patrimonio> ListarTodos()
        {
            return _patrimonioRepository.ListarTodos();
        }
    }
}
