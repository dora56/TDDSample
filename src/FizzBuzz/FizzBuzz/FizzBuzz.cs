﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Convert(int num)
        {
            if (num == 3) return "Fizz";
            return  num.ToString();
        }
    }
}
