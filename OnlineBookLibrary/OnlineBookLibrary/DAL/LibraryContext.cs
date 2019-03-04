using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OnlineBookLibrary.Models;

namespace OnlineBookLibrary.DAL
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibraryContext")
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}