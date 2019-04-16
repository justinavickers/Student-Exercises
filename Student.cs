using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
      public string FirstName {get; set;}
      public string LastName {get; set;}
      public string SlackHandle {get; set;}
      public Cohort Cohort {get; set;}


    public Student (string fName, string lName, string slack, Cohort cohort) {
      FirstName = fName;
      LastName = lName;
      SlackHandle = slack;
      Cohort = cohort;
    }

    public override string ToString()  {
      return $@"{FirstName} {LastName}";
    }
    public List<Exercise> Exercises = new List<Exercise>();

    }
}
