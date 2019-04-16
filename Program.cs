using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {

Cohort day33 = new Cohort("Day33");
Cohort day34 = new Cohort("Day34");
Cohort day35 = new Cohort("Day35");
List<Cohort> AllCohorts = new List<Cohort>() {
    day33,
    day34,
    day35
};

AllCohorts.ForEach(cohort => Console.WriteLine($"{cohort}"));

Exercise Looping = new Exercise("Creating forEach and for loops", "JavaScript");
Exercise Style = new Exercise("Style current project with flex box", "CSS");
Exercise ArrayMethods = new Exercise("Filtering Data with Array Methods","JavaScript");
Exercise Classes = new Exercise("Custom Types with Classes", "C#");
List<Exercise> exercises = new List<Exercise>() {
Looping,
Style,
ArrayMethods,
Classes
};

Student Warner = new Student("Warner", "Carpenter", "Warner Carpenter", day33);
Student Kirren = new Student("Kirren", "Covey", "Kirren Covey", day34);
Student Mo = new Student("Mo", "Silvera", "Mo Silvera", day35);
List<Student> students = new List<Student>();
students.Add(Warner);
students.Add(Kirren);
students.Add(Mo);

Instructor Steve = new Instructor("Steve", "Brownlee", "Steve Brownlee", day33);
Instructor Jisie = new Instructor("Jisie", "David", "Jisie David", day34);
Instructor Joe = new Instructor("Joe", "Shepherd", "Joe Shepherd", day35);
List<Instructor> AllInstructors = new List<Instructor>(){
    Steve,
    Jisie,
    Joe
};

// Day33.Students.Add(Warner);
// Day34.Students.Add(Kirren);
// Day35.Students.Add(Mo);

// Day33.Instructors.Add(Steve);
// Day34.Instructors.Add(Jisie);
// Day35.Instructors.Add(Joe);

Steve.Assign(Kirren, Looping);
Steve.Assign(Kirren, Style);

Jisie.Assign(Warner, Style);
Jisie.Assign(Warner, Classes);

Joe.Assign(Mo, ArrayMethods);
Joe.Assign(Mo, Looping);

Console.WriteLine($"Mo has {Mo.Exercises.Count} exercises.");
Mo.Exercises.ForEach( exercise => Console.WriteLine($"{exercise.Name} {exercise.Language}"));
Console.WriteLine($"Warner has {Warner.Exercises.Count} exercises.");
Warner.Exercises.ForEach( exercise => Console.WriteLine($"{exercise.Name} {exercise.Language}"));
Console.WriteLine($"Kirren has {Kirren.Exercises.Count} exercises.");
Kirren.Exercises.ForEach( exercise => Console.WriteLine($"{exercise.Name} {exercise.Language}"));

        }
    }
}
