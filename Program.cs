using System;

namespace Get_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName,LastName,age;
            int Age;
            Console.WriteLine("Please Enter Your Fist Name!");
            FirstName=Console.ReadLine();
            while (FirstName == "")
            {
                Console.WriteLine("Please Enter Your Fist Name");
                FirstName=Console.ReadLine();
            }
            Console.WriteLine("Please Enter Your Last Name!");
            LastName=Console.ReadLine();
            while (LastName == "")
            {
                Console.WriteLine("Please Enter Your Last Name");
                LastName=Console.ReadLine();
            }
            Console.WriteLine("Please Enter Your Age!");
            age=Console.ReadLine();

             while (age=="")
            {
                Console.WriteLine("Please Enter Your Age!");
                age=Console.ReadLine();
            }
            Age=Convert.ToInt32(age);
            while (Age<=0||Age>=100)
            {
                Console.WriteLine("Please Enter Your Age between 1 and 99");
                age=Console.ReadLine();
                Age=Convert.ToInt32(age);
            }
        }
    }
}
