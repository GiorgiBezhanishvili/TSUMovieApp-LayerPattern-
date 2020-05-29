using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<MovieActors> MovieActors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Movies
            modelBuilder.Entity<Movie>()
                .Property(e => e.Description)
                .HasMaxLength(5000)
                .IsRequired();

            modelBuilder.Entity<Movie>()
               .Property(e => e.Title)
               .HasMaxLength(500)
               .IsRequired();

            modelBuilder.Entity<Movie>()
               .HasOne(e => e.Director)
               .WithMany(e => e.Movies)
               .HasForeignKey(e => e.DirectorId)
               .OnDelete(DeleteBehavior.Restrict);

            //MovieActors
            modelBuilder.Entity<MovieActors>()
                .HasOne(e => e.Actor)
                .WithMany(e => e.MovieActors)
                .HasForeignKey(e => e.PersonId);

            modelBuilder.Entity<MovieActors>()
                .HasOne(e => e.Movie)
                .WithMany(e => e.Actors)
                .HasForeignKey(e => e.MovieId);

            //Persons
            modelBuilder.Entity<Person>()
                .Property(e => e.Firstname)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Person>()
                .Property(e => e.Lastname)
                .HasMaxLength(50)
                .IsRequired();

            //User

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .HasMaxLength(30)
                .IsRequired();

            //Genre
            modelBuilder.Entity<Genres>()
                .Property(e => e.Name)
                .HasMaxLength(50)
                .IsRequired();

            //UserRate
            modelBuilder.Entity<UserRates>()
                .Property(e => e.Score)
                .HasDefaultValue(0)
                .IsRequired();

            modelBuilder.Entity<UserRates>()
                .HasOne(e => e.User)
                .WithMany(e => e.UserRates)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<UserRates>()
               .HasOne(e => e.Movie)
               .WithMany(e => e.Rates)
               .HasForeignKey(e => e.MovieId);

            //MovieGenres
            modelBuilder.Entity<MovieGenres>()
               .HasOne(e => e.Movie)
               .WithMany(e => e.Genres)
               .HasForeignKey(e => e.MovieId);
            modelBuilder.Entity<MovieGenres>()
               .HasOne(e => e.Genre)
               .WithMany(e => e.MovieGenres)
               .HasForeignKey(e => e.GenreId);

            modelBuilder.Seed();

        }
    }
}
