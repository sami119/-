﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Part
    {
        //some private variables
        private string name;
        private double price;

        //public variables with get and set method
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 5)
                {
                    throw new FormatException("Invalid part name!");
                }
                else { this.name = value; }
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("Price should be positive!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        //constructors
        public Part(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public Part(string name)
        {
            this.name = name;
            this.price = 25;
        }

        //ToString method
        public override string ToString()
        {
            return string.Format("-> {0} - {1:F2}", this.name, this.price);
        }
    }
}
