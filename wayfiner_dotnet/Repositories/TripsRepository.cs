using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using wayfiner_dotnet.Models;

namespace wayfiner_dotnet.Repositories
{
    public class TripsRepository
    {
        private readonly IDbConnection _db;

        public TripsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal Trip Create(Trip tripData)
        {
            string sql = @"
            INSERT INTO trips
            (name, creatorId)
            VALUES
            (@Name, @CreatorId);
            SELECT LAST_INSERT_ID();
            ";
            int id = _db.ExecuteScalar<int>(sql, tripData);
            tripData.Id = id;
            return tripData;
        }

        internal List<Trip> GetAll()
        {
            string sql = @"
            SELECT * FROM trips;
            ";
            return _db.Query<Trip>(sql).ToList();
        }
    }
}