using System;

namespace WorkingWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcom to our bicke shope :-");
            Console.WriteLine("if you want to continue press 1");
            int entry = int.Parse(Console.ReadLine());
            Console.WriteLine("if you want to buy bickle pleas inter year model");
            Console.WriteLine("pleas enter year :- ");
                int year = int.Parse(Console.ReadLine());

            Bickle mybickle = new Bickle();
            mybickle.Make = "Gegante";
            mybickle.Model = "MountainBickle";
            mybickle.Year = 1997;
            mybickle.Brand = "xxl";
            Console.WriteLine("{0} {1} {2} {3}",mybickle.Make, mybickle.Model, mybickle.Year, mybickle.Brand);
            //decimal myvalue = myvalue.DetermainingValue();
            Console.WriteLine("{0:c}",mybickle.DetermainingValue());
            Console.ReadLine();
        }
    }
    class Bickle
    {


        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        
        public string Brand { get; set; }

        public decimal DetermainingValue()
        {
          
            decimal myvalue;
            if (Year > 1998)
                myvalue = 1599.0M;
            else
                myvalue = 3000.0M;
            return myvalue;
        }

    }
    
        
}
    
