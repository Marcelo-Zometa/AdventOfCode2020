using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PasswordPhilosophy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting up program.\nCreating list of passwords");

            List<Password> passwordList = generatePasswordList("C:/Users/engr/source/repos/AdventOfCode2020/Day2/PasswordPhilosophy/PasswordPhilosophy/input.txt");

            var countValid = countValidPasswordsPart1(passwordList);
            Console.WriteLine($"Part 1: There were {countValid} valid passwords");
                                 
            countValid = countValidPasswordsPart2(passwordList);
            Console.WriteLine($"Part 2: There were {countValid} valid passwords");
        }

        private static List<Password> generatePasswordList(string path)
        {
            var input = File.ReadAllLines(path);
            List<Password> passwords = new List<Password>();

            foreach(string line in input)
            {                
                var splitLine = line.Replace(" ", ":").Split('-', ':');
                
                var policy = new Policy(splitLine[0], splitLine[1], splitLine[2]);

                var password = new Password(policy, splitLine[4]);

                passwords.Add(password);
            }

            return passwords;
        }
        private static int countValidPasswordsPart1(List<Password> passwordList)
        {
            int count = 0;

            foreach(Password p in passwordList)
            {
                var policy = p._Policy;

                var ocurrances = p._Password.Count(c => c == policy.Character.ToCharArray()[0]);

                if((ocurrances >= policy.MinRepetition) && (ocurrances <= policy.MaxRepetition))
                {
                    count++;
                }
            }

            return count;
        }

        private static int countValidPasswordsPart2(List<Password> passwordList)
        {
            int count = 0;

            foreach (Password p in passwordList)
            {
                var policy = p._Policy;
                var isCharThere = false;
                var password = p._Password;
                
                if (password[policy.MinRepetition - 1] == policy.Character.ToCharArray()[0])
                {
                    isCharThere = !isCharThere;
                }

                if (password[policy.MaxRepetition - 1] == policy.Character.ToCharArray()[0])
                {
                    isCharThere = !isCharThere;
                }

                if (isCharThere)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
