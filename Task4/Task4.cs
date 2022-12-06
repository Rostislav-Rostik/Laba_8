using System;
using System.ComponentModel;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

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

        public void GetList()
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType().FullName}: {item}");
            }
        }

        public void Swap(ref int first, ref int second)
        {
            var temp = this.list[first];
            this.list[first] = this.list[second];
            this.list[second] = temp;
        }
    }

    static void Main()
    {
        Box<int> box = new Box<int>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            box.AddElement(int.Parse(Console.ReadLine()));

        }

        int index = int.Parse(Console.ReadLine());
        int index1 = int.Parse(Console.ReadLine());

        box.Swap(ref index, ref index1);
        box.GetList();
    }
}