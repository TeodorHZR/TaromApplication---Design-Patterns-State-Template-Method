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
    public class FlightRepository : IRepository<Flight>
    {
        private readonly string _connectionString;

        public FlightRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        }

        public Flight Get(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return connection.QueryFirstOrDefault<Flight>("SELECT * FROM [Flight] WHERE flightid = @id", new { id });
            }
        }

        public void Create(Flight flight)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("INSERT INTO [Flight]([from], [to], [date], [price]) VALUES (@From, @To, @Date, @Price)", flight);
            }
        }

        public void Update(Flight flight)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("UPDATE [Flight] SET [from] = @From, [to] = @To, [date] = @Date, [price] = @Price WHERE flightid = @FlightId", flight);
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("DELETE FROM [Flight] WHERE flightid = @id", new { id });
            }
        }
        public bool FlightExists(string from, string to, DateTime date, decimal price)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = connection.Query<int>(
                    "SELECT COUNT(*) FROM [Flight] WHERE [From] = @from AND [To] = @to AND [Date] = @date AND [Price] = @price",
                    new { from, to, date, price }).FirstOrDefault();

                return result > 0;
            }
        }
        public bool FlightExistsById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = connection.Query<int>(
                    "SELECT COUNT(*) FROM [Flight] WHERE [flightid] = @id",
                    new { id }).FirstOrDefault();

                return result > 0;
            }
        }
        public List<Flight> GetAllFlights()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return connection.Query<Flight>("SELECT * FROM [Flight]").ToList();
            }
        }


    }
}
