using System;
using System.ComponentModel;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;

internal class Task3
{
    public class Box<T>
    {
        private List<T> list;

        public Box()
        {
            this.list = new List<T>();
        }

        public void AddElement(T name)
        {
            this.list.Add(name);
        }

        //public void GetList()
        //{
        //    foreach (var item in list)
        //    {
        //        Console.WriteLine($"{item.GetType().FullName}: {item}");
        //    }
        //}

        public void Compare(T elements)
        {
            int count = 0;

            string temp = "";
            string temp1 = "";


            foreach (var item in list)
            {
                temp += elements;
                temp1 += item;
                if (temp.CompareTo(temp1)<0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

    static void Main()
    {
        Box<string> box = new Box<string>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            box.AddElement(Console.ReadLine());

        }

        box.Compare(Console.ReadLine());

    }
}