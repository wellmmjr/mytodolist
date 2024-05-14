using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace mytodolist.Data.DTO
{
    public class ListaTarefaDTO
    {

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("criacao")]
        public string DataCriacao { get; set; }

        [JsonPropertyName("ativa")]
        public bool Enabled { get; set; }


    }
}
