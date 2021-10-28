using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWP_1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class Sage
    {
        //Sage(IdSage, name, age, photo, city)
        [Key]
        public int IdSage { get; set; }
        public String name { get; set; }
        public int age { get; set; }
        public int photo { get; set; }
        public String city { get; set; }
        public List<SageBook> SageBooks { get; set; }


    }
    class Book
    {
        //Book(IdBook, name, description)
        [Key]
        public int IdBook { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public List<SageBook> SageBooks { get; set; }

    }
    class SageBook
    {
        //SageBook(idSage, idBook).
        [Key]
        public int idSage { get; set; }
        public int idSage_sage { get; set; }
        public Sage Sage { get; set; }
        public int IdBook { get; set; }
        public Book Book { get; set; }



    }
    class SageBookContext : DbContext
    {
        //public DbSet<Sage> Sages 
        public DbSet<Sage> Sages { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<SageBook> SageBooks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=l1db;Trusted_Connection=True;");

        }
    }
}

