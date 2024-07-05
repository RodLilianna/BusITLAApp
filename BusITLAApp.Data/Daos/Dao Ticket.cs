using BusITLAApp.Data.Context;
using BusITLAApp.Data.Entities;
using BusITLAApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusITLAApp.Data.Daos
{
    public class Dao_Ticket : IDaoTicket
    {
        private readonly BusITLAAppContext context;

        public Dao_Ticket(BusITLAAppContext context) 
        { 
            this.context = context;
        }
        public Ticket GetTicket(int ticketId)
        {
            return this.context.Ticket.Find(ticketId);
        }

        public List<Ticket> GetTickets()
        {
            return this.context.Ticket.ToList();
        }

        public void RemoveTicket(Ticket ticket)
        {
            ArgumentNullException.ThrowIfNull(ticket, "El ticket no puede ser nulo");
            this.context.Ticket.Remove(ticket);
            this.context.SaveChanges();
        }

        public void SaveTicket(Ticket ticket)
        {
            if (string.IsNullOrEmpty(ticket.Name))
            {
                throw new ArgumentNullException("El nombre del departamento no puede ser nulo");
            }

            this.context.Ticket.Add(ticket);
            this.context.SaveChanges();
        }

        public void UpdateTicket(Ticket ticket)
        {
            if (ticket.Budget <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(ticket.Budget), "El Budget no puede ser negativo o cero.");
            }
            this.context.Ticket.Update(ticket);
            this.context.SaveChanges();
        }
    }
}
