using Dapper;
using ExcercicioMvc01.Repositoy.Contracts;
using ExcercicioMvc01.Repositoy.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ExcercicioMvc01.Repositoy.Repositories
{
    public class CargoRepository : ICargoRepository
    {
        private readonly string connectionstring;

        public CargoRepository(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        public void Atualizar(Cargo obj)
        {
            var query = @"UPDATE CARGO 
                            SET NOME = @NOME, DESCRICAO = @DESCRICAO";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public Cargo BuscarPorNome(string nome)
        {
            var query = @$"SELECT *
                            FROM CARGO
                            WHERE NOME = @NOME";
            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Cargo>(query, new { nome }).FirstOrDefault();
            }
        }

        public List<Cargo> BuscarTodos()
        {
            var query = @"SELECT *
                            FROM CARGO";
            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Cargo>(query).ToList();
            }
        }

        public Cargo BusrcarPorId(Guid id)
        {
            var query = @"SELECT *
                            FROM CARGO
                            WHERE ID = @ID";
            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Cargo>(query, new { id }).FirstOrDefault();
            }
        }

        public void Excluir(Cargo obj)
        {
            var query = @"DELETE 
                            FROM CARGO 
                            WHERE ID = @ID";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }

        }

        public void Inserir(Cargo obj)
        {
            var query = @"INSERT INTO CARGO(ID, NOME, DESCRICAO)
                            VALUES(@IdCargo, @Nome, @Descricao)";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }
    }
}
