// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()       
//     {
//         Dictionary<char, string> alphabetMap = new Dictionary<char, string>();

//         for (char c = 'A'; c <= 'Z'; c++)
//         {
//             alphabetMap[c] = (c - 'A' + 1).ToString();
//         }

//         // Display the dictionary
//         foreach (var pair in alphabetMap)
//         {
//             Console.WriteLine($"{pair.Key} : {pair.Value}");
//         }
//     }
// }


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<char, string> alphabetMap = new Dictionary<char, string>
        {
            { 'A', "Ant" },
            { 'B', "Ball" },
            { 'C', "Cat" },
            { 'D', "Dog" },
            { 'E', "Elephant" },
            { 'F', "Fish" },
            { 'G', "Giraffe" },
            { 'H', "Hat" },
            { 'I', "Ice Cream" },
            { 'J', "Jelly" },
            { 'K', "Kite" },
            { 'L', "Lion" },
            { 'M', "Monkey" },
            { 'N', "Nest" },
            { 'O', "Orange" },
            { 'P', "Penguin" },
            { 'Q', "Queen" },
            { 'R', "Rabbit" },
            { 'S', "Sun" },
            { 'T', "Tiger" },
            { 'U', "Umbrella" },
            { 'V', "Violin" },
            { 'W', "Whale" },
            { 'X', "Xylophone" },
            { 'Y', "Yak" },
            { 'Z', "Zebra" }
        };

        // Display the dictionary
        foreach (var pair in alphabetMap)
        {
            Console.WriteLine($"{pair.Key} for {pair.Value}");
        }
    }
}
