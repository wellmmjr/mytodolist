using System.ComponentModel.DataAnnotations.Schema;
using mytodolist.Model.Base;

namespace mytodolist.Model
{
    [Table("TaskList")]
    public class ListaTarefa : BaseEntity
    {
        [Column("titulo")]
        public string Titulo { get; set; }

        [Column("data_criacao")]
        public string Criacao { get; set; }

        [Column("enabled")]
        public bool Enabled { get; set; }
    }
}
