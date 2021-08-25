using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class Repository
    {
        public Student[] students = new Student[10];
        private int id;
        Student student;

        public void Add(int id, Student student)
        {
            //List<Student> temp = students.ToList();
            //temp.Add(student);
            //students = temp.ToArray();
            id = student.id;
            students[id] = student;
            id++;

            if (id == students.Length)
            {
                Console.WriteLine("Max number of students = 10!");
            }
        }
        public void EditAll(int id1, string name, string surname, string gender, int age)
        {
            for (; id1 < students.Length; id1++)
            {
                if (id1 == id)
                {
                    Student find = students[id1];
                    find.NewAll(name, surname, gender, age);
                }
            }
            
        }
        public void GetId(int id1)
        {
            //List<Student> temp = students.ToList();
            //Student finded = temp.Find(temp => temp.id == id);
            //finded.Print();
            foreach (var item in students)
                if (id1 == item.id)
                {
                    Student find = students[id1];
                    find.Print();
                }
        }
        
        public void Delete(int id)
        {
            List<Student> temp = students.ToList();
            temp.RemoveAt(id);
            students = temp.ToArray();
        }

        public void List()
        {
            foreach(var item in students)
            {
                item.Print();
            }
        }
    }
}
