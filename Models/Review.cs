﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string? VoterName { get; set; }
        public int NumStars { get; set; }
        public string? Comment { get; set; }
        public int BookId { get; set; }
    }
}
