using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAPI.Data.Repo
{
    public interface IUnitOfWork
    {
        IBookingRepository BookingRepository { get; }
    }
}
