﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookGenre> BookGenres { get; set; }

    }
}
