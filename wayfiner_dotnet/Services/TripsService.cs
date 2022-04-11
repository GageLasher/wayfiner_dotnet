using System.Collections.Generic;
using wayfiner_dotnet.Models;
using wayfiner_dotnet.Repositories;

namespace wayfiner_dotnet.Services
{
    public class TripsService
    {
        private readonly TripsRepository _tripRepo;

        public TripsService(TripsRepository tripRepo)
        {
            _tripRepo = tripRepo;
        }

        internal Trip Create(Trip tripData)
        {
            return _tripRepo.Create(tripData);
        }

        internal List<Trip> GetAll()
        {
            return _tripRepo.GetAll();
        }
    }
}