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
    public class FlightReservationRepository : IRepository<FlightReservation>
    {
        private readonly string _connectionString;

        public FlightReservationRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        }

        public FlightReservation Get(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return connection.QueryFirstOrDefault<FlightReservation>("SELECT * FROM FlightReservation WHERE flightid = @id", new { id });
            }
        }

        public void Create(FlightReservation reservation)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("INSERT INTO FlightReservation(userid, flightid, date, expirationDate) VALUES (@UserId, @FlightId, @Date, @ExpirationDate)", reservation);
            }
        }

        public void Update(FlightReservation reservation)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("UPDATE FlightReservation SET userid = @UserId, flightid = @FlightId, date = @Date, expirationDate = @ExpirationDate WHERE flightid = @Id", reservation);
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("DELETE FROM FlightReservation WHERE flightid = @id", new { id });
            }
        }
    }
}
