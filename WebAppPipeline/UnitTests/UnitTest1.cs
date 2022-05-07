using System;
using Xunit;
using Lib;
namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Soma()
        {
            int resultado = Exemplo.Soma(2, 2);

            Assert.Equal(4, resultado);

        }
        [Fact]
        public void Test_Soma2()
        {
            int resultado = Exemplo.Soma(2, 2);

            Assert.Equal(4, resultado);

        }
    }
}
