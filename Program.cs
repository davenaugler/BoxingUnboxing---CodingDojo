using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create an empty List of type object
            List<object> emptyList = new List<object>();
            // 2. Add the following values to the lsti: 7, 28, -1, true, "chair"
            emptyList.Add(7);
            emptyList.Add(28);
            emptyList.Add(-1);
            emptyList.Add(true);
            emptyList.Add("chair");
            int sum = 0;

            // 3. Loop through the list and print all values (Hint: Type Inference might help here!)
            foreach(object entry in emptyList)
            {
                Console.WriteLine(entry);
                if(entry is int)
                {
                    int intVal = (int)entry;
                    sum += intVal;
                    Console.WriteLine($"  {entry} is an int");
                }
                else if (entry is bool)
                {
                    Console.WriteLine($"  {entry} is a bool");
                }
                else if (entry is string)
                {
                    Console.WriteLine($"  {entry} is a string");
                }
                // int IntSum = int(entry)
                // int sum += 
            }

            // 4. Add all values that are Int type together and output the sum
            Console.WriteLine($"The sum is {sum}");

        }
    }
}
