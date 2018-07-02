using System;

namespace JefersonDeSouza.AgendamentoDeTarefas.Domain
{
    public class ExecucaoDeAgendamento 
    {
        public string DataExecucao { get; set; }
        public string HorarioExecucao { get; set; }
        public string RepetirExecucao { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}