using System.ComponentModel;

namespace ConsoleApp7;
class Program
{
   
    public static void FileWrite(string path, string content)
    {
        StreamWriter sw = new StreamWriter(path, true);
        sw.WriteLine(content);
        sw.Close();
    }
    static void Main(string[] args)
    {
        string filePath = "C:\\Users\\ragbonlahor\\source\\repos\\TomC1\\ConsoleApp7";
        Console.WriteLine(filePath);

        string fileName = "grades.txt";
        Console.WriteLine(fileName);

        string fullFileName = filePath + @"/" +  fileName;
        Console.WriteLine(fullFileName);

        while (true)
        {
           Console.Clear();
           Console.WriteLine("What is the name of the student?");
            string name = Console.ReadLine();

            Console.WriteLine("What percentage did they get?");
            int percentage = int.Parse(Console.ReadLine());
            string result = "";

            if (percentage >= 80 && percentage <= 100 ) 
            {
                result = "Distinction";
            } else if (percentage >= 60)
            {
                result = "Merit";
            } else if (percentage >= 40)
            {
                result = "Pass";
            } else if (percentage >= 0)
            {
                result = "Fail";
            } else { Console.WriteLine("Please enter a valid percentage value");  }

            string entry = name + " got " + percentage + "% and was awarded a " + result; 

            FileWrite(fullFileName, entry);

            Console.WriteLine("Would you like to log another result?");
            Console.WriteLine("Enter 1 to quit program");
            Console.WriteLine("Enter 2 to add another entry");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                break;
            }


        } 


    }
}