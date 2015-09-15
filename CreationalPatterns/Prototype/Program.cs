﻿namespace Prototype
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var developer = new Developer("Pesho", 21);
            var designer = new Designer("Gosho", 22);
            var teamLeader = new TeamLeader("Niki", 23);
            teamLeader.Team.Add(developer);
            teamLeader.Team.Add(designer);
            Console.WriteLine("ACTUAL");
            Console.WriteLine(teamLeader);

            var terminatorClone = teamLeader.Clone();
            developer.Name = "Pesho Changed";
            designer.Name = "Gosho Changed";
            teamLeader.Name = "Niki Changed";
            Console.WriteLine("ACTUAL");
            Console.WriteLine(teamLeader);
            Console.WriteLine("CLONE");
            Console.WriteLine(terminatorClone);
        }
    }
}
