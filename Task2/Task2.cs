internal class Task2
{
    public class Box<T>
    {
        private T field;

        public Box(T field)
        {
            this.field = field;
        }

        public override string ToString()
        {
            return $"{field.GetType().FullName}: {field}";
        }
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Box<int> field = new Box<int>(int.Parse(Console.ReadLine()));
            Console.WriteLine(field);
        }
    }
}




