using System;
using System.Collections.Generic;
using System.Globalization;

internal class Task0 
{
    public class Box<T>
    {
        public T Field;
    }

    public static void Main()
    {
        Box<int> n = new Box<int>();
        n.Field = 12213;
        Box<string> s = new Box<string>();
        s.Field = "life in a box";

        Console.WriteLine(n.Field.GetType().FullName + ": " + n.Field);
        Console.WriteLine(s.Field.GetType().FullName + ": " + s.Field);
    }
}

