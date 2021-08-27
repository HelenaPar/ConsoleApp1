using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class Repository
    {
        private Student[] students = new Student[11];
        private int id;
        Student student;
        private object result;

        public void Add(Student student)
        {
            id = student.id;
            students[id] = student;
            id++;
            //if (id >= students.Length)
            //{
            //    Console.WriteLine("Max number of students = 10!");
            //}

        }
        public void EditAll(int id1, string name, string surname, string gender, int age)
        {
            student = students[id1];
            students[id1] = new Student(id1, name, surname, gender, age);

        }
        public string GetId(int id1)
        {
            student = students[id1];
            return student.ToString();
        }
        public string Rand()
        {
            students = students.Where(x => x != null).ToArray();
            Random rnd = new Random();
            int value = rnd.Next(0, students.Length);
            student = students[value];
            return student.ToString();
        }
        
        public void Delete(int id)
        {
            //students = students.Where(val => student.id != id).ToArray();
            students[id] = null;
        }

        public string Find(string choose, string surORname)
        { //мне казалось, что это сработает, но оно выводит что-то странное
          //типо этого: System.Linq.Enumerable... и тд.
          //в остальном всё работает, только вот после выполнения некоторых команд массив почему-то сдвигается назад
          //и когда я пытаюсь удалить по id оно говорит, что я ввела значение за пределами массива
          //если добавить пару элементов, а потом сразу же один удалить - работает

            // var result = students.Where(tmp => tmp.name == surORname);
            if (choose == "sur" || choose == "s" || choose == "surname")
            {
                result = students.Where(tmp => tmp.surname == surORname);
            }
            else if (choose == "nam" || choose == "n" || choose == "name")
            {
                result = students.Where(tmp => tmp.name == surORname);
            }
            return result.ToString();
        }

        public Student[] List() 
        {
            Student[] mass = new Student[11];
            students.CopyTo(mass, 0);
            mass = mass.Where(x => x != null).ToArray();
            return mass;
                //Student[] mass = new Student[11];
                //students.CopyTo(mass, 0);
                //students = students.Where(x => x != null).ToArray();
                //return students.ToString();
                //for (int i = 0; i < mass.Length; i++)
                //{
                //    return mass[i] + "\t";
                //}
        }

        public void Empty()
        {
            foreach (var item in students)
            {
                if (!students.Contains(item))
                {
                    Console.WriteLine("Данная запись отсутствует..");
                }
            }
            Console.WriteLine("Запись успешно добавлена!");
        }
    }
}
