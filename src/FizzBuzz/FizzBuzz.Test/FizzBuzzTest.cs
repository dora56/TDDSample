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
            // 実効 & 検証
            Assert.Equal("1", fizzBuzz.Convert(1));
        }

        [Fact(DisplayName = "2を渡すと文字列2を返す")]
        public void Number2ToString()
        {
            // 準備
            var fizzBuzz = new FizzBuzz();
            // 実効 & 検証
            Assert.Equal("2", fizzBuzz.Convert(2));
        }

        [Fact(DisplayName = "3を渡すと文字列Fizzを返す")]
        public void Number3ToFizz()
        {
            // 準備
            var fizzBuzz = new FizzBuzz();
            // 実効 & 検証
            Assert.Equal("Fizz", fizzBuzz.Convert(3));
        }
    }
}