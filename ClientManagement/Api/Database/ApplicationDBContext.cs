﻿using System;
using Microsoft.EntityFrameworkCore;

namespace Api
{
    public class ApplicationDBContext : DbContext
    {
       public DbSet<Client> Clients { get; set; }
       public DbSet<Email> Emails { get; set; }
       public DbSet<Address> Addresses { get; set; }
       public DbSet<Phone> Phones { get; set; }



        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options) { }
    }
}
