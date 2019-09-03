using CardAPI.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CardAPI.Repositorio
{
    public class ProcedureRepositorio
    {
        IConfiguration _configuration;

        public ProcedureRepositorio(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionsStrings").
                GetSection("ProcedureConnection").Value;
            return connection;
        }
        public Procedure GetProcedures(int CodEmpresa, string CodEntidade, int CodProduto)
        {
            var connectionString = this.GetConnection();
            //Procedure procedures = new Procedure();

            using (var con = new SqlConnection(connectionString))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@CodEmpresa", CodEmpresa);
                parametros.Add("@CodEntidade", CodEntidade);
                parametros.Add("@CodProduto", CodProduto);
                var foo = con.QueryFirstOrDefault("dbo.IaraAPI", parametros,
                commandType: CommandType.StoredProcedure);

                return foo;
            }

        }
    }
}
