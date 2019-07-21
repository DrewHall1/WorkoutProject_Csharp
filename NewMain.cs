using System;
using System.Collections.Generic;



namespace WorkoutProject_Csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fileName = @"ListOfExercises.csv";

            List<Workout> Exercises = new List<Workout>();

            ReadWrite.ReadData(fileName, Exercises);

            var Finished = false;

            while(!Finished)
            {
                Console.WriteLine("Welcome to Basic Training you slimey maggot! ");
                Console.WriteLine("Choose your entrance to hell on earth - 1. View all workouts 2. Make my own, 3. Edit existing, 4. I'm not worthy today - I QUIT!");

                var userChoice = Console.ReadKey();
                switch (userChoice.KeyChar)
                {
                    case '1':
                        ReadWrite.ViewData(Exercises);
                        break;

                    case '2':
                        ReadWrite.AddWorkout(Exercises);
                        break;

                    case '3':
                        ReadWrite.EditWorkout(Exercises, fileName);
                        break;

                    case '4':
                        Finished = true;
                        break;
                }

                ReadWrite.WriteData(fileName, ListOfExercises);
    }
}
