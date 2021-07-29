using System;
using System.Collections.Generic;
using Linq2;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question can found Here --> https://www.codingame.com/playgrounds/345/c-linq-background-topics/exercise-implement-a-linq-method

            // Some Example to Test Code UnComment the Line you need and Have Fun :P 
            IEnumerable<int> Li = new List<int> { 10, 20, 30 }.Transform(x => x / 10);
            // IEnumerable<int> Li = new List<int> { 7, 11, 15, 19 }.Transform(x => x - 7);
            // IEnumerable<int> Li = new List<int> { 1, 1, 1, 2, 2, 2 }.Transform(x => 20);
            // IEnumerable<int> Li = new List<int> { 1, 2, 3 }.Transform(x => x * 2);


            foreach (var item in Li)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(); // To add new Line after finsh all itreation

        }
    }
}
