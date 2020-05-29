using DAL.Context;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories
{
    public sealed class UOW : IUOW
    {
        private readonly MovieDBContext Context;
        private IMovieRepository _movieRepository;
        public UOW(MovieDBContext context)
        {
            Context = context;
        }

        public IMovieRepository Movie
        {
            get
            {
                if (_movieRepository == null)
                    _movieRepository = new MovieReporitory(Context);
                return _movieRepository;
            }
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
