﻿using ApiCrudMongo.Models;
using System.Collections.Generic;

namespace ApiCrudMongo.Data.Repositories
{
    public interface ITarefasRepository
    {
        void Adicionar(Tarefa tarefa);

        void Atualizar(string id, Tarefa tarefaAtualizada);

        IEnumerable<Tarefa> Buscar();

        Tarefa Buscar(string id);

        void Remover(string id);
    }
}
