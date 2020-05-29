using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public static class DatabaseInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Person
            modelBuilder.Entity<Person>()
               .HasData(
                   new Person
                   {
                       Id = 1,
                       Firstname = "Margot",
                       Lastname = "Robbie"
                   },
                   new Person
                   {
                       Id = 2,
                       Firstname = "Leonardo",
                       Lastname = "Dicaprio"
                   },
                   new Person
                   {
                       Id = 3,
                       Firstname = "Bred",
                       Lastname = "Pitt"
                   },
                   new Person
                   {
                       Id = 4,
                       Firstname = "Quentin",
                       Lastname = "Tarantino"
                   }
               );
            #endregion

            #region Genres
            modelBuilder.Entity<Genres>()
                .HasData(
                new Genres 
                {
                    Id = 1,
                    Name = "Political"
                },
                new Genres
                {
                    Id = 2,
                    Name = "Philosophical"
                },
                new Genres
                {
                    Id = 3,
                    Name = "Science fiction"
                },
                new Genres
                {
                    Id = 4,
                    Name = "Western"
                },
                new Genres
                {
                    Id = 5,
                    Name = "Absurdist"
                },
                new Genres
                {
                    Id = 6,
                    Name = "Paranoid fiction"
                },
                new Genres
                {
                    Id = 7,
                    Name = "Horror"
                },
                new Genres
                {
                    Id = 8,
                    Name = "Comedy"
                });
            // ფილმების ჟანრები ჩემი სტიქიაა :დდ
            #endregion
        }

    }
}
