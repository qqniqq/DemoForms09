using DemoLib.Data;
using MySql.Data.MySqlClient;

namespace DemoLib.Repositories
{
    public abstract class BaseRepository
    {
        protected MySqlConnection GetConnection()
        {
            return DbConnectionFactory.Create();
        }
    }
}