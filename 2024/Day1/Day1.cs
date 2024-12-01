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
            int distanceTotal = 0;

            StreamReader reader = new StreamReader("../../../2024/Day1/Input.txt");
            string currentLine;

            ArrayList leftList = new ArrayList();
            ArrayList rightList = new ArrayList();
            int[] leftArray;
            int[] rightArray;

            // Part one
            while ((currentLine = reader.ReadLine()) != null)
            {
                // Spit into two halves
                string[] splitString = currentLine.Split(" ");
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
            // Convert arrayList to array
            leftArray = leftList.ToArray(typeof(int)) as int[];
            rightArray = rightList.ToArray(typeof(int)) as int[];
            // Check distance
            for (int i = 0; i < leftArray.Length; i++)
            {
                //Console.WriteLine(leftArray[i] + " " + rightArray[i]);
                // add distance to total
                distanceTotal += Math.Abs(leftArray[i] - rightArray[i]);
            }
            Console.WriteLine("Distance total: " + distanceTotal);

            // Part two
            int xOfSameNumber = 0;
            int similarityScore = 0;
            for (int i = 0; i < leftArray.Length - 1; i++)
            {
                xOfSameNumber = 0;
                for (int j = 0; j < rightArray.Length; j++)
                {
                    if (rightArray[i] == leftArray[j]) {
                        xOfSameNumber++;
                    }
                }
                similarityScore += rightArray[i] * xOfSameNumber;
            }
            Console.WriteLine("Similarity Score: " + similarityScore);
        }
    }
}
