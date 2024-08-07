using BusITLAApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BusITLAApp.Data.Interfaces
{
    public interface IDaoTicket
    {
        List<Ticket> GetTickets();
        Ticket GetTicket(int ticketId);
        void SaveTicket(Ticket ticket);
        void UpdateTicket(Ticket ticket);
        void RemoveTicket(Ticket ticket);
    }
}
