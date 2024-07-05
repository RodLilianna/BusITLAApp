using BusITLAApp.Data.Entities;
using BusITLAApp.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusITLAApp.Web.Controllers
{
    public class TicketController : Controller
    {
        private readonly IDaoTicket daoTicket;
        public TicketController(IDaoTicket daoTicket) 
        {
            this.daoTicket = daoTicket;
        }
        // GET: TicketController
        public ActionResult Index()
        {
            var ticket = this.daoTicket.GetTickets();
            return View(ticket);
        }

        // GET: TicketController/Details/5
        public ActionResult Details(int id)
        {
            var ticket = this.daoTicket.GetTicket(id);
            return View(ticket);
        }

        // GET: TicketController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TicketController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ticket ticket)
        {
            try
            {
                this.daoTicket.SaveTicket(ticket);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TicketController/Edit/5
        public ActionResult Edit(int id)
        {
            var ticket = this.daoTicket.GetTicket(id);
            return View(ticket);
        }

        // POST: TicketController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Ticket ticket)
        {
            try
            {
                this.daoTicket.UpdateTicket(ticket);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
