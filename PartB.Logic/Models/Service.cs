﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB.Logic.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void UpdateService(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}