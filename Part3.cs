using System;
using System.Collections.Generic;

public class SimpleArrayOfLists
{
    private List<int>[] _array;
    public SimpleArrayOfLists(int size)
    {
        _array = new List<int>[size];
        for (int i = 0; i < size; i++)
        {
            _array[i] = new List<int>();
        }
    }
    public void Add(int index, int item)
    {
        if (index >= 0 && index < _array.Length)
        {
            _array[index].Add(item);
        }
    }
    public void Remove(int index, int item)
    {
        if (index >= 0 && index < _array.Length)
        {
            _array[index].Remove(item);
        }
    }
    public void Print()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            Console.WriteLine($"List {i}: {string.Join(", ", _array[i])}");
        }
    }
}
class Program
{
    static void Main()
    {
        var arrayOfLists = new SimpleArrayOfLists(3);
        arrayOfLists.Add(0, 1);
        arrayOfLists.Add(0, 2);
        arrayOfLists.Add(1, 3);
        arrayOfLists.Print();
        arrayOfLists.Remove(0, 1);
        Console.WriteLine("After removal:");
        arrayOfLists.Print();
    }
}
