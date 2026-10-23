using System;
using System.Collections.Generic;
using System.Text;

namespace duplicatehandelling
{
    class Program
    {
        static void CheckForDuplicates(List<int> numbers)
        {
            List<int> numbersChecked = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
                numbersChecked.Add(numbers[i]);
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbersChecked[i] == numbers[j])
                    {
                        throw new Exception($"Duplicate number found: {numbers[i]}");
                    }
                }
            }
        }

        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 5, 4 };
            CheckForDuplicates(numbers);
        }
    }
}