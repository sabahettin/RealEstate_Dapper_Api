using Microsoft.Data.SqlClient;
using System.Data;

namespace RealEstate_Dapper_Api.Models.DapperContext
{
    public class ApplicationDbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("connection");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
