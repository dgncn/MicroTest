﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApi.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
