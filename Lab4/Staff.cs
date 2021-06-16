﻿using System;
using Lab4;

namespace Lab4
{
    public class Staff: Employee
    {
        public string Title { get; set; }
        public override double CalculateBonus()
        {
            return 0.06 * Salary;
        }
        public override int CalculateVacation()
        {
            if (DateHired >= 5 )
            {
                return 4;
            }
            else
            {
                return 3;
            }
        }
    }
}