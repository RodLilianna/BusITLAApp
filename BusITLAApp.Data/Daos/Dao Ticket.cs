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
            CargarDatos();
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
            if (ticket is null)
            {
                throw new ArgumentNullException("El ticket no puede ser nulo");
            }

            ArgumentNullException.ThrowIfNull(ticket.Name, "El nombre de la ruta es requerido.");

            if (ticket.Budget <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(ticket.Budget), "El Budget no puede ser negativo o cero.");
            }
            this.context.Ticket.Update(ticket);
            this.context.SaveChanges();
        }

        private void CargarDatos()
        {
            if(!this.context.Ticket.Any())
            {
                List<Ticket> asientos = new List<Ticket>()
                {
                    new Ticket()
                    {
                        Administrador= 1, Budget = 200, Id = 1, Name = "Ticket 1", StartTime = DateTime.Now
                    },
                    new Ticket()
                    {
                        Administrador= 1, Budget = 500, Id = 2, Name = "Ticket 2", StartTime = DateTime.Now
                    },
                    new Ticket()
                    {
                        Administrador= 1, Budget = 800, Id = 3, Name = "Ticket 3", StartTime = DateTime.Now
                    },
                    new Ticket()
                    {
                        Administrador= 1, Budget = 300, Id = 4, Name = "Ticket 4", StartTime = DateTime.Now
                    }
                };

                this.context.Ticket.AddRange(asientos);
                this.context.SaveChanges();

            }
        }
    }
}
