using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAPI.Data.Entitis;

namespace WebApplicationAPI.Data.Repo
{
    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> GetBookingAsync(string userName);
    }
}
