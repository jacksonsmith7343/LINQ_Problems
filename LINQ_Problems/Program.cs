﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            var queryWordsByLetterCombination = wordsList.words.Where(w => w.Contains("th").ToList());
            
        }

        public void ReturnNonDuplicates()
        {
            List<string> names = new List<string> { "Mike", "Brad", "Nevin", "Ian", "Mike" };

            var noDuplicates = names.Distinct();
            foreach (string value in names)
            {
                Console.WriteLine(value);
            }
            
        }

        //3.Using LINQ, write a function that calculates the class grade average after dropping the lowest grade for each student.
        //The function should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), drops the lowest grade 
        //from each string, averages the rest of the grades from that string, then averages the averages.

        List<string> classGrades = new List<string>()
        {
            "80, 100, 92, 89, 65", "93,81,78,84,69", "73,88,83,99,64","98,100,66,74,55"
        };
        //expected output is 86.125


        //4.Write a function that takes in a string of letters (i.e. “Terrill”) and returns an alphabetically ordered string corresponding to the letter frequency (i.e. "E1I1L2R2T1")
    }
}
