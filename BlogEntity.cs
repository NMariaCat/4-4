﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3.Models
{
    public class BlogEntity
    {
        public string Article { get; set; }
        public string Text { get; set; }
        public List<string> Tags { get; set; }
        public string ImagePath { get; set; }
    }
}
