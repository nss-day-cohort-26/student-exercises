using System.Collections.Generic;
using Dapper;
using Microsoft.Data.Sqlite;

namespace nss.Data
{
    public class StudentExercise
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Exercise Exercise { get; set; }
        public Instructor Instructor { get; set; }

        public static void Create(SqliteConnection db)
        {
            db.Execute($@"CREATE TABLE StudentExercise (
                `Id`	        INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                `ExerciseId`	INTEGER NOT NULL,
                `StudentId` 	INTEGER NOT NULL,
                `InstructorId` 	INTEGER NOT NULL,
                FOREIGN KEY(`ExerciseId`) REFERENCES `Exercise`(`Id`),
                FOREIGN KEY(`StudentId`) REFERENCES `Student`(`Id`),
                FOREIGN KEY(`InstructorId`) REFERENCES `Instructor`(`Id`)
            )");
        }
        public static void Seed(SqliteConnection db)
        {
            db.Execute($@"INSERT INTO StudentExercise
                SELECT null, e.Id, s.Id, i.Id
                FROM Student s, Exercise e, Instructor i
                WHERE e.Name = 'Overly Excited'
                AND s.SlackHandle = '@OtherADam'
                AND i.SlackHandle = '@coach'
            ");


            db.Execute($@"INSERT INTO StudentExercise
                SELECT null, e.Id, s.Id, i.Id
                FROM Student s, Exercise e, Instructor i
                WHERE e.Name = 'Overly Excited'
                AND s.SlackHandle = '@MrMan'
                AND i.SlackHandle = '@coach'
            ");


            db.Execute($@"INSERT INTO StudentExercise
                SELECT null, e.Id, s.Id, i.Id
                FROM Student s, Exercise e, Instructor i
                WHERE e.Name = 'ChickenMonkey'
                AND s.SlackHandle = '@Wrong'
                AND i.SlackHandle = '@joes'
            ");


            db.Execute($@"INSERT INTO StudentExercise
                SELECT null, e.Id, s.Id, i.Id
                FROM Student s, Exercise e, Instructor i
                WHERE e.Name = 'Boy Bands & Vegetables'
                AND s.SlackHandle = '@OtherADam'
                AND i.SlackHandle = '@jisie'
            ");

            db.Execute($@"INSERT INTO StudentExercise
                SELECT null, e.Id, s.Id, i.Id
                FROM Student s, Exercise e, Instructor i
                WHERE e.Name = 'Tacos'
                AND s.SlackHandle = '@SQLpants'
                AND i.SlackHandle = '@jisie'
            ");

            db.Execute($@"INSERT INTO StudentExercise
                SELECT null, e.Id, s.Id, i.Id
                FROM Student s, Exercise e, Instructor i
                WHERE e.Name = 'Shower Tears'
                AND s.SlackHandle = '@Tastic'
                AND i.SlackHandle = '@jisie'
            ");

            db.Execute($@"INSERT INTO StudentExercise
                SELECT null, e.Id, s.Id, i.Id
                FROM Student s, Exercise e, Instructor i
                WHERE e.Name = 'Shower Tears'
                AND s.SlackHandle = '@Person'
                AND i.SlackHandle = '@joes'
            ");
        }
    }

}