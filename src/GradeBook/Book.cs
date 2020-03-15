    using System.Collections.Generic;
    using System;

    namespace GradeBook {
        public class Book {

            public Book (string name) {
                grades = new List<double> ();
                this.name = name;
            }
            public void AddGrade (double grade) {

                grades.Add (grade);
            }

            public Statistics GetStatistics () {

            
                var result = new Statistics();
                result.Low = double.MinValue;
                result.High = double.MaxValue;
                result.Average = 0.0;

                foreach (var grade in grades) {
                    result.High = Math.Max (grade, result.High);
                    result.Low = Math.Min (grade, result.Low);
                    result.Average += grade;
                }

                result.Average /= grades.Count;
                // System.Console.WriteLine ($"The average grade is {avg:N1} \nMax value is {highGrade}\nMin value is {lowGrade}");
                return result;
            }
            private List<double> grades;
            private string name;
        }
    }