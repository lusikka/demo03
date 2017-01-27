using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Sasu";
            student1.Weight = 85;
            student1.Height = 186;
            student1.Motivation = false;

            Student student2 = new Student();
            student2.Name = "Henna";
            student2.Weight = 56;
            student2.Height = 173;
            student2.Motivation = false;

            Student student3 = new Student();
            student3.Name = "Eelis";
            student3.Weight = 72;
            student3.Height = 180;
            student3.Motivation = false;

            Student student4 = new Student();
            student4.Name = "Erita";
            student4.Weight = 52;
            student4.Height = 158;
            student4.Motivation = false;
            string[] studentName = { student1.Name, student2.Name, student3.Name, student4.Name };
            int[] studentWeight = { student1.Weight, student2.Weight, student3.Weight, student4.Weight };
            int[] studentHeight = { student1.Height, student2.Height, student3.Height, student4.Height };
            bool[] studentMoti = { student1.Motivation, student2.Motivation, student3.Motivation, student4.Motivation };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Student #" + (i + 1) + " Name: ");
                Console.WriteLine(studentName[i]);
                Console.WriteLine("Student #" + (i + 1) + " Weight: ");
                Console.WriteLine(studentWeight[i]);
                Console.WriteLine("Student #" + (i + 1) + " Height: ");
                Console.WriteLine(studentHeight[i]);
                Console.WriteLine("Student #" + (i + 1) + " Motivation: ");
                Console.WriteLine(studentMoti[i]);
                Console.WriteLine("****************************************");
            }

        }
    }
}