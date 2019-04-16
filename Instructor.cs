using System;
using System.Collections.Generic;

namespace StudentExercises
{
  class Instructor
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public Cohort Cohort { get; set; }

    public Instructor(string fName, string lName, string slackHandle, Cohort cohort)
    {
      FirstName = fName;
      LastName = lName;
      SlackHandle = slackHandle;
      Cohort = cohort;
    }
    public Instructor()
    {

    }
    public string FullName
    {
      get
      {
        return FirstName + " " + LastName;
      }
    }

    public void Assign(Student student, Exercise exercise)
    {
      student.Exercises.Add(exercise);
    }
  }
}
