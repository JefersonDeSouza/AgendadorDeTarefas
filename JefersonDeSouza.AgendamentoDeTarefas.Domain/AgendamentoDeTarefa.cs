using System;

namespace JefersonDeSouza.AgendamentoDeTarefas.Domain
{
    public abstract class AgendamentoDeTarefa
    {
        public long CodAgendamentoDeTarefa { get; set; }
        public Tarefa Tarefa { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; }

        public AgendamentoDeTarefa()
        {
            Tarefa = new Tarefa();
            DataCriacao = DateTime.Now;
            Ativo = true;
        }
        
        public abstract void ConfigurarAgendamento();
    }
}