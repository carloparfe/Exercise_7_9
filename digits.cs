/*
Carlos Paredes Fernández - 1ºDAM
Calculates how many numbers of 1, 2, 3 or more digits are entered by the user 
until he/she types “end”.
*/

using System;

class digits
{
    static void Main()
    {
        int counterOneDigit = 0, counterTwoDigits = 0, counterThreeDigits = 0,
            counterMoreDigits = 0;
        
        Console.Write("Insert a number: ");
        // read the number as string to check the word "end"
        string input = Console.ReadLine();
        
        while(input != "end")
        {
            int number = Convert.ToInt32(input);
            
            if(number != 0)
            {
                if(number / 10 == 0)
                {
                counterOneDigit++;
                }
                else if (number / 100 == 0)
                {
                counterTwoDigits++;
                }
                else if (number / 1000 == 0)
                {
                counterThreeDigits++;
                }
                else
                {
                counterMoreDigits++;
                }
            }
            
            input = Console.ReadLine();
        }
        
        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", 
            counterOneDigit, counterTwoDigits, counterThreeDigits, 
            counterMoreDigits); 
    }
}

