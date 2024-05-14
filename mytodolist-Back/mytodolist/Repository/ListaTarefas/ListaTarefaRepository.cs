using mytodolist.Model.Context;
using mytodolist.Repository.Generic;
using System;
namespace mytodolist.Repository.ListaTarefas
{
    public class ListaTarefaRepository : GenericRepository<Model.ListaTarefa>, IListaTarefaRepository
    {
        public ListaTarefaRepository(MySQLContext context) : base(context) { }

        public Model.ListaTarefa AtivarListaTarefa(long id)
        {
            if (!_context.People.Any(p => p.Id.Equals(id))) return null;

            var lista = _context.People.SingleOrDefault(p => p.Id.Equals(id));

            if (lista != null)
            {
                lista.Enabled = !lista.Enabled;

                try
                {
                    _context.Entry(lista).CurrentValues.SetValues(lista);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }
                
    }
}
