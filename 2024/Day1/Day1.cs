using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace AdventOfCode.Day1{
    internal class Day1{
        static void Main(string[] args){
            int total = 0;
            // Init reader
            StreamReader reader = new StreamReader("../../../2024/Day1/Input.txt");
            int readerLength = File.ReadAllLines("../../../2024/Day1/Input.txt").Length;
            string currentLine;
            ArrayList leftList = new ArrayList();
            ArrayList rightList = new ArrayList();
            while ((currentLine = reader.ReadLine()) != null)
            {
                string[] splitString = currentLine.Split(" ");
                // Spit into two halves
                // Index 0 first num, index 3 second num
                int firstNumber = Int32.Parse(splitString[0]);
                int secondNumber = Int32.Parse(splitString[3]);
                // Add each number to its list
                leftList.Add(firstNumber);
                rightList.Add(secondNumber);
            }
            // sort arraylist
            leftList.Sort();
            rightList.Sort();
            // Convert to array
            int[] leftArray = leftList.ToArray(typeof(int)) as int[];
            int[] rightArray = rightList.ToArray(typeof(int)) as int[];
            // Check distance
            for (int i = 0; i < leftArray.Length; i++)
            {
                Console.WriteLine(leftArray[i] + " " + rightArray[i]);
                // add distance to total
                total += Math.Abs(leftArray[i] - rightArray[i]);
            }
            Console.WriteLine("Final total: " + total);
            
        }
    }
}
