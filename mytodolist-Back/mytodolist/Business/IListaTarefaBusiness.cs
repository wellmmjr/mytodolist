using mytodolist.Data.DTO;
namespace mytodolist.Business
{
    public interface IListaTarefaBusiness
    {
        ListaTarefaDTO Create(ListaTarefaDTO personVO);

        ListaTarefaDTO FindById(long id);

        List<ListaTarefaDTO> FindAll();

        ListaTarefaDTO Update(ListaTarefaDTO personVO);

        void Delete(long id);
    }
}
