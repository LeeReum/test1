using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Xml.Linq;

namespace FitstProgram
{
    class SDA
    {
        public int[] SelectEven(int[] input)
        {
            return (from item in input
                    where item % 2 == 0
                    select item).ToArray<int>();
        }

        public List<int> SelectEven2(List<int> input)
        {
            return (from item in input
                    where item % 2 == 0
                    select item).ToList<int>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}