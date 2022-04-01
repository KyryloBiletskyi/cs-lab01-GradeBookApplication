using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            int[] myArray = new int[100];
            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(1,100);
            }

            int countOfGrades = (int)(myArray.Length * 0.2);
            if(countOfGrades < 5)
            {
                // InvalidOperationException;
            }

            int[] newArray = new int[countOfGrades];
            int[] mainArray = new int[countOfGrades * 5];

            try 
            {
                for (int i = 0; i < countOfGrades * 5; i++)
                {
                    mainArray[i] = myArray[i];
                }
            }
            catch(Exception exp)
            {

            }


            int counter = 0;
            for (int i = 0; i < mainArray.Length; i++)
            {
                if (mainArray[i] > averageGrade)
                {
                    counter++;
                }
            }

            int gradeA = (int)(myArray.Length * 0.2);
            int gradeB = (int)(myArray.Length * 0.4);
            int gradeC = (int)(myArray.Length * 0.6);
            int gradeD = (int)(myArray.Length * 0.8);

            char grade;
            if (counter <= gradeA)
            {
                return grade = 'A';
            }
            else if (counter <= gradeB)
            {
                return grade = 'B';
            }
            else if (counter <= gradeC)
            {
                return grade = 'C';
            }
            else if (counter <= gradeD)
            {
                return grade = 'D';
            }
            else
            {
                return grade = 'F';
            }
        }
    }
}
