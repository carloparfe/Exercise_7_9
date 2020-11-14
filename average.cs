/*
Carlos Paredes Fernández - 1ºDAM
Calculates the average of a set of marks, until the user types “end”.
*/

using System;

public class Average
{
    public static void Main()
    {
        double sumMarks = 0, mark, markCounter = 0, average;
        string userInserts;
        
        Console.Write("Insert a mark: ");
        userInserts = Console.ReadLine();  // we read the insert as string to check the word "end"
        
        while(userInserts != "end")
        {
            mark = Convert.ToDouble(userInserts);
            markCounter++;
            sumMarks += mark;
            
            Console.Write("Insert a mark: ");
            userInserts = Console.ReadLine();
        }
        
        if(markCounter != 0)
        {
            average = sumMarks / markCounter;
            Console.WriteLine("The average is {0}.",average);
        }
    }
}
