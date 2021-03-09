using System;
using OutstandingLibrary;
namespace OutStandingConsole
{
    class Program
    {
        static void SubMenu()
        {
            
            Console.WriteLine(" 1.Professor");
            Console.WriteLine(" 2.Student");
        }
        static int EnterChoice()
        {
            Console.WriteLine("Enter your choice");
            return int.Parse(Console.ReadLine());
        }
        static OutClass Create(int choice)
        {
            OutClass outclass = null;
            Console.WriteLine("enter the name");
            string OutName = Console.ReadLine();
            switch(choice)
            {
                case 1:
                    Console.WriteLine("enter the number of publications");
                    int publications = int.Parse(Console.ReadLine());
                    outclass = new Professor(OutName, publications);
                    break;
                case 2:
                    Console.WriteLine("enter the marks");
                    int marks = int.Parse(Console.ReadLine());
                    outclass = new Student(OutName, marks);

                    break;
            }
            return outclass;
        }
        static void Main(string[] args)
        {
            OutClass[] outClasses = new OutClass[4];
            for(int i=0;i<4;i++)
            {
                SubMenu();
                int choice = EnterChoice();
                OutClass oc = Create(choice);
                outClasses[i] = oc;
            }
           foreach(OutClass e in outClasses)
            {
                if (e.IsOutstanding())
                {
                    if (e is Professor)
                    {
                        Professor d = e as Professor;
                        /*if(d.IsOutstanding())
                        {

                        }
                        */
                        Console.WriteLine($"The details of professor are {d.printvalues()}");
                        /*else
                        Console.WriteLine($"Sorry Sir You need more publications");
                        */
                    }
                    if (e is Student)
                    {
                        Student s = e as Student;
                        /*if (s.IsOutstanding())
                        {

                        }*/
                        Console.WriteLine($"The details of students are {s.show()}");
                        /* else
                             Console.WriteLine("Sorry buddy you are not outstanding it seems");
                        */
                    }
                }
            }
        }
    }
}
