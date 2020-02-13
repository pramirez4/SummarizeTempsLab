using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter filename:");
            // temperature data is in temps.txt

            string filepath =Console.ReadLine();

            if (File.Exists(filepath))
            {
                Console.WriteLine("File Exists!");
                Console.WriteLine("Enter a Threshold:" );

                string line;
                string input;
                int threshold;
                input = Console.ReadLine();
                threshold = int.Parse(input);

                int sumTemp = 0;
                int numAbove = 0;
                int numBelow = 0;

                // Open file 
                using (StreamReader sr = File.OpenText(filepath))
                {
                    int temp;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //takes in from file makes it into an int
                        temp = int.Parse(line);

                        //add it to sum of temps
                        sumTemp += temp;

                        if (temp >= threshold)
                        {
                            // add 1 to the counter for the numbers above 50
                            numAbove += 1;

                        }
                        else
                        {
                            // add to the counter for the temps below 50
                            numBelow += 1;
                        }
                        
                      
                    }
                }
                int totalTemps = numAbove + numBelow;
                
                Console.WriteLine( "Number of temps above threshold: " + numAbove);
                Console.WriteLine( "Number of temps below threshold: " + numBelow);
                Console.WriteLine( "Sum of temps: " + sumTemp);
                Console.WriteLine("Total days :" + totalTemps);
            }
            else
            {
                Console.WriteLine("File doesn't exist");

            }
        }
    }
    /*write out prompt to console
             * read file name
             * test if the file exists 
             * if the file exists
             *  ask user to enter the temp threshold
             *  open the file and create streamreader
             *  read line into a string var
             *  while the line is not null 
             *   convert (parse)into and int var
             *      add the temp to my summing variable 
             *      if the current temp value >= threshold 
             *      increment "above" counter by 1
             *  else temp is below 
             *      increment the below counter by 1
             * 
             */
}
