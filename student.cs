using System;

namespace OOPSc_{

    public  class Student:Person{
        
       public Student(string name):base(name){
           System.Console.WriteLine("In student");
           
       }

       public void study(){
           System.Console.WriteLine("Studying!");
       }
       
        
    }

    

}