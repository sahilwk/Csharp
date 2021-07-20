using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {   
            var st =new Student("sahil"); //creating a new object
            st.AddGrade(56.3);
            st.AddGrade(78.2);

            Console.WriteLine($"The average marks of ${st.name} is ${st.getAverage()}");
        }
    }
}
