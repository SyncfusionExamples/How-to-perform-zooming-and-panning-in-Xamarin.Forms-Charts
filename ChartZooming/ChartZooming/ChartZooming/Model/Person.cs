﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChartZooming.Model
{
    public class Person
    {
        public string Name { get; set; }

        public double Height { get; set; }

        public Person(string name, double height)
        {
            this.Name = name;
            this.Height = height;
        }
    }
}
