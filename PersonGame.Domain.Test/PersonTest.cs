using System;
using Xunit;

namespace PersonGame.Domain.Test
{
    public class PersonTest
    {
        [Fact]
        public void ReturnGivenValidValues()
        {
            var sale = new Person("Juanito Alima�a", 1);

            Assert.Equal("Juanito Alima�a", sale.Name);
            Assert.Equal(1, sale.GameId);
        }
    }
}
