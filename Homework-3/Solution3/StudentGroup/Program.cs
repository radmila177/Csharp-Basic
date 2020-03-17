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
                    for (int i = 0; i < studentsG1.Length; i++)
                    {
                    Console.WriteLine("The Students in G1 are: " + studentsG1[i]);
                    }
                }

                if (numberStudentGroup == 2)
                {
                    for (int i = 0; i < studentsG2.Length; i++)
                    {
                    Console.WriteLine("The Students in G2 are: " + studentsG2[i]);
                    }
                }
                else
                {
                    Console.WriteLine("There is no such group of students");
                }
            }
        }
    }