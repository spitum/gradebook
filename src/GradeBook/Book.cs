    using System.Collections.Generic;
    using System;

    namespace GradeBook {
        class Book {

            public Book (string name) {
                grades = new List<double> ();
                this.name = name;
            }
            public void AddGrade (double grade) {

                grades.Add (grade);
            }

            public void ShowStatistics () {
                var result = 0.0;
                var highGrade = double.MinValue;
                var lowGrade = double.MaxValue;
                var AvgGrade = 0.0;

                foreach (double number in grades) {
                    highGrade = Math.Max (number, highGrade);
                    lowGrade = Math.Min (number, lowGrade);
                    result += number;
                }

                var len = grades.Count;
                var avg = result / len;
                System.Console.WriteLine ($"The average grade is {avg:N1} \nMax value is {highGrade}\nMin value is {lowGrade}");
            }
            private List<double> grades;
            private string name;
        }
    }