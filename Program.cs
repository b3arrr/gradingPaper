/*
Program is created as a practice of creating, manipulating and referencing arrays.
-The program holds student scores, calculates the sum of their score,
averages it out and prints out a grade according to the
average score of the student
*/

//declare arrays holding up to 5 integers in the memory.
int[] sophiaScores = new int[5];
int[] andrewScores = new int[5];
int[] emmaScores = new int[5];
int[] loganScores = new int[5];

//initializes the array with the students grades.
sophiaScores = [60,90,95,70,65]; 
andrewScores = [70,90,77,99,96];
emmaScores = [100,80,99,95,99];
loganScores = [40,30,60,50,90];
string[] grade = new string [4];


int x = 0; //integer x created to run the if else loop within the foreach loop
 
//Array of the students names
string[] names = {"Sophia", "Andrew", "Emma", "Logan"}; 

//Foreach loop to find average student score based on xScores arrays
foreach(string i in names)
{
    int sum = 0; //Integer used to calculate final grade
    int average = 0;
    Console.WriteLine($"Adding scores for {names[x]}");
    if(x == 0)
    {
        foreach(int a in sophiaScores)
        {
            
            sum += a;
            Console.WriteLine($"Sum of sophias scores = {sum}");
            
        }
        
        average  = sum / 5; 
        Console.WriteLine($"Average grade of sophia is {average}\n");

    }

        else if(x == 1)
    {
            foreach(int a in andrewScores)
            {
                
                sum += a;
                Console.WriteLine($"Sum of Andrew scores = {sum}");
                
            }

        average = sum / 5; 
        Console.WriteLine($"Average grade of Andrew is {average}\n");
    }
        else if(x == 2)
    {
            foreach(int a in emmaScores)
            {
                
                sum += a;
                Console.WriteLine($"Sum of Emma scores = {sum}");
                
            }

        average = sum / 5; 
        Console.WriteLine($"Average grade of Emma is {average}\n");
    }
        else
    {
            foreach(int a in loganScores)
            {
                
                sum += a;
                Console.WriteLine($"Sum of Logan scores = {sum}");
                
            }

        average = sum / 5; 
        Console.WriteLine($"Average grade of Logan is {average}\n");
        
    }
    
    if(average <101 || average >= 0)
{
	if(average<=100 && average >= 97)
	{
		grade[x] = "A+";
	}
    else if(average >= 93)
    {
        grade[x] = "A";
    }
    else if(average>=90)
    {
        grade[x] = "A-";    
    }
    else if(average>=87)
    {
        grade[x] = "B+";
    }
    else if(average>=83)
    {
        grade[x] = "B";
    }
    else if(average>=80)
    {
        grade[x] = "B-";
    }
    else if(average>=77)
    {
        grade[x] = "C+";
    }
    else if(average>= 73)
    {
        grade[x] = "C";
    }
    else if(average>= 70)
    {
        grade[x] = "C-";
    }
    else if(average>=67)
    {
        grade[x] = "D+";
    }
    else if(average>=63)
    {
        grade[x] = "D";
    }
    else if(average>=60)
    {
        grade[x] = "D-";
    }
    else if(average>0)
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



Console.WriteLine($"Student\t\tGrade\n\n{names[0]}:\t\t92.2\t{grade[0]}");
Console.WriteLine($"{names[1]}:\t\t89.6\t{grade[1]}");
Console.WriteLine($"{names[2]}:\t\t85.6\t{grade[2]}");
Console.WriteLine($"{names[3]}:\t\t91.2\t{grade[3]}");
Console.WriteLine("\n\rPress any key to continue");
Console.ReadLine();



