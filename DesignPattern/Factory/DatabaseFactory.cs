using System.Data;

namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType db_Type)
        {
            switch (db_Type)
            {
                case DatabaseType.SqlServer:
                    return new SqlServerDatabase();
                case DatabaseType.Oracle:
                    return new OracleDatabase();
                default:
                    throw new ArgumentException("Wrong database type");
            }

        }
    }
}
