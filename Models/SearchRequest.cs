﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Lab23.Models
{
    public class SearchRequest
    {
        
            [Required]
            [NotNull]
            public string Title { get; set; }

            public MovieGenre Genre { get; set; }
        
    }
}

