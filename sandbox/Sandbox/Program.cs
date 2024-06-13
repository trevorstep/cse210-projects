using System;
using System.Formats.Asn1;

class Program
{

    static double CalculateCircleArea ( double radius)
    {
       double area =0;
       area = Math.PI * radius *radius;
        return area;
    }




    static void Main(string[] args)
    {        
        double area = CalculateCircleArea (10);
        Console.WriteLine($"F3: The circle's area is: {area.ToString("F3")}");





        // Console.WriteLine("Hello Sandbox World!");
        // Console.WriteLine ("Bababooie.");
        // for (int j =0; j < 10; j++ )
        //     Console.WriteLine (j);


        // int UserAge = -1;

        // while (UserAge < 0 || UserAge > 120)
        // {
        //     Console.WriteLine("Please input your age (0-120): ");
        //     UserAge = int.Parse (Console.ReadLine());
        // }

        // int userAge2 =65561561;
        // do
        // {
        //     Console.WriteLine ("Please input your age (0-120):");
        //     userAge2 = int.Parse (Console.ReadLine());
        // } while (userAge2 <0 || userAge2 > 120); 


        // for (int i = 0; i<100; i++) //first set creates varible, second will continue to run the for loop as long as it remains true, third will add 1 at the end of every itteration. 
        // Console.WriteLine(""+i);

        // List <int> myNumbers = new List <int> (1,2,3,4,5,6,7,8,);
        // List <string> myNames = new List<string> ();
        // myNames.Add("Bob");
        // myNames.Add("Billybob");
        // myNames.Add ("Betty");

        // // myNumbers.Add(12);


        // foreach(string name in myNames)
        // {
        //     Console.WriteLine(""+name);
        // }    
    
    }
}