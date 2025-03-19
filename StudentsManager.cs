using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASDLab4
{
    public class StudentsManager
    {
        private LinkedList<Student> list;

        public StudentsManager()
        {
            list = new LinkedList<Student>();
        }

        public void AddStudent(Student student)
        {
            list.AddLast(student);
        }

        public void PrintStudents()
        {
            foreach (var student in list)
            {
                Console.WriteLine(student);
                Console.WriteLine("---------------------");
            }
        }

        private void InsertionSort(List<Student> bucket)
        {
            for (int i = 1; i < bucket.Count; ++i)
            {
                Student temp = bucket[i];
                int j = i - 1;

                while (j >= 0 && bucket[j].AverageGrade > temp.AverageGrade)
                {
                    bucket[j + 1] = bucket[j];
                    j--;
                }
                bucket[j + 1] = temp;
            }
        }

        public void BucketSort()
        {
            if (list.Count == 0)
                return;

            double maxGrade = list.Max(s => s.AverageGrade);
            double minGrade = list.Min(s => s.AverageGrade);

            int bucketCount = list.Count/2;

            List<Student>[] buckets = new List<Student>[bucketCount];
            for (int i = 0; i < bucketCount; i++)
            {
                buckets[i] = new List<Student>();
            }

            foreach (var student in list)
            {
                int bi = (int)((student.AverageGrade - minGrade) / (maxGrade - minGrade) * (bucketCount - 1));
                buckets[bi].Add(student);
            }

            for (int i = 0; i < bucketCount; i++)
            {
                if (buckets[i].Count > 0)
                {
                    InsertionSort(buckets[i]);
                }
            }

            list.Clear();
            for (int i = 0; i < bucketCount; i++)
            {
                foreach (var student in buckets[i])
                {
                    list.AddLast(student);
                }
            }
        }
    }
}
