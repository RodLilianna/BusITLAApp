﻿using BusITLAApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusITLAApp.Data.Context
{
    public class BusITLAAppContext: DbContext
    {
        public BusITLAAppContext(DbContextOptions<BusITLAAppContext> options) : base(options)
        {

        }


        public DbSet<Ticket> Ticket { get; set; }
    }
}
