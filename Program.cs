using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task1, string> TaskSolver = task =>
            {
                // Your solution goes here
                // You can get all needed inputs from task.[Property]
                // Good luck!
                string cityName   = task.City.Name;
                string popul      = task.City.Population;
                string sickPerc   = task.City.SickPercentage;
                string virusName  = task.Virus.Name;
                string killProb   = task.Virus.KillProbability;

                float sickNum = float.Parse(popul) * float.Parse(sickPerc);
                float diedNum = float.Parse(killProb) * sickNum;
                
                return $"There are {Math.Truncate(sickNum)} people sick with {virusName} in the city of {cityName}, {Math.Truncate(diedNum)} of which died";
            };

            Task1.CheckSolver(TaskSolver);
        }
    }
}
