using System.Collections.Generic;


namespace GradeBook{

    class Student{
        public Student(string name){
            this.name=name;
            grades=new List<double>();
        }
        public void AddGrade(double grade){
            grades.Add(grade);
        }

        List<double> grades;
        public string name;

        public double getAverage(){
            double ans=0.0;
            foreach(double x in this.grades){
                ans=ans+x;
            }
            return ans/(grades.Capacity);
        }
    }
}