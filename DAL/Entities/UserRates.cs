using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class UserRates
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public double Score { get; set; }
        public Movie Movie { get; set; }
        public User User { get; set; }
    }
}
