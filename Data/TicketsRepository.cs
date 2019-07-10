using Alıştırma.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alıştırma.Data
{
    public class TicketsRepository : EFRepository<Ticket>, ITicketRepository
    {
        public TicketsRepository(AppDbContext context) : base(context) { }

    }
}
