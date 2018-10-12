using PersonGame.Domain.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;

namespace PersonGame.Domain
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public Game Game { get; set; }

        public int GameId { get; set; }

        public Person(string name, int gameId)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("You have to send a name");

            if (gameId == 0)
                throw new ArgumentNullException("You have to send a Game Id");


            Name = name;
            GameId = gameId;
        }
    }
}