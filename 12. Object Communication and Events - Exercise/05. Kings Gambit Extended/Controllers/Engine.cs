namespace _05._Kings_Gambit_Extended.Controllers
{
    using Interfaces;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine : IRunnable
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            var king = this.ReadKing();

            while (true)
            {
                var inputTokens = this.reader.ReadLine().Split();

                if (inputTokens[0] == "End")
                {
                    break;
                }

                ProcessCommand(king, inputTokens);
            }
        }

        private static void ProcessCommand(IKing king, string[] inputTokens)
        {
            switch (inputTokens[0])
            {
                case "Attack":
                    king.GetAttacked();
                    break;

                case "Kill":
                    var subordinateName = inputTokens[1];
                    var subordinate = king.Subordinates.FirstOrDefault(s => s.Name == subordinateName);
                    subordinate.TakeDamage();
                    break;

                default:
                    throw new ArgumentException();
            }
        }

        private IKing ReadKing()
        {
            var kingName = this.reader.ReadLine();
            var king = new King(kingName, new List<ISubordinate>(), this.writer);

            var royalGuardNames = this.reader.ReadLine().Split();
            AddRoyalGuards(king, royalGuardNames);

            var footmanNames = this.reader.ReadLine().Split();
            AddFootmans(king, footmanNames);

            return king;
        }

        private void AddFootmans(King king, string[] footmanNames)
        {
            foreach (var name in footmanNames)
            {
                king.AddSubordinate(new Footman(name, this.writer));
            }
        }

        private void AddRoyalGuards(King king, string[] royalGuardNames)
        {
            foreach (var name in royalGuardNames)
            {
                king.AddSubordinate(new RoyalGuard(name, this.writer));
            }
        }
    }
}