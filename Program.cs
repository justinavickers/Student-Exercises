using System;
using System.Linq;
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
      Exercise ArrayMethods = new Exercise("Filtering Data with Array Methods", "JavaScript");
      Exercise Classes = new Exercise("Custom Types with Classes", "C#");
      List<Exercise> exercises = new List<Exercise>() {
Looping,
Style,
ArrayMethods,
Classes
};
      IEnumerable<Exercise> jsexercises = from count in exercises
                                          where count.Language == "JavaScript"
                                          select count;
      foreach (Exercise jsexercise in jsexercises)
      {
        Console.WriteLine($"Javascript exercises are {jsexercise.Name}");
      }
      Student Niall = new Student("Niall", "Fraser", "Niall Fraser", day33);
      Student Warner = new Student("Warner", "Carpenter", "Warner Carpenter", day33);
      Student Kirren = new Student("Kirren", "Covey", "Kirren Covey", day34);
      Student Mo = new Student("Mo", "Silvera", "Mo Silvera", day35);
      List<Student> students = new List<Student>() {
Niall,
Warner,
Kirren,
Mo
};

      List<Student> sortedLastName = students.OrderBy(student => student.LastName).ToList();

      foreach (var student in sortedLastName)
      {
        Console.WriteLine($"{student.LastName}");
      }

      IEnumerable<Student> studentInCohort34 = from count in students
                                               where count.Cohort == day34
                                               select count;
      foreach (Student student in studentInCohort34)
      {
        Console.WriteLine($"The students in {student.Cohort} are {student.FirstName} {student.LastName}");
      }

      Instructor Steve = new Instructor("Steve", "Brownlee", "Steve Brownlee", day33);
      Instructor Jisie = new Instructor("Jisie", "David", "Jisie David", day34);
      Instructor Joe = new Instructor("Joe", "Shepherd", "Joe Shepherd", day35);
      List<Instructor> AllInstructors = new List<Instructor>(){
    Steve,
    Jisie,
    Joe
};
      IEnumerable<Instructor> instructorInCohort35 = from count in AllInstructors
                                                     where count.Cohort == day35
                                                     select count;
      foreach (Instructor instructor in instructorInCohort35)
      {
        Console.WriteLine($"The instructor for {instructor.Cohort} is {instructor.FirstName} {instructor.LastName}");
      }

day33.Students.Add(Warner);
day33.Students.Add(Niall);
day34.Students.Add(Kirren);
day35.Students.Add(Mo);

      // Day33.Instructors.Add(Steve);
      // Day34.Instructors.Add(Jisie);
      // Day35.Instructors.Add(Joe);

      Steve.Assign(Kirren, Looping);
      Steve.Assign(Kirren, Style);
      Steve.Assign(Mo, Style);

      Jisie.Assign(Warner, Style);
      Jisie.Assign(Warner, Classes);

      Joe.Assign(Mo, ArrayMethods);
      Joe.Assign(Mo, Looping);

      Console.WriteLine($"Mo has {Mo.Exercises.Count} exercises.");
      Mo.Exercises.ForEach(exercise => Console.WriteLine($"{exercise.Name} {exercise.Language}"));
      Console.WriteLine($"Warner has {Warner.Exercises.Count} exercises.");
      Warner.Exercises.ForEach(exercise => Console.WriteLine($"{exercise.Name} {exercise.Language}"));
      Console.WriteLine($"Kirren has {Kirren.Exercises.Count} exercises.");
      Kirren.Exercises.ForEach(exercise => Console.WriteLine($"{exercise.Name} {exercise.Language}"));
      Console.WriteLine($"Niall has {Niall.Exercises.Count} exercises.");
      Niall.Exercises.ForEach(exercise => Console.WriteLine($"{exercise.Name} {exercise.Language}"));

       foreach(Cohort cohort in AllCohorts)
            {
                Console.WriteLine($"{cohort.Name} has {cohort.Students.Count} students.");
            }
    }
  }
}
