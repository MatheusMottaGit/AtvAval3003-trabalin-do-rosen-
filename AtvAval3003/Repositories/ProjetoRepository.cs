using academico.Models;

namespace academico.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        // Lista estática para persistir os dados enquanto a aplicação rodar
        private static List<Projeto> _projetos = new List<Projeto>
        {
            new Projeto { ProjetoId = 1, Nome = "Sistema de Gestão Acadêmica", Sigla = "SGA", Ano = 2026, Status = StatusProjeto.EmDesenvolvimento },
            new Projeto { ProjetoId = 2, Nome = "Portal do Aluno Mobile", Sigla = "PAM", Ano = 2026, Status = StatusProjeto.Implantado }
        };

        public async Task<IEnumerable<Projeto>> GetAll() => await Task.FromResult(_projetos);

        public async Task<Projeto?> GetById(int id) => await Task.FromResult(_projetos.FirstOrDefault(p => p.ProjetoId == id));

        public async Task Create(Projeto projeto)
        {
            projeto.ProjetoId = _projetos.Any() ? _projetos.Max(p => p.ProjetoId) + 1 : 1;
            _projetos.Add(projeto);
            await Task.CompletedTask;
        }

        public async Task Edit(Projeto projeto)
        {
            var index = _projetos.FindIndex(p => p.ProjetoId == projeto.ProjetoId);
            if (index != -1) _projetos[index] = projeto;
            await Task.CompletedTask;
        }

        public async Task Delete(int id)
        {
            var projeto = _projetos.FirstOrDefault(p => p.ProjetoId == id);
            if (projeto != null) _projetos.Remove(projeto);
            await Task.CompletedTask;
        }
    }
}