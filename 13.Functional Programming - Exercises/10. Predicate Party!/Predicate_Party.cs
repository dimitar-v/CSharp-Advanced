using System;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Predicate_Party
    {
        static void Main(string[] args)
        {
            var partyList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<string, string, bool> startWith = (n, s) => n.StartsWith(s);
            Predicate<string> predicate;
            string command;

            while ((command = Console.ReadLine()) != "Party!")
            {
                var commands = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                predicate = GetPredicate(commands[1], commands[2]);

                switch (commands[0])
                {
                    case "Remove":
                        partyList.RemoveAll(predicate);
                        break;
                    case "Double":
                        var add = partyList.FindAll(predicate);
                        foreach (var a in add)
                        {
                            partyList.Insert(partyList.IndexOf(a), a);
                        }
                        break;
                }
            }

            Console.WriteLine(partyList.Count > 0 
                ? string.Join(", ", partyList) + " are going to the party!" 
                : "Nobody is going to the party!");
        }

        private static Predicate<string> GetPredicate(string predicatName, string value)
        {
            switch (predicatName)
            {
                case "StartsWith":
                    return p => p.StartsWith(value);
                case "EndsWith":
                    return p => p.EndsWith(value);
                case "Length":
                    return p => p.Length == int.Parse(value);
                default:
                    return null;
            }
        }
    }
}
