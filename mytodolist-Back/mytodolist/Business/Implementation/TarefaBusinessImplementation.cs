using mytodolist.Data.Converter.Implementation;
using mytodolist.Data.DTO;
using mytodolist.Repository.Tarefas;

namespace mytodolist.Business.Implementation
{
    public class TarefaBusinessImplementation : ITarefaBusiness
    {
        private readonly ITarefaRepository _repository;

        private readonly TarefaConverter _converter;
        public TarefaBusinessImplementation(ITarefaRepository repository)
        {
            _repository = repository;
            _converter = new TarefaConverter();
        }

        public TarefaDTO AtivarTarefa(long id)
        {
            throw new NotImplementedException();
        }

        public TarefaDTO Create(TarefaDTO tarefaDTO)
        {
            var tarefa = _converter.Parse(tarefaDTO);
            _repository.Create(tarefa);

            return _converter.Parse(tarefa);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<TarefaDTO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public TarefaDTO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public TarefaDTO Update(TarefaDTO tarefaDTO)
        {
            var tarefa = _converter.Parse(tarefaDTO);
            _repository.Update(tarefa);

            return _converter.Parse(tarefa);
        }
    }
}
