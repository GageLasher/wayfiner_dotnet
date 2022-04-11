using System.Collections.Generic;
using wayfiner_dotnet.Models;
using wayfiner_dotnet.Repositories;

namespace wayfiner_dotnet.Services
{
    public class ReservationsService
    {
        private readonly ReservationsRepository _reservationRepo;

        public ReservationsService(ReservationsRepository reservationRepo)
        {
            _reservationRepo = reservationRepo;
        }

        internal Reservation Create(Reservation reservationData)
        {
            return _reservationRepo.Create(reservationData);
        }

        internal List<Reservation> GetAll(int id)
        {
            return _reservationRepo.GetAll(id);
        }
    }
}