using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Assignment
{
    internal class Program
    {
        static double CalculateAverage(int[] grades, int gradeCount)
        {
            if (gradeCount == 0)
                return 0;

            int sum = 0;
            for (int i = 0; i < gradeCount; i++)
            {
                sum += grades[i];
            }

            return (double)sum / gradeCount;
        }

        static void Main(string[] args)
        {
            int[] grades = new int[20];
            int gradeCount = 0;

            Console.WriteLine("Enter up to 20 integer grades (-1 to stop):");

            while (gradeCount < 20)
            {
                int grade = Convert.ToInt32(Console.ReadLine());

                if (grade == -1)
                    break;

                grades[gradeCount] = grade;
                gradeCount++;
            }

            double average = CalculateAverage(grades, gradeCount);
            Console.WriteLine("Average grade: {0:F2}", average);

        }
    }
}