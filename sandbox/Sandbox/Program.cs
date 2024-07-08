using System;
using System.Formats.Asn1;

class Program 
{

    static void Main (string[] args)
    {
        Console.WriteLine("Bonjour Tout Le Monde");
        Employee employee = new Employee ("Bob", 40, 23.77);
        Console.WriteLine ($"{employee.GetName()} is due: {employee.GetPay()}");


        ConstrucitonWork construcitonWorker = new ConstrucitonWork ("Betty", 40, 35.8);
        Console.WriteLine($"{construcitonWorker.GetName()} is due {construcitonWorker.GetPay()}");

        Doctor doctor = new Doctor ("Belinda", 240000.99);
        Console.WriteLine($"{doctor.GetName()} is due {doctor.GetPay()}");

        List <Employee> employees= new List <Employee>();
        employees.Add(employee);
        employees.Add (construcitonWorker);
        employees.Add (doctor);

        foreach (Employee e in employees)
        {
                    Console.WriteLine($"{e.GetName()} is due {e.GetPay()}");
        }
     
     
     
     
     
     
     
     
     
     
        // Person person1 = new Person ("Bob", "Billy", 24, 210);
        // Console .WriteLine (person1.PersonInformation());






    //     Circle myCircle = new Circle (10);
    //     Console.WriteLine ($"{myCircle.GetArea}");

    //     Circle unitCircle = new Circle (1);
    //    Console. WriteLine($"{unitCircle.GetCircumference()}") ;
    //     Console.WriteLine($"{unitCircle.GetDiameter}");
    }



    


    }
    