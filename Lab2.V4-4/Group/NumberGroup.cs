namespace Lab2
{

    public class NumberGroup
    {
        public string CodeSpecialty { get; }
        public int Number { get; }

        public NumberGroup() : this(Specialty.Enrollee, 0)  {  }

        public NumberGroup(Specialty specialty, int number)
        {
            CodeSpecialty = specialty.ToString().Substring(0, 3);
            Number = number;
        }

        public override string ToString() => $"{CodeSpecialty}-{Number}";
    }
}
