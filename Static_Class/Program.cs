namespace Static_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Class1 class1 = new Class1();
            class1.Bar();
            Console.WriteLine(class1.GetType());
        }
    }
}
