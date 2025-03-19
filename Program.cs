using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.Unicode;
using ASDLab4;



class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        StudentsManager manager = new StudentsManager();
        for(int i = 0; i < 30; i++)
        {
            manager.AddStudent(new Student());
        }

        manager.PrintStudents();
        manager.BucketSort();
        Console.WriteLine("\nПісля сортування:");
        manager.PrintStudents();
    }

    
}