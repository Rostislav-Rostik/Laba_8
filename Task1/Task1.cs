internal class Task1
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
            Box<string> field = new Box<string>(Console.ReadLine());
            Console.WriteLine(field);
        }
    }
}




