﻿using System;

namespace Lab2
{

    public class NumberGroup
    {
        public string CodeSpecialty { get; set; }
        public int Number { get; }

        public NumberGroup(Specialty specialty, int number)
        {
            CodeSpecialty = specialty.ToString().Substring(0, 3);
            Number = Int32.Parse(number.ToString().Substring(2));
        }

        public NumberGroup(NumberGroup numberGroup, int number)
        {
            CodeSpecialty = numberGroup.ToString();
            Number = number;
        }

        public override string ToString() => $"{CodeSpecialty}{Number}";
    }
}
