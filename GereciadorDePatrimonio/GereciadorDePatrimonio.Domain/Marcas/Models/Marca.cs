using System;

namespace GereciadorDePatrimonio.Domain.Marcas.Models
{
    public class Marca
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public Marca(Guid id, string nome)
        {
            if (id == Guid.Empty)
                Id = Guid.NewGuid();

            Nome = nome;
        }

        protected Marca() { }
    }
}
