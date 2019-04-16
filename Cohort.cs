using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
      public string Name {get; set;}
    public List<Student> Students = new List<Student>();
    public List<Instructor> Instructors = new List<Instructor>();
    public Cohort(string name) {
      Name = name;
    }

    public Cohort() {

    }

    public override string ToString() {
      return $@"{Name}";
    }

    }
}
