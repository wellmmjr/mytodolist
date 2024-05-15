using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace mytodolist.Data.DTO
{
    public class TarefaDTO
    {

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("criacao")]
        public DateTime DataCriacao { get; set; }

        [JsonPropertyName("ativa")]
        public bool Enabled { get; set; }

        [JsonPropertyName("concluida")]
        public bool Concluded { get; set; }


    }
}
