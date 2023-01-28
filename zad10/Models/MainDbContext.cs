using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace zad10.Models
{
    public partial class MainDbContext : DbContext
    {
        public MainDbContext()
        { }

        public MainDbContext(DbContextOptions options)
            : base(options)
        {
        }
        public  DbSet<Student> Students { get; set; }
        public  DbSet<Studia> Studias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
            base.OnConfiguring(optionsBuilder);
        optionsBuilder
               // .UseLazyLoadingProxies()
                .UseSqlServer("Data Source=db-mssql16.pjwstk.edu.pl;Initial Catalog=pd3809;Integrated Security=True");
    }
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Studia>(s =>
            {
                s.HasData(
                    new Studia { IdStudia = 1, Nazwa = "Filozofia",Tryb="Dzienny" },
                    new Studia { IdStudia = 2, Nazwa = "Ekonomia", Tryb = "Dzienny" },
                    new Studia { IdStudia = 3, Nazwa = "Informatyka", Tryb = "Dzienny" }
                    );
            });
            modelBuilder.Entity<Student>(st =>
            {
                st.HasData(

                    new Student { IdStudent = 1, Imie = "Marcin", Nazwisko = "Rawa", NrIndeksu = "11", RokStudiow = 5, IdStudia=1 },
                    new Student { IdStudent = 2, Imie = "Anna", Nazwisko = "Tobiasz", NrIndeksu = "12", RokStudiow = 4, IdStudia = 1 },
                    new Student { IdStudent = 3, Imie = "Marcin", Nazwisko = "Krasuski", NrIndeksu = "13", RokStudiow = 3, IdStudia = 2 },
                    new Student { IdStudent = 4, Imie = "Tomasz", Nazwisko = "Sieciechowicz", NrIndeksu = "14", RokStudiow = 2, IdStudia = 3 }
                    );
            });
        }

        

       
    }
}

