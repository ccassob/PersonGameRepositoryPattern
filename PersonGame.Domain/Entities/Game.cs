using PersonGame.Domain.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;

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
                throw new ArgumentNullException("You have to send the name");

            if (string.IsNullOrEmpty(genre))
                throw new ArgumentNullException("You have to send the genre");

            if (rating == 0)
                throw new ArgumentOutOfRangeException("You have to send the rating");

            Name = name;
            Genre = genre;
            Rating = rating;
        }
    }
}