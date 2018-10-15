using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PersonGame.Domain.Test
{
    public class GameTest
    {
        [Fact]
        public void ReturnGivenValidValues()
        {
            var sale = new Game("GTA V", "Matanza", 5);

            Assert.Equal("GTA V", sale.Name);
            Assert.Equal("Matanza", sale.Genre);
            Assert.Equal(5, sale.Rating);
        }

        [Fact]
        public void ReturnGivenInvalidNameValue()
        {
            Assert.Throws<ArgumentNullException>("You have to send a name", () => new Game("", "Matanza", 5));
            Assert.Throws<ArgumentNullException>("You have to send a name", () => new Game(null, "Matanza", 5));
        }

        [Fact]
        public void ReturnGivenInvalidGenreValue()
        {
            Assert.Throws<ArgumentNullException>("You have to send a genre", () => new Game("GTA V", "", 5));
            Assert.Throws<ArgumentNullException>("You have to send a genre", () => new Game("GTA V", null, 5));
        }

        [Fact]
        public void ReturnGivenInvalidRatingValue()
        {
            Assert.Throws<ArgumentOutOfRangeException>("You have to send a rating between 1 and 5", () => new Game("GTA V", "Matanza", 0));
            Assert.Throws<ArgumentOutOfRangeException>("You have to send a rating between 1 and 5", () => new Game("GTA V", "Matanza", 6));
            Assert.Throws<ArgumentOutOfRangeException>("You have to send a rating between 1 and 5", () => new Game("GTA V", "Matanza", 10));
            Assert.Throws<ArgumentOutOfRangeException>("You have to send a rating between 1 and 5", () => new Game("GTA V", "Matanza", -5));
        }
    }
}
