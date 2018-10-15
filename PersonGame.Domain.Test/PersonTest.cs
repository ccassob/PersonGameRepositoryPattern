using System;
using Xunit;

namespace PersonGame.Domain.Test
{
    public class PersonTest
    {
        [Fact]
        public void ReturnGivenValidValues()
        {
            var sale = new Person("Juanito Alimaña", 1);

            Assert.Equal("Juanito Alimaña", sale.Name);
            Assert.Equal(1, sale.GameId);
        }

        [Fact]
        public void ReturnGivenInvalidNameValue()
        {
            Assert.Throws<ArgumentNullException>("You have to send a name", () => new Person("", 1));
        }

        [Fact]
        public void ReturnGivenInvalidGameValue()
        {
            Assert.Throws<ArgumentNullException>("You have to send a gameId", () => new Person("Juanito Alimaña", 0));
        }
    }
}