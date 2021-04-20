﻿// C# program to print all combination of size r in an array 
// of size n with repetitions allowed 

using System;
using System.Collections.Generic;
using System.Linq;

public class Program{ 
    static void Main(string[] args)
{
    var list = new List<string> { "m","n"};
    var result = GetPermutations(list, 2);
    foreach (var perm in result)
    {
        foreach (var c in perm)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
    }
    Console.ReadKey();
}

static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items, int count)
{
    int i = 0;
    foreach (var item in items)
    {
        if (count == 1)
            yield return new T[] { item };
        else
        {
            foreach (var result in GetPermutations(items.Skip(i + 1), count - 1))
                yield return new T[] { item }.Concat(result);
        }

        ++i;
    }
}



} 

