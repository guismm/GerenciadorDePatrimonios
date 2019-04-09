using System;

namespace GereciadorDePatrimonio.Domain.Patrimonios.Models
{
    public class Patrimonio
    {
        public Guid Id { get; set; }
        public int Tombo { get; set; }
        public Guid MarcaId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Patrimonio(Guid marcaId, string nome, string descricao)
        {
            if (Id.Equals(Guid.Empty))
                Id = Guid.NewGuid();
            
            MarcaId = marcaId;
            Nome = nome;
            Descricao = descricao;
        }

        public Patrimonio(int tombo, Guid marcaId, string nome, string descricao) : this(marcaId, nome, descricao)
        {
            Tombo = tombo;
        }

        public Patrimonio(Guid id, int tombo, Guid marcaId, string nome, string descricao) : this(tombo, marcaId, nome, descricao)
        {
            Id = id;
        }
    }
}
