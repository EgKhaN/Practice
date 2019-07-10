using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Alıştırma.Models;
using Ticket = Alıştırma.Models.Ticket;
using Alıştırma.Data;

namespace Alıştırma.Controllers
{
    public class TicketController : Controller
    {
        ITicketRepository _ticketRepository;
        public TicketController(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewTickets()
        {
            
            List<Ticket> tickets = _ticketRepository.GetAll().ToList();

            return View(tickets);
        }
    }
}