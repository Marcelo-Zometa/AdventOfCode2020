using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordPhilosophy
{
    public class Policy
    {
        public int MinRepetition { get; set; }
        public int MaxRepetition { get; set; }
        public string Character { get; set; }

        public Policy(string min, string max, string character)
        {
            MinRepetition = Int32.Parse(min);
            MaxRepetition = Int32.Parse(max);
            Character = character;
        }

    }
}
