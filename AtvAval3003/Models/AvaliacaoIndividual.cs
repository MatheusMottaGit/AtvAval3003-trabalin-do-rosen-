namespace AtvAval3003.Models
{
    public class AvaliacaoIndividual
    {
        public int Id { get; set; }

        public float Nota { get; set; }

        public int AvaliadorId { get; set; }
        public Avaliador Avaliador { get; set; }

        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
    }
}