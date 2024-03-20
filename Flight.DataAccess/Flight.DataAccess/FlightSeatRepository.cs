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
    public class FlightSeatRepository : IRepository<FlightSeat>
    {
        private readonly string _connectionString;

        public FlightSeatRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }

        public FlightSeat Get(int seatId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return connection.QueryFirstOrDefault<FlightSeat>("SELECT * FROM FlightSeat WHERE seatid = @seatId", new { seatId });
            }
        }

        public void Create(FlightSeat seat)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("INSERT INTO FlightSeat(flightid, isFree) VALUES (@FlightId, @IsFree)", seat);
            }
        }

        public void Update(FlightSeat seat)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("UPDATE FlightSeat SET flightid = @FlightId, isFree = @IsFree WHERE seatid = @seatId", seat);
            }
        }

        public void Delete(int seatId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("DELETE FROM FlightSeat WHERE seatid = @seatId", new { seatId });
            }
        }

        public void DeleteByFlightId(int flightId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("DELETE FROM FlightSeat WHERE flightid = @flightId", new { flightId });
            }
        }

        public bool IsSeatFree(int seatId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                int isFree = connection.QueryFirstOrDefault<int>("SELECT isFree FROM FlightSeat WHERE seatid = @seatId", new { seatId });
                return isFree == 1;
            }
        }

        public List<FlightSeat> GetAllSeats(int flightId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return connection.Query<FlightSeat>("SELECT * FROM FlightSeat WHERE flightid = @flightId", new { flightId }).ToList();
            }
        }

        public void BookSeat(int userId, int flightId, int seatId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("INSERT INTO UserFlightSeat(userId, flightId, seatId, price) VALUES (@UserId, @FlightId, @SeatId, 100)",
                    new { UserId = userId, FlightId = flightId, SeatId = seatId });
            }
        }
    }
}