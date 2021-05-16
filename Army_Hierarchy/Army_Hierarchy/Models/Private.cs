﻿using Army_Hierarchy.Contracts;

namespace Army_Hierarchy.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary {get; set;}

        public override string ToString()
        {
            return base.ToString() + $"Salary: {this.Salary : f2}";
        }
    }
}
