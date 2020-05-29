using DAL.Context;
using DAL.Entities;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories
{
    public class UserRateRepository : RepositoryBase<UserRates>, IUserRateRepository
    {
        public UserRateRepository(MovieDBContext context) : base(context)
        {
        }
    }
}
