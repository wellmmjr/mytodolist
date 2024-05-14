using System.ComponentModel.DataAnnotations.Schema;
using mytodolist.Model.Base;

namespace mytodolist.Model
{
    [Table("task")]
    public class Tarefa : BaseEntity
    {
        [Column("titulo")]
        public string Descricao { get; set; }

        [Column("data_criacao")]
        public string Criacao { get; set; }

        [Column("enabled")]
        public bool Enabled { get; set; }

        [Column("concluded")]
        public bool Concluded { get; set; }
    }
}
