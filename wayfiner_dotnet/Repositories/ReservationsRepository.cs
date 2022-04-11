using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using wayfiner_dotnet.Models;

namespace wayfiner_dotnet.Repositories
{
    public class ReservationsRepository
    {
        private readonly IDbConnection _db;

        public ReservationsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal Reservation Create(Reservation reservationData)
        {
            string sql = @"
            INSERT INTO reservations
            (name, tripId, type, confirmationNumber, date, address, cost)
            VALUES
            (@Name, @TripId, @Type, @ConfirmationNumber, @Date, @Address, @Cost);
            SELECT LAST_INSERT_ID();
            ";
            int id = _db.ExecuteScalar<int>(sql, reservationData);
            reservationData.Id = id;
            return reservationData;
        }

        internal List<Reservation> GetAll(int id)
        {
            string sql = @"
            SELECT *
            FROM reservations r
            WHERE r.tripId = @id;
            ";
            return _db.Query<Reservation>(sql, new { id }).ToList();
        }
    }
}