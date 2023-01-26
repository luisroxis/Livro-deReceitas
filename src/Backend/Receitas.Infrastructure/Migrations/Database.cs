using Dapper;
using MySqlConnector;

namespace Receitas.Infrastructure.Migrations;

public static class Database
{
    public static void CreateDatabse(string connectionString, string databaseName)
    {
        using var connection = new MySqlConnection(connectionString);

        var parameters = new DynamicParameters();
        
        parameters.Add("@databaseName", databaseName);

        var register = connection.Query("SELECT * FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @databaseName", parameters);

        if (!register.Any())
        {
            
        }
    }
    
}