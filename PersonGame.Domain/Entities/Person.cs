using PersonGame.Domain.SharedKernel;
using System;

namespace PersonGame.Domain
{
    public class Person : BaseEntity<int>
    {
        public string Name { get; set; }
        public Game Game { get; set; }

        public int GameId { get; set; }

        public Person(string name, int gameId)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("You have to send a name");

            if (gameId < 1)
                throw new ArgumentNullException("You have to send a gameId");

            Name = name;
            GameId = gameId;
        }
    }
}