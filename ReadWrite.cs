using System;
using System.Collections.Generic;
using System.IO;




namespace WorkoutProject_Csharp
{
    public class ReadWrite
    {
        public static List<Workout> ReadData(string fileName, List<Workout>)
        {
            using (var reader = new StreamReader(fileName))
            {
                while(!reader.EndOfStream)
                {
                    var row = reader.ReadLine();
                    var column = row.Split(',');
                    var Workout = new Workout()
                    {
                        Id = column[0],
                        Type = column[1],
                        Name = column[2]
                    };
                    Exercises.Add(Workout);
                }
            }
            return Exercises;
        }
    }
}
