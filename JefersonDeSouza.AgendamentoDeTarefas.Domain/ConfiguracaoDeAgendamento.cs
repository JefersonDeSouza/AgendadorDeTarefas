using System;

namespace JefersonDeSouza.AgendamentoDeTarefas.Domain
{
    public class ConfiguracaoDeAgendamento 
    {
        public AgendamentoDeTarefa Agendamento { get; set; }
        public bool ExecucaoContinua { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }

        public void GravarAgendamento()
        {
            //TODO: Aqui vai a lógica para gravar os agendamentos na tabela de ExecucaoDeAgendamento
            // new ExecucaoDeAgendamento();
        }
    }
}