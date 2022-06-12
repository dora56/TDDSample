using System;
using Xunit;
using FluentAssertions;

namespace FizzBuzz.Test
{
    public class FizzBuzzTest
    {
        [Fact(DisplayName = "1を渡すと文字列1を返す")]
        public void NumberToString()
        {
            // 準備
            var fizzBuzz = new FizzBuzz();
            // 実効

            var actual = fizzBuzz.Convert(1);
            // 検証
            Assert.Equal("1", actual);
        }
    }
}