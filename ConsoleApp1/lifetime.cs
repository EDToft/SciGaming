using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   class LifeTime
   {
      public DateTime BirthDate { get; set; }
      public DateTime DeathDate { get; set; }

      public LifeTime(DateTime birthdate, DateTime deathdate)
      {
         BirthDate = birthdate;
         DeathDate = deathdate;
      }

      public LifeTime(string birthdate, string deathdate)
      : this(DateTime.Parse(birthdate), DateTime.Parse(deathdate))
      { }

   }
}
