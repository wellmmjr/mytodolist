using mytodolist.Model.Context;
using mytodolist.Repository.Generic;
using System;
namespace mytodolist.Repository.ListaTarefas
{
    public class ListaTarefaRepository : GenericRepository<Model.ListaTarefa>, IListaTarefaRepository
    {
        public ListaTarefaRepository(MySQLContext context) : base(context) { }

        
                
    }
}
