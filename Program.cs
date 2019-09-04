using System;
using System.Collections.Generic; 

namespace Collections_Practice
{
    class Program 
    {
        static void Main(string[] args) //this is the main function declaration
        {
            //Three Basic Arrays
            // create an array to hold interger values 0 through 9
            int [] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            // int is the "data type", [] shows this is an array, "arr" is the variable name

            // create an array of the names "Tim", "Martin", "Nikki", and "Sara"
            string [] names = {"Tim", "Martin", "Nikki", "Sara"};
            // string is the "data type", etc...

            // create an array of length 10 that alternates between true and false values, starting with true
            bool [] trueorFalse = {true, false, true, false, true, false, true,  false, true, false};
            // boolean is the "data type", etc...


            // List of Flavors
            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> icecream = new List<string> (); //<string> stands for the type of of objects you want the list to contain
            icecream.Add("Chocolate Chip Cookie Dough");
            icecream.Add("Mouse Tracks");
            icecream.Add("Butter Pecan");
            icecream.Add("Coffee");
            icecream.Add("Oreo");
            icecream.Add("Mocha Almond Fudge");

            // Output the length of this list after building it
            // Console.WriteLine(icecream.Count); //output 6 

            //Output the third flavor in the list, then remove this value
            // Console.WriteLine(icecream[3]); //output Coffee
            // icecream.RemoveAt(3);

            // Output the new length of the list (It should just be one fewer!)
            // Console.WriteLine(icecream.Count);

            //User Info Dictionary
            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string,string> dict = new Dictionary<string, string>();
            //Add key/value pairs to this dictionary where:
                //each key is a name from your names array
                //each value is a randomly select a flavor from your flavors list.
                // foreach(string name in names)
                // {
                //     dict.Add(name, null);
                // }
                Random rand = new Random();
                foreach (string name in names)
                {
                    dict.Add(name, icecream[rand.Next (0,names.Length)]); //key is the name, value is the icecream flavor
                }
            //Loop through the dictionary and print out each user's name and their associated ice cream flavor
                foreach (var entry in dict)
                {
                    Console.WriteLine(entry.Key + " - " + entry.Value);
                }
        }
    }
}
