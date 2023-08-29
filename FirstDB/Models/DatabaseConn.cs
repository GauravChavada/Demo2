using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstDB.Models
{
    public class DatabaseConn : DbContext
    {
        public DatabaseConn() : base("DbConn")
        {

        }
        public DbSet<ComputerModel> Computers { get; set; }
    }
}