using mytodolist.Data.DTO;
using mytodolist.Data.Converter.Contract;
using mytodolist.Model;

namespace mytodolist.Data.Converter.Implementation
{
    public class ListaTarefaConverter : IParser<ListaTarefaDTO, ListaTarefa>, IParser<ListaTarefa, ListaTarefaDTO>
    {
        public ListaTarefaDTO Parse(ListaTarefa origin)
        {
            if (origin == null) return null;

            return new ListaTarefaDTO
            {
                Id = origin.Id,
                Titulo = origin.Titulo,
                DataCriacao = origin.Criacao,
                Enabled = origin.Enabled
            };
        }

        public ListaTarefa Parse(ListaTarefaDTO origin)
        {
            if (origin == null) return null;

            return new ListaTarefa
            {
                Id = origin.Id,
                Titulo = origin.Titulo,
                Criacao = origin.DataCriacao,
                Enabled = origin.Enabled
            };
        }

        public List<ListaTarefaDTO> Parse(List<ListaTarefa> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public List<ListaTarefa> Parse(List<ListaTarefaDTO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
