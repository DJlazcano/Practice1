using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class StudentGrades
    {
        private float studentsAvg;
        private float highestGrade;
        private float lowestGrade;
        private List<float> grades = new List<float>();

        public void addGrade(float grade)
        {
            grades.Add(grade);
            
        }
        
        public void calculateAvg()
        {
            this.studentsAvg = grades.Average();
            this.highestGrade = grades.Max();
            this.lowestGrade = grades.Min();

            Console.WriteLine("Grades average: {0}  | Highest Grade: {1} | Lowest Grade: {2}\n",
                this.studentsAvg, this.highestGrade, this.lowestGrade);
        }
        
        public void sortGrades()
        {
            grades.Sort();
        }

        public void displayGrades() {
            sortGrades();
            int i = 1;
            foreach (var grade in grades) {
                Console.WriteLine("Grade {0}: {1}",i , grade);
                i++;
            }
            Console.WriteLine();
        }
    }
}
