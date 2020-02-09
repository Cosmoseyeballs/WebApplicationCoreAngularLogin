﻿using System;
using System.Collections.Generic;

namespace WebApplicationCoreAngularLogin.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public int? PublishedYear { get; set; }
        public decimal? Price { get; set; }
    }
}
