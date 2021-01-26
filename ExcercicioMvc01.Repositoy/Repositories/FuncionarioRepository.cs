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
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly string connectionstring;

        public FuncionarioRepository(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        public void Atualizar(Funcionario obj)
        {
            var query = @"UPDATE FUNCIONARIO 
                            SET NOME = @NOME, SALARIO = @SALARIO, DATAADMISSAO = @DATAADMISSAO
                            WHERE ID = @ID";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public Funcionario BuscarPorNome(string nome)
        {
            var query = @$"SELECT *
                            FROM FUNCIONARIO
                            WHERE NOME = @NOME";
            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Funcionario>(query, new { nome }).FirstOrDefault();
            }
        }

        public List<Funcionario> BuscarTodos()
        {
            var query = @"SELECT *
                            FROM FUNCIONARIO";
            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Funcionario>(query).ToList();
            }
        }

        public Funcionario BusrcarPorId(Guid id)
        {
            var query = @"SELECT *
                            FROM FUNCIONARIO
                            WHERE ID = @ID";
            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Funcionario>(query, new { id }).FirstOrDefault();
            }
        }

        public void Excluir(Funcionario obj)
        {
            var query = @$"DELETE 
                            FROM FUNCIOINARIO
                            WHERE ID = @ID";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public void Inserir(Funcionario obj)
        {
            var query = @"INSERT INTO FUNCIONARIOS(ID, NOME, SALARIO, DATAADMISSAO, IDCARGO, IDDEPARTAMENTO)
                            VALUES(@ID, @NOME, @SALARIO, @DATAADMISSAO, @IDCARGO, @IDDEPARTAMENTO)";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }
    }
}
