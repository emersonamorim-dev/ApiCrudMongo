using System;

namespace ApiCrudMongo.Models
{
    public class Tarefa
    {
        public Tarefa(string nome, string descricao)
        {
            Id = Guid.NewGuid().ToString();
            Nome = nome;
            Descricao = descricao;
            Concluido = false;
            DataCadastro = DateTime.Now;
            DataConclusao = null;
        }

        public string Id { get; private set; }

        public string Nome { get; private set; }

        public string Descricao { get; private set; }

        public bool Concluido { get; private set; }

        public DateTime DataCadastro { get; private set; }


        public DateTime? DataConclusao { get; private set; }

        public void AtualizarTarefa(string nome, string descricao, bool? concluido = false)
        {
            Nome = nome;
            Descricao = descricao;
            Concluido = concluido ?? false;
            DataConclusao = Concluido ? DateTime.Now : null;
        }
    }
}
