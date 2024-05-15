using System.ComponentModel.DataAnnotations.Schema;
using mytodolist.Model.Base;

namespace mytodolist.Model
{
    [Table("task")]
    public class Tarefa : BaseEntity
    {
        [Column("description")]
        public string Descricao { get; set; }

        [Column("dtcreate")]
        public DateTime Criacao { get; set; }

        [Column("enabled")]
        public bool Enabled { get; set; }

        [Column("concluded")]
        public bool Concluded { get; set; }
    }
}
