using System;
using System.ComponentModel.DataAnnotations;

namespace GereciadorDePatrimonio.ApplicationServices.ViewModels
{
    public class MarcaViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public string Nome { get; set; }
    }
}
