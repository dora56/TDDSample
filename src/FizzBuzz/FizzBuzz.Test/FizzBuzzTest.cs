using System;
using Xunit;
using FluentAssertions;

namespace FizzBuzz.Test
{
    public class FizzBuzzTest
    {
        [Fact(DisplayName = "1を渡すと文字列1を返す")]
        public void Number1ToString()
        {
            // 準備
            var fizzBuzz = new FizzBuzz();
            // 実効

            var actual = fizzBuzz.Convert(1);
            // 検証
            Assert.Equal("1", actual);
        }

        [Fact(DisplayName = "2を渡すと文字列2を返す")]
        public void Number2ToString()
        {
            // 準備
            var fizzBuzz = new FizzBuzz();
            // 実効

            var actual = fizzBuzz.Convert(2);
            // 検証
            Assert.Equal("2", actual);
        }
    }
}