using System;

namespace ConsoleApp1
{
    public class MainStrudent
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            

            int choose = 0;
            do
            {
                Console.WriteLine("1. AddStudent");
                Console.WriteLine("2. List");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Chose: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        s.addStudent(s);
                        break;
                    case 2:
                        s.showInfor();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            } while (choose != 2);

        }
    }
}