using System;

namespace OOPSc_{

    public class Teacher:Person{
        public Teacher(string name):base(name){
           System.Console.WriteLine("In Teacher");
       }

       public void Explain(){
           System.Console.WriteLine("Teaching!");
       }
    }








}