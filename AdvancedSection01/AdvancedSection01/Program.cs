using System;
using AdvancedSection01.EnumTest;

namespace AdvancedSection01
{
    class Program
    {
        static void Main(string[] args)
        {
            Sex sex = Sex.female;
            Season season = Season.spring;
            Console.WriteLine("sex:"+sex);
            Console.WriteLine("Season:"+season);
        }
    }
}