using mytodolist.Data.DTO;

namespace mytodolist.Business
{
    public interface ITarefaBusiness
    {
        TarefaDTO Create(TarefaDTO tarefaDTO);

        TarefaDTO FindById(long id);

        List<TarefaDTO> FindAll();

        TarefaDTO Update(TarefaDTO tarefaDTO);

        TarefaDTO AtivarTarefa(long id);

        void Delete(long id);
    }
}
