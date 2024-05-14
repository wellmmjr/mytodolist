namespace mytodolist.Repository.ListaTarefas
{
    public interface IListaTarefaRepository : IRepository<Model.ListaTarefa>
    {
        Model.ListaTarefa AtivarListaTarefa(long id);
    }
}
