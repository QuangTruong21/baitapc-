using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    public class Student
    {
        public int id; 
        public string name;
        public double score ;
        public List<Student> studentList = new List<Student>();
        public Student()
        {
        }

        public Student(int id, string name, double score)
        {
            this.id = id;
            this.name = name;
            this.score = score;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Score
        {
            get => score;
            set => score = value;
        }
        public void addStudent(Student student)
        {
            Console.WriteLine("Id");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("name");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("score");
            Score = Convert.ToInt32(Console.ReadLine());
            studentList.Add(new Student(Id,Name,Score));
            Console.WriteLine("Them Sinh Vien Thanh Cong");
            
        }

        public void showInfor()
        {
            foreach (Student p in studentList)
            {
                p.name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.name.ToLower());
                Console.WriteLine("name"+p.name);
                Console.Write("\nIn cac phan tu mang theo thu tu giam dan:\n");
            }
        }
    }
}