using System;

namespace JefersonDeSouza.AgendamentoDeTarefas.Domain
{
    public class Tarefa
    {
        public int CodTarefa { get; set; }
        public string DescTarefa { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}