using System.ComponentModel.DataAnnotations.Schema;

namespace mytodolist.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
