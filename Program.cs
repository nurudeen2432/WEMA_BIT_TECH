using BIT_TECH_NURUDEEN_DUROWADE.Model.Payments;

using BIT_TECH_NURUDEEN_DUROWADE.Model.Users;

namespace BIT_TECH_NURUDEEN_DUROWADE.User;

// See https://aka.ms/new-console-template for more information
public class Program
{

    public static void Main(string[] args)
    {





        Console.WriteLine("Triangle Area Calculator");

        // Input base and height from the user
        Console.Write("Enter the base of the triangle: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the triangle
        double area = CalculateTriangleArea(baseLength, height);



        // Display the result
        Console.WriteLine($"The area of the triangle with base {baseLength} and height {height} is: {area}");

        Console.ReadLine(); // Pause console to view the result

    


        List<Users> userList = new List<Users>()
    {
        new Users()
        {
       Id=1,
       FirstName="Henry",
       LastName="Okafor",
       Email="henry.okafor@yahoo.com"
        },
            new Users()
            {
                Id=2,
                FirstName="Francis",
                LastName="George",
                Email="francis.george@gmail.com"
            },
            new Users()
            {
                        Id=3,
                        FirstName="Opeyemi",
                        LastName="Coker",
                        Email="opeyemi.coker@gmail.com"


                        },
                                new Users(){
                                Id=4,
                                FirstName="Bethel",
                                LastName="John",
                                Email="bethel.john@gmail.com"

                                },
            new Users(){
                                        Id=5,
                                        FirstName="Mary",
                                        LastName="Chiuzor",
                                        Email="mary.chibuzor@hotmail.com"

                                        },
    };

        List<Payments> payments = new List<Payments>()
        {

            new Payments() {Id=1, Paymount_Amount=356.99, User_id=10 },
            new Payments() {Id = 2, Paymount_Amount=678.88, User_id=20},
            new Payments() {Id=3, Paymount_Amount=678.88, User_id=30},
            new Payments() {Id=4, Paymount_Amount=978.88, User_id=40},
            new Payments() {Id=5, Paymount_Amount=878.88, User_id=50},
        };

        
        
       foreach(var user in userList)
        {
          

                Console.WriteLine($"ID:{user.Id}\n Name:{user.FirstName}\n  Surname:{user.LastName}\n  Email:{user.Email}");

            foreach(var x in payments)
            {
                if(x.Id == user.Id)
                {

                    Console.WriteLine($" ID:{x.User_id}\n Amount Paid:{x.Paymount_Amount}");
                }
            }
            
        }


        // Function to calculate the area of a triangle
        static double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }



    }






    
}








public class Payment
{
    public static string Name = "Johnson";
    public static void Greet()
    {
        Console.WriteLine("Good Morning");


    }

    public void GreetMe()
    {
        Console.WriteLine("Good Afternoon");
    }

    public string GreetHim()
    {
        return Name;
    }

    
}


