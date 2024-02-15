/*
Program is created as a practice of creating, manipulating and referencing arrays.
-The program holds student scores, calculates the sum of their score,
averages it out and prints out a grade according to the
average score of the student.
*/
/*
Update 14\02\2024
-Added a local function "GradeResults" that automates the average grade of each student.
-Added extra credits to the "GradeResults" function.
-Added return value of the total grade number by adding the extra credit and the average grade. 
*/
/*
Update 15\02\2024
-Looped the final grading output showing students names, grade, overall grade, and extra credit
*/

internal class Program
{

    private static void Main(string[] args)
    {
        //new comment
        //declare arrays holding up to 5 integers in the memory.
        int[] sophiaScores = new int[5];
        int[] andrewScores = new int[5];
        int[] emmaScores = new int[5];
        int[] loganScores = new int[5];

        float[] numbersGrade = new float[5]; //Referencing the number grade
        float[] averageGrade = new float[5];
        float[] extraGrade = new float[5];

        //initializes the array with the students grades.
        sophiaScores = [60, 90, 95, 70, 65, 90, 70];
        andrewScores = [70, 90, 77, 99, 96];
        emmaScores = [100, 80, 99, 95, 99,90];
        loganScores = [40, 30, 60, 50, 90,60,70,80];
        string[] grade = new string[4];


        int x = 0; //integer x created to run the if else loop within the foreach loop

        //Array of the students names
        string[] names = { "Sophia", "Andrew", "Emma", "Logan" };

        //Foreach loop to find average student score based on xScores arrays
        foreach (string i in names)
        {
            float total = 0f;
            Console.WriteLine($"Adding scores for {names[x]}");
            if (x == 0)
            {
                (float averageScore, float totalScore, float extraPoints) results = GradesResults(sophiaScores);
                 total = results.totalScore;
                averageGrade[x] = results.averageScore;
                extraGrade[x] = results.extraPoints;
                numbersGrade[x] = total;
            }

            else if (x == 1)
            {
               (float averageScore, float totalScore, float extraPoints) results = GradesResults(andrewScores);
                total = results.totalScore;
                averageGrade[x] = results.averageScore;
                extraGrade[x] = results.extraPoints;
                numbersGrade[x] = total;
            }
            else if (x == 2)
            {
                 (float averageScore, float totalScore, float extraPoints) results = GradesResults(emmaScores);
                total = results.totalScore;
                averageGrade[x] = results.averageScore;
                extraGrade[x] = results.extraPoints;
                numbersGrade[x] = total;
            }
            else
            {
                 (float averageScore, float totalScore, float extraPoints) results = GradesResults(loganScores);
                 total = results.totalScore;
                averageGrade[x] = results.averageScore;
                extraGrade[x] = results.extraPoints;
                numbersGrade[x] = total;
            }
           
            //Initialize grade array with a alphabetic grade to corresponding students.
            if (total < 101 || total >= 0)
            {
                if (total <= 100 && total >= 97)
                {
                    grade[x] = "A+";
                }
                else if (total >= 93)
                {
                    grade[x] = "A";
                }
                else if (total >= 90)
                {
                    grade[x] = "A-";
                }
                else if (total >= 87)
                {
                    grade[x] = "B+";
                }
                else if (total >= 83)
                {
                    grade[x] = "B";
                }
                else if (total >= 80)
                {
                    grade[x] = "B-";
                }
                else if (total >= 77)
                {
                    grade[x] = "C+";
                }
                else if (total >= 73)
                {
                    grade[x] = "C";
                }
                else if (total >= 70)
                {
                    grade[x] = "C-";
                }
                else if (total >= 67)
                {
                    grade[x] = "D+";
                }
                else if (total >= 63)
                {
                    grade[x] = "D";
                }
                else if (total >= 60)
                {
                    grade[x] = "D-";
                }
                else if (total > 0)
                {
                    grade[x] = "F";
                }
                else
                {
                    Console.WriteLine("Grade indescribable)");
                }

            }

            x++;



        }

        finalResults(names, averageGrade,numbersGrade,grade, extraGrade); //calls finalResults function


    }












        //Function finalResults, that prints out the grade for the students automaticly. 
        static void finalResults(string[] names, float[] averageGrade, float[] numbersGrade, string[] grade, float[]extraGrade)
        {
                   
        Console.WriteLine($"Student\t\tGrade\tOverall Grade\tExtra Credit\n\n");
        for(int i = 0; i < names.Length; i++)
        {
              
            Console.WriteLine($"{names[i]}:\t\t{averageGrade[i]:F1}\t{numbersGrade[i]:F1}\t{grade[i]}\t{averageGrade[i]:F1}({extraGrade[i]:F1})points");

        }
        }
       
      
       //Function GradeResults, automates the average grade, total grade, and how much extra points was added to the grade.
       static (float averageScore, float totalScore, float extraPoints) GradesResults(int[] scores)

            {
                float sum = 0f; // used to calculate final grade
                float averageScore  = 0f; //Average decleration for function
                float totalScore = 0f; //Used as the totalScore grade score included with extra credits
                float extraPoints = 0f; //How many extra points each student has
        
        
        foreach (int a in scores)
                    {
                        sum += a;
                        Console.WriteLine($"Sum of sophias scores = {sum}");
                    }
                 averageScore = sum / scores.Length;
                 Console.WriteLine($"Average grade of student is {averageScore}\n");
                 totalScore = averageScore;
       
 
       
            if(scores.Length >=8)
            {
                totalScore += 3f;
            }
            else if(scores.Length >=7)
            {
                totalScore +=2f;
            }
            else if(scores.Length >=6)
            {
                totalScore +=1f;
            }
            extraPoints = totalScore % averageScore; 

            Console.Write("The students has " + extraPoints + " extra points\n\n\n");
        

                 
                return (averageScore, totalScore, extraPoints);
                 
            
}


}