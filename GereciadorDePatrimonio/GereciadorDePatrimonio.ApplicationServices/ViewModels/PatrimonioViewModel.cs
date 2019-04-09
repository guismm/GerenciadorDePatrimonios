using System;

namespace GereciadorDePatrimonio.ApplicationServices.ViewModels
{
    public class PatrimonioViewModel
    {
        public Guid Id { get; set; }
        public int Tombo { get; set; }
        public Guid MarcaId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
