﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTestProject.Models
{
    public class Person
    {
        public string Telephone {get;set;}
        public string CPF { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Old { get; set; }
        public int Id { get; internal set; }
    }
}
