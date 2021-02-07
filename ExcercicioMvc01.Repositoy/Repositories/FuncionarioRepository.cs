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

        public List<Funcionario> BuscarPorNome(string nome)
        {
            var query = @$"SELECT *
                            FROM FUNCIONARIO f
                            INNER JOIN CARGO c
                            ON c.ID = f.ID_CARGO
                            INNER JOIN DEPARTAMENTO d
                            ON d.ID = f.ID_DEPARTAMENTO
                            WHERE f.NOME LIKE @NOME";
            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query(query, 
                    (Funcionario f, Cargo c, Departamento d) =>
                {
                    f.Cargo = c;
                    f.Departamento = d;
                    return f;
                },
                    new { @NOME = $"%{nome}%" },
                    splitOn: "Id_Cargo, Id_Departamento"
                    )
                    .ToList();
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
            var query = @"INSERT INTO FUNCIONARIO(ID, NOME, SALARIO, ID_CARGO, ID_DEPARTAMENTO)
                            VALUES(@IDFUNCIONARIO, @NOME, @SALARIO, @IdCargo, @IdDepartamento)";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }
    }
}
