using System.ComponentModel.DataAnnotations;

namespace academico.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O contato é obrigatório.")]
        public string Contato { get; set; } = string.Empty;

        [Display(Name = "É interno?")]
        public bool Interno { get; set; }

        [Required(ErrorMessage = "O setor deve ser informado.")]
        public string Setor { get; set; } = string.Empty;
    }
}