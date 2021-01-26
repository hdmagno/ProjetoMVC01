using Dapper;
using ExcercicioMvc01.Repositoy.Contracts;
using ExcercicioMvc01.Repositoy.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ExcercicioMvc01.Repositoy.Repositories
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        private readonly string connectionstring;

        public DepartamentoRepository(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        public void Atualizar(Departamento obj)
        {
            var query = @"UPDATE DEPARTAMENTO SET NOME = @NOME, DESCRICAO = @DESCRICAO";

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public Departamento BuscarPorNome(string nome)
        {
            var query = @$"SELECT *
                            FROM DEPARTAMENTO
                            WHERE NOME = @NOME";
            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Departamento>(query, new { nome }).FirstOrDefault();
            }
        }

        public List<Departamento> BuscarTodos()
        {
            var query = @$"SELECT *
                            FROM DEPARTAMENTO";
            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Departamento>(query).ToList();
            }
        }

        public Departamento BusrcarPorId(Guid id)
        {
            var query = @$"SELECT *
                            FROM DEPARTAMENTO
                            WHERE ID = @ID";
            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Departamento>(query, new { id }).FirstOrDefault();
            }
        }

        public void Excluir(Departamento obj)
        {
            var query = @"DELETE
                            FROM DEPARTAMENTO
                            WHERE ID = @ID";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public void Inserir(Departamento obj)
        {
            var query = @"INSERT INTO DEPARTAMENTO(ID, NOME, DESCRICAO)
                            VALUES(@ID, @NOME, @DESCRICAO)";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }
    }
}
