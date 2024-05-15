using mytodolist.Model;
using mytodolist.Model.Context;
using mytodolist.Repository.Generic;
using System;
namespace mytodolist.Repository.Tarefas
{
    public class ListaTarefaRepository : GenericRepository<Model.Tarefa>, ITarefaRepository
    {
        public ListaTarefaRepository(MySQLContext context) : base(context) { }

        public ListaTarefa AtivarTarefa(long id)
        {
            throw new NotImplementedException();
        }
    }
}
