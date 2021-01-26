using System;
using System.Collections.Generic;
using System.Text;

namespace ExcercicioMvc01.Repositoy.Contracts
{
    public interface IBaseRepository<T>
    {
        void Inserir(T obj);
        void Atualizar(T obj);
        void Excluir(T obj);
        List<T> BuscarTodos();
        T BusrcarPorId(Guid id);
        T BuscarPorNome(string nome);
    }
}
