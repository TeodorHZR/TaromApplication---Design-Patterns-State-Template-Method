using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.DataAccess
{
    public class UserRepository : IRepository<User>
    {
        private readonly string _connectionString;

        public UserRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        }

        public User Get(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return connection.QueryFirstOrDefault<User>("SELECT * FROM [User] WHERE userid = @id", new { id });
            }
        }
        public int GetID(string username, string password)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return connection.QueryFirstOrDefault<int>("SELECT userid FROM [User] WHERE username = @username AND password = @password", new { username, password });
            }
        }
        public string GetUserTypeById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return connection.QueryFirstOrDefault<string>("SELECT tip FROM [User] WHERE userid = @id", new { id });
            }
        }


        public void Create(User user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("INSERT INTO [User](username, password, tip) VALUES (@Username, @Password, @Tip)", user);
            }
        }

        public void Update(User user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("UPDATE [User] SET username = @Username, password = @Password, tip = @Tip WHERE userid = @Id", user);
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("DELETE FROM [User] WHERE userid = @id", new { id });
            }
        }
    }
}
