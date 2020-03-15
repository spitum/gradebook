using System;
using System.Collections.Generic;

namespace GradeBook {

    class Program {


        static void Main (string[] args) {

            Book book2 = new Book("test book");
            book2.AddGrade(65.2);

            var book = new Book ("Test book 2");
            book.AddGrade(90.3);
            book.AddGrade(80.3);
            book.AddGrade(75.2);
            book.AddGrade(20.2);       
            book.ShowStatistics();


        }
    }
}