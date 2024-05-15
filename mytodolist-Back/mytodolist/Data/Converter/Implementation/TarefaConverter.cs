using mytodolist.Data.DTO;
using mytodolist.Data.Converter.Contract;
using mytodolist.Model;

namespace mytodolist.Data.Converter.Implementation
{
    public class TarefaConverter : IParser<TarefaDTO, Tarefa>, IParser<Tarefa, TarefaDTO>
    {
        public TarefaDTO Parse(Tarefa origin)
        {
            if (origin == null) return null;

            return new TarefaDTO
            {
                Id = origin.Id,
                Descricao = origin.Descricao,
                DataCriacao = origin.Criacao,
                Enabled = origin.Enabled
            };
        }

        public Tarefa Parse(TarefaDTO origin)
        {
            if (origin == null) return null;

            return new Tarefa
            {
                Id = origin.Id,
                Descricao = origin.Descricao,
                Criacao = origin.DataCriacao,
                Enabled = origin.Enabled
            };
        }

        public List<TarefaDTO> Parse(List<Tarefa> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public List<Tarefa> Parse(List<TarefaDTO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
