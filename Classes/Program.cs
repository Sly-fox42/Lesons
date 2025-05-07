namespace Classes
{
    internal class Program
    {

        static Student GetStudent()
        {
            Student student = new Student(new DateTime(2000,12,25),"Petrov","Egor");
           
            student.Id = Guid.NewGuid();
            return student;
        }
        static void Main(string[] args)
        {
            Point point = new Point(10,20);
            
            point.color =Point.Color.Silver;
            Student student = GetStudent();
            Student student2 = new Student(student);
            student2.Id = Guid.NewGuid();
            student.Print();
            student2.Print();

            Point point1 = new Point(2,7);
            Point point2 = new Point(3,7,5);
            Point[]points = { point1, point2,point };
            int count = 0;
            foreach (Point p in points)
            {
                count++;
                Console.WriteLine($"Точка {count}");
                p.Print();
            }
        }
       
    }
}
