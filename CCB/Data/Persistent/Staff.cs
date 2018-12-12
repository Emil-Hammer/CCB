﻿using System;
using System.Collections.Generic;

namespace CCB.Data.Persistent
{
    public partial class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Position { get; set; }
        public DateTime EmployedSince { get; set; }
    }
}