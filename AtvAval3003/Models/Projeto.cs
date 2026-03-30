using System.ComponentModel.DataAnnotations;

namespace academico.Models
{
    public enum StatusProjeto
    {
        [Display(Name = "Em desenvolvimento")] EmDesenvolvimento = 1,
        [Display(Name = "Em condições de defesa")] EmCondicoesDeDefesa = 2,
        [Display(Name = "Completo sem implantar")] CompletoSemImplantar = 3,
        [Display(Name = "Implantado")] Implantado = 4
    }

    public class Projeto
    {
        [Key]
        public int ProjetoId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome não pode ultrapassar 100 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "A sigla é obrigatória.")]
        [RegularExpression(@"^\S+$", ErrorMessage = "A sigla não pode conter espaços.")]
        public string Sigla { get; set; } = string.Empty;

        [Required(ErrorMessage = "O ano é obrigatório.")]
        [Range(2026, 2026, ErrorMessage = "O projeto deve ser do ano atual (2026).")]
        public int Ano { get; set; } = DateTime.Now.Year;

        [Required(ErrorMessage = "Selecione um status.")]
        public StatusProjeto Status { get; set; }
    }
}