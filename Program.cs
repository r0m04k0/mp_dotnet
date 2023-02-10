using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная #1 - Инкапсуляция");
            Console.WriteLine("Выполнил - Корчнев Роман");
            Console.WriteLine("\nЗадание 1: ");

            Complex a = new Complex() { Real = 3, Imag = 0.5 };
            Complex b = new Complex() { Real = 2, Imag = 0.8 };

            a.Add(b);
            b.Substract(a);
            a.Multiply(a);
            a.Divide(b);

            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);

            Console.WriteLine("\nЗадание 2: ");

            Student student1 = new Student("Коля", "male", "808000", 22, 180.0f, 70.5f);
            Student student2 = new Student("Аня", "female", "1a1a00", 22, 158.0f, 60f);

            string newStudent = student1.Hybreed(student1, student2);
            Console.WriteLine(newStudent);



        }
    }
}


