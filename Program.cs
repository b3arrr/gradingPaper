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

using System.Numerics;

class Program
{
    public static void Main(string[] args)
    {

        //Initialize arrays with scores
        int[] sophiaScores = [60, 90, 95, 70, 65, 90, 70];
        int[] andrewScores = [70, 90, 77, 99, 96];
        int[] emmaScores = [100, 80, 99, 95, 99, 90];
        int[] loganScores = [40, 30, 60, 50, 90, 60, 70, 80];

        //Initialize float arrays
        float[] numbersGrade = new float[5]; //Referencing the number grade
        float[] averageGrade = new float[5];
        float[] extraGrade = new float[5];

        string[] grade = new string[4];

        //Array of the students names
        string[] names = { "Sophia", "Andrew", "Emma", "Logan" };

        //Initialize Dictionary with studentnames and studentscores
        //Key: String
        //Value: int[]
        var students = new Dictionary<string, int[]>(){
            {"Sophia", sophiaScores }, // Each {"key":"value"} indicates a new entry in the dictionary
            {"Andrew", andrewScores },
            {"Emma", emmaScores },
            {"Logan", loganScores },
        };

        //Initialize Dictionary for Students and Results
        var results = new Dictionary<string, (float averageScore, float totalScore, float extraPoints, string grade)>();

        //int x = 0; //integer x created to run the if else loop within the foreach loop

        //For each student (entry) in the Dictionary (students)
        foreach (var student in students)
        {
            Console.WriteLine($"Adding scores for {student.Key}");
            // students[student.Key] refers to the Value in the Key:Value pair. In the same way we can access a value in a given array i.e arrayName[0] will give us the value at position 0 in the array.
            (float averageScore, float totalScore, float extraPoints) gradeResult = GradesResults(students[student.Key]); // Get the grades given a students score-array
            results.Add(student.Key, (gradeResult.averageScore, gradeResult.totalScore, gradeResult.extraPoints, GetGrade((int)gradeResult.totalScore))); // Add the scores to the results Dictionary, retrieve grade after casting totalScore to int
        }

		FinalResults(results);

        //    //Foreach loop to find average student score based on xScores arrays
        //    foreach (string i in names)
        //    {
        //        float total = 0f;
        //        Console.WriteLine($"Adding scores for {names[x]}");
        //        if (x == 0)
        //        {
        //            (float averageScore, float totalScore, float extraPoints) results = GradesResults(sophiaScores);
        //             total = results.totalScore;
        //            averageGrade[x] = results.averageScore;
        //            extraGrade[x] = results.extraPoints;
        //            numbersGrade[x] = total;
        //        }

        //        else if (x == 1)
        //        {
        //           (float averageScore, float totalScore, float extraPoints) results = GradesResults(andrewScores);
        //            total = results.totalScore;
        //            averageGrade[x] = results.averageScore;
        //            extraGrade[x] = results.extraPoints;
        //            numbersGrade[x] = total;
        //        }
        //        else if (x == 2)
        //        {
        //             (float averageScore, float totalScore, float extraPoints) results = GradesResults(emmaScores);
        //            total = results.totalScore;
        //            averageGrade[x] = results.averageScore;
        //            extraGrade[x] = results.extraPoints;
        //            numbersGrade[x] = total;
        //        }
        //        else
        //        {
        //             (float averageScore, float totalScore, float extraPoints) results = GradesResults(loganScores);
        //             total = results.totalScore;
        //            averageGrade[x] = results.averageScore;
        //            extraGrade[x] = results.extraPoints;
        //            numbersGrade[x] = total;
        //        }

        //        //Initialize grade array with a alphabetic grade to corresponding students.
        //        x++;
        //    }

        //    FinalResults(names, averageGrade,numbersGrade,grade, extraGrade); //calls finalResults function
        //}


        //Function finalResults, that prints out the grade for the students automaticly. 
    }

    public static void FinalResults(string[] names, float[] averageGrade, float[] numbersGrade, string[] grade, float[] extraGrade)
    {

        Console.WriteLine($"Student\t\tGrade\tOverall Grade\tExtra Credit\n\n");
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"{names[i]}:\t\t{averageGrade[i]:F1}\t{numbersGrade[i]:F1}\t{grade[i]}\t{averageGrade[i]:F1}({extraGrade[i]:F1})points");
        }
    }

    public static void FinalResults(Dictionary<string, (float averageScore, float totalScore, float extraPoints, string grade)> results)
    {
        Console.WriteLine($"Student\t\tGrade\tOverall Grade\tExtra Credit\n\n");
        foreach (var result in results)
        {
            //For each entry in the Dictionary. Display the Name, Avg Score, Tot Score, Grade, Avg Score, Extra Points
            Console.WriteLine($"{result.Key}:\t\t{result.Value.averageScore:F1}\t{result.Value.totalScore:F1}\t{result.Value.grade}\t{result.Value.averageScore:F1}({result.Value.extraPoints:F1})points");
        }
    }

    //Function GradeResults, automates the average grade, total grade, and how much extra points was added to the grade.
    public static (float averageScore, float totalScore, float extraPoints) GradesResults(int[] scores)

    {
        float sum = 0f; // used to calculate final grade
        float averageScore = 0f; //Average decleration for function
        float totalScore = 0f; //Used as the totalScore grade score included with extra credits
        float extraPoints = 0f; //How many extra points each student has

        foreach (int a in scores)
        {
            sum += a;
            Console.WriteLine($"Sum of scores = {sum}");
        }
        averageScore = sum / scores.Length;
        Console.WriteLine($"Average grade of student is {averageScore}\n");
        totalScore = averageScore;

        if (scores.Length >= 8)
        {
            totalScore += 3f;
        }
        else if (scores.Length >= 7)
        {
            totalScore += 2f;
        }
        else if (scores.Length >= 6)
        {
            totalScore += 1f;
        }
        extraPoints = totalScore % averageScore;

        Console.Write("The students has " + extraPoints + " extra points\n\n\n");

        return (averageScore, totalScore, extraPoints);
    }

    public static string GetGrade(int score)
    {
        if (score < 101 || score >= 0)
        {
            if (score <= 100 && score >= 97)
            {
                return "A+";
            }
            else if (score >= 93)
            {
                return "A";
            }
            else if (score >= 90)
            {
                return "A-";
            }
            else if (score >= 87)
            {
                return "B+";
            }
            else if (score >= 83)
            {
                return "B";
            }
            else if (score >= 80)
            {
                return "B-";
            }
            else if (score >= 77)
            {
                return "C+";
            }
            else if (score >= 73)
            {
                return "C";
            }
            else if (score >= 70)
            {
                return "C-";
            }
            else if (score >= 67)
            {
                return "D+";
            }
            else if (score >= 63)
            {
                return "D";
            }
            else if (score >= 60)
            {
                return "D-";
            }
            else if (score > 0)
            {
                return "F";
            }
        }

        return "Grade indescribable";
    }
}