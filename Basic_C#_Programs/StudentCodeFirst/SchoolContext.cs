using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace StudentCodeFirst
{
    // SchoolContext is the bridge between C# code and the SQL Server
    public class SchoolContext : DbContext
    {
        //This tells EF Core: "Create a Students table based on the Student class"
        public DbSet<Student> Students { get; set; }

        // It's where EF Core which database server and database name to use
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // tells EF Core to connect to a SQL Server database
            // @ symbol allows backslashes
            optionsBuilder.UseSqlServer(
                @"Server=KASHMIR\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
