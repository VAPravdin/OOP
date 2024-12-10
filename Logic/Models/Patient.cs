﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Abstractions;

namespace Logic.Models
{
    public class Patient : Identity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Meet> Meets { get; set; }
        public void ScheduleMeet(Meet meet)
        {
            throw new NotImplementedException();
        }
        public void CancelMeet(Meet meet)
        {
            throw new NotImplementedException();
        }
        public List<Meet> GetMeets()
        {
            throw new NotImplementedException();
        }
    }
}