using System;
using Xunit;
using FluentAssertions;
using CalculatorOperators;

namespace web_api.test
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(123, 321, 444)]
        public void AddTesting(int n1, int n2, int expectedResult)
        {
            Calculator.Add(n1, n2)
                .Should()
                .Be(expectedResult, $"O resultado esperado {expectedResult} não foi obtido.");
                
        }
    }
}
