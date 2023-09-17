using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services
{
    public class ReservationService:IReservationService
    {
       public ReservationDTO GetReservationById(int BkgNumber)
        {
            return new ReservationDTO
            {
                Id = ( new Random()).Next(100),
                Amount = (new Random()).Next(10000),
                BkgDate = DateTime.Now,
                BkgNumber = BkgNumber,
                CheckinDate = DateTime.Now.AddDays(30),
                CheckoutDate = DateTime.Now.AddDays(37)
            };
        }
    }
}
