using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace ArraysAndLists
{
    public static class ArraysAndLists
    {
        // 1- When you post a message on Facebook, depending on the number of people who like your
        // post, Facebook returns different information.

        // Write a method that accepts any number of names.
        // Return a string based on the below pattern.
        // If no one likes your post, it returns an empty string.
        // If only one person likes your post, it returns: "[Friend's Name] liked your post."
        // If two people like your post, it returns: "[Friend 1] and [Friend 2] liked your post."
        // If more than two people like your post, it returns: "[Friend 1], [Friend 2] and [Number of Other People] others liked your post."
        public static string FacebookLikes(params string[] names)
        {
            string result = string.Empty;
            //nobody liked
            if (names.Length ==0)
            {
                return null;
            }
            //1 person liked
            else if (names.Length ==1)
            {
                result = $"{names[0]} liked your post.";
            //2 people liked
            else if (names.Length==2)
            }
            {
                result = $"{names[0]} and {names[1]} liked your post.";
            }
            else
                //more than 2 people liked
            {
                result = $"{names[0]}, {names[1]} and {names.Length - 2} others liked your post.";
            }
            return result;
        }

        // 2 - Write a method that accepts any number of integers (minimum of two integers). If an
        // integer is a duplicate, return "Error". If all integers are unique, then order them in
        // ascending order and return the sorted result as a string of integers separated by spaces.
        public static string NumberSorter(params int[] numbers)
        {
            string result = string.Empty;
            var numbersList = numbers.ToList();

            // goes through all the values
            for(int i = 0; i < numbersList.Count; i++)
            {
                for (var j = i + 1; j < numbersList.Count; j++)
                {
                    //checks both i and j for duplicates
                    if (numbersList[i] == numbersList[j])
                    {
                        //if there is a duplicate an error message will return
                        return "Error";
                    }
                }
            }
            numbersList.Sort();

            foreach (var num in numbersList)
            {
                result += num + " ";
            }
            return result.Trim();
        }

        // 3 - Write a method that accepts a string for a name. Use an array to reverse the characters
        // then return the result as a string. "I like trains" should return "sniart ekil I". Return
        // "Error" if no text is inputted.
        public static string ReverseName(string word)
        {
            var result = string.Empty;

            //return error if no message is imputted
            if (word.Length == 0)
            {
                result = "Error";
            }
            else
            {
                //looks for the last position in the array and puts it in reverse
                for (var position = word.Length - 1; position >= 0; position--)
                {
                    result += word[position];
                }
            }
            return result;
        }

        // 4 - Write a method that accepts any number of integers. If none or less than 5 numbers,
        // return "Invalid Array"; otherwise, return the 3 smallest numbers as a string separated by
        // spaces, sorted in ascending order. Treat duplicate numbers normally.
        public static string SmallestNumbers(params int[] numbers)
        {
            var result = string.Empty;
            //if theres less than 5 return "invalid array"
            if (numbers.Length < 5)
            {
                result = "Invalid Array";
            }
            else
            {
                //sorts the numbers in ascending order
                Array.Sort(numbers);
                result = $"{numbers[0]} {numbers[1]} {numbers[2]}";
            }
            
            return result;
        }

        // 5 - Write a method that accepts any number of numbers (assume at least two numbers). The numbers
        // may include duplicates. Return the distinct numbers as an array sorted by ascending order.
        // So for example, an array consisting of [2, 2, 1, 3] should return an integer array of {1, 2, 3}. 
        public static int[] UniqueNumbers(params int[] numbers)
        {
            var numbersList = numbers.ToList();

            //checks value of the list
            for (int i = 0; i < numbersList.Count; i++)
            {   
                //double checks
                for (var j = i + 1; j < numbersList.Count; j++)
                {   
                    // \checks both values for a duplicate 
                    if (numbersList[i] == numbersList[j])
                    {
                        //removes duplicate
                        numbersList.RemoveAt(j);
                        j--;
                    }
                }
            }
            //sort in accending order
            numbersList.Sort();

            return numbersList.ToArray();
        }

        private static class Program
        {
            private static void Main()
            {
                // Use this section to test code should you feel the need.
                // Console.WriteLine(whatever);        
            }
        }
    }
}
