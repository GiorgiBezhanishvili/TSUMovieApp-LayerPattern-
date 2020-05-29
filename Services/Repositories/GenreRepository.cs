using DAL.Context;
using DAL.Entities;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories
{
    public class GenreRepository : RepositoryBase<Genres>,IGenreRepository
    {
        public GenreRepository(MovieDBContext context) : base(context)
        {
        }
    }
}
