using System;

namespace OOP
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            // Teacher Teacher_1 = new Teacher(1, "Teacher Khoa", 18, true, 1000000);
            // Console.WriteLine(Teacher_1.Greeting());
            // Student Student_1 = new Student(1, "Student Khoa", 18, true, 5.7);
            // Console.WriteLine(Student_1.Greeting());

            // Anminal Tom = new Anminal();
            // Tom.Move()

            Dog milu = new Dog(4, "Milu");
            Console.WriteLine(milu.Move());
            Cat tom = new Cat(4, "tom");
            Console.WriteLine(tom.Move());

            Duck donal = new Duck(2, "Donal");
            Console.WriteLine(donal.Fly());
            Console.WriteLine(donal.Move());
        }
    }
}