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

            string temp1 = "";
            temp1 += elements;
            double temp = double.Parse(temp1);


            foreach (var item in list)
            {
                temp1 = "";
                temp1 += item;

                double temp2 = double.Parse(temp1);
                temp1 += item;
                if (temp2 > temp)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

    static void Main()
    {
        Box<double> box = new Box<double>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            box.AddElement(double.Parse(Console.ReadLine()));
        }

        box.Compare(double.Parse(Console.ReadLine()));

    }
}