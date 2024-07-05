﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusITLAApp.Data.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string? Title {get; set; }

        public int TicketId { get; set; }

        public string? Description { get; set; }
        public int Credits { get; set; }

    }
}
