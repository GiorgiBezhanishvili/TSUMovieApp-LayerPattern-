using DAL.Context;
using DAL.Entities;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories
{
    public class MovieActorRepository : RepositoryBase<MovieActors>, IMovieActorRepository
    {
        public MovieActorRepository(MovieDBContext context) : base(context)
        {
        }
    }
}
