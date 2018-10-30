﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FormAuth.Models
{
    public class UserContext : DbContext
    {
        public UserContext() :
        base("DefaultConnection")
        { }

        public DbSet<User> Users { get; set; }
    }
}