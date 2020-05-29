using DAL.Context;
using DAL.Entities;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories
{
    public class MovieGenreRepository : RepositoryBase<MovieGenres>, IMovieGenreRepository
    {
        public MovieGenreRepository(MovieDBContext context) : base(context)
        {
        }
    }
}
