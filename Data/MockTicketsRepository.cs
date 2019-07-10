using Alıştırma.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alıştırma.Data
{
    public class MockTicketsRepository : EFRepository<Ticket> ,ITicketRepository
    {
        public MockTicketsRepository(AppDbContext context) : base(context) { }

        public override IQueryable<Ticket> GetAll()
        {
            List<Ticket> tickets = new List<Ticket>()
            {
                new Ticket{Id = 1 , Title = "Title 1" , Description = "Description 1"},
                new Ticket{Id = 2 , Title = "Title 2" , Description = "Description 2"},
                new Ticket{Id = 3 , Title = "Title 3" , Description = "Description 3"},
                new Ticket{Id = 4 , Title = "Title 4" , Description = "Description 4"},
                new Ticket{Id = 5 , Title = "Title 5" , Description = "Description 5"},
            };
            return tickets.AsQueryable();
        }

    }
}
