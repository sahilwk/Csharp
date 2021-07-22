using System;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var s=new sample<double>();//uses double
            s.name=90.3;
            System.Console.WriteLine(s.func());

            var s1=new sample<string>(); //uses string
            s1.name="sahil";
          
            System.Console.WriteLine(s1.func());


            var s2=new sample<object>();  //can have both string and double but considers the latest assigned value for computing
             
            s2.name=98.7;
            s2.name="sahilassasa";
            System.Console.WriteLine(s2.func());
        }
    }
}
