using PersonGame.Domain.SharedKernel;
using System;

namespace PersonGame.Domain
{
    public class Game : BaseEntity
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public decimal Rating { get; set; }

        public Game(string name, string genre, decimal rating)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("You have to send a name");

            if (string.IsNullOrEmpty(genre))
                throw new ArgumentNullException("You have to send a genre");

            if (rating < 1 || rating > 5)
                throw new ArgumentOutOfRangeException("You have to send a rating between 1 and 5");

            Name = name;
            Genre = genre;
            Rating = rating;
        }
    }
}