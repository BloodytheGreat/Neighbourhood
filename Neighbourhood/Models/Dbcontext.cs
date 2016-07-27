using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Neighbourhood.Models
{
    public class AccDbcontext : DbContext
    {
        public DbSet<Account> acc { get; set; }
    }
    public class TskDbcontext : DbContext
    {
        public DbSet<Task> tsk { get; set; }
    }
}