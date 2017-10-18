using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   class Program
   {
      static readonly string filename = @"birthdata.csv";

      private static List<LifeTime> ReadFile()
      {
         string line;
         List<LifeTime> listOfLifetimes = new List<LifeTime>();
         // Read the file in line by line.
         System.IO.StreamReader file =
             new System.IO.StreamReader(filename);
         while ((line = file.ReadLine()) != null)
         {
            string[] words = line.Split(',');


            listOfLifetimes.Add(new LifeTime(words[0], words[1]));
         }

         file.Close();

         return listOfLifetimes;
      }

      static void Main(string[] args)
      {
         int MaxLiving = 0;
         int MaxLivingYear = 0;

         List<LifeTime> listOfLifetimes = ReadFile();

         //for each year, 1900 through 2000, determine how many lifetimes were alive.
         for (int year = 1900; year < 2000; year++)
         {
            int alive = listOfLifetimes.Where(lt => lt.BirthDate.Year <= year && lt.DeathDate.Year >= year).Count();
            if(alive > MaxLiving)
            {
               MaxLiving = alive;
               MaxLivingYear = year;
            }
         }

         System.Console.WriteLine("Of these {0} life-times, the most that were active/alive during a given year were {1} in the year {2}.", listOfLifetimes.Count, MaxLiving, MaxLivingYear);
         System.Console.ReadLine();
      }
   }
}
