﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ViaVarejo.Domain.Entity
{
    public class Friend
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }
    }
}
