namespace mytodolist.Repository.Tarefas
{
    public interface ITarefaRepository : IRepository<Model.Tarefa>
    {
        Model.ListaTarefa AtivarTarefa(long id);
    }
}
