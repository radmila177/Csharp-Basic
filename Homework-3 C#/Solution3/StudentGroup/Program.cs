using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student group: ( there are 1 and 2 )");
            string[] studentsG1 = new string[]
            {
                "Zdravko",
                "Petko",
                "Stanko",
                "Branko",
                "Trajko"
            };
            string[] studentsG2 = new string[]
            {
                "Radmila",
                "Kristina",
                "Vesna",
                "Jovana",
                "Elena"
            };

            var numberStudentGroup = int.Parse(Console.ReadLine());

            if (numberStudentGroup == 1)
            {
                Console.WriteLine("The Students in G2 are: ");
                for (int i = 0; i < studentsG1.Length; i++)
                {
                    Console.WriteLine(studentsG1[i]);
                }
            }

            else if (numberStudentGroup == 2)
            {
                Console.WriteLine("The Students in G2 are: ");
                for (int i = 0; i < studentsG2.Length; i++)
                {
                    Console.WriteLine(studentsG2[i]);
                }
            }
            else
            {
                Console.WriteLine("There is no such group of students");
            }


        }
    }
}