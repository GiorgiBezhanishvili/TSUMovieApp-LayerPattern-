﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Genres
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<MovieGenres> MovieGenres { get; set; }
    }
}
