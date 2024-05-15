using mytodolist.Data.DTO;
using mytodolist.Data.Converter.Implementation;
using mytodolist.Repository.ListaTarefas;

namespace mytodolist.Business.Implementation
{
    public class ListaTarefaBusinessImplementation : IListaTarefaBusiness
    {
        private readonly IListaTarefaRepository _repository;

        private readonly ListaTarefaConverter _converter;
        public ListaTarefaBusinessImplementation(IListaTarefaRepository repository)
        {
            _repository = repository;
            _converter = new ListaTarefaConverter();
        }

        public ListaTarefaDTO Create(ListaTarefaDTO listaTarefaDTO)
        {
            var listaTarefa = _converter.Parse(listaTarefaDTO);
            _repository.Create(listaTarefa);

            return _converter.Parse(listaTarefa);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<ListaTarefaDTO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }


        public ListaTarefaDTO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }    

        public ListaTarefaDTO Update(ListaTarefaDTO listaTarefaDTO)
        {
            var listaTarefa = _converter.Parse(listaTarefaDTO);
            _repository.Update(listaTarefa);

            return _converter.Parse(listaTarefa);
        }
    }
}
