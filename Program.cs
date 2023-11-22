using BIT_TECH_NURUDEEN_DUROWADE.Model.Payments;
using BIT_TECH_NURUDEEN_DUROWADE.Model.Users;
using BIT_TECH_NURUDEEN_DUROWADE.Model.Calculator;
using Newtonsoft.Json;
using System.Text.Json.Serialization;


// See https://aka.ms/new-console-template for more information
public class Program
{

    public static void Main(string[] args)
    {
        List<Payment> payments = new List<Payment>()
        {

            new Payment() {Id=1, Paymount_Amount=356.99, User_id=10 },
            new Payment() {Id = 2, Paymount_Amount=678.88, User_id=20},
            new Payment() {Id=3, Paymount_Amount=678.88, User_id=30},
            new Payment() {Id=4, Paymount_Amount=978.88, User_id=40},
            new Payment() {Id=5, Paymount_Amount=878.88, User_id=50},
        };



        List<User> userList = new List<User>()
    {
        new User()
        {
       Id=1,
       FirstName="Henry",
       LastName="Okafor",
       Email="henry.okafor@yahoo.com",
       Payments=payments.Where(x => x.User_id == 10).ToList(),
       
        },
            new User()
            {
                Id=2,
                FirstName="Francis",
                LastName="George",
                Email="francis.george@gmail.com",
                Payments=payments.Where(x => x.User_id == 20).ToList()
            },
            new User()
            {
                        Id=3,
                        FirstName="Opeyemi",
                        LastName="Coker",
                        Email="opeyemi.coker@gmail.com",
                        Payments=payments.Where(x => x.User_id == 30).ToList()



                        },
                                new User(){
                                Id=4,
                                FirstName="Bethel",
                                LastName="Johnson",
                                Email="bethel.johnson@gmail.com",
                                Payments=payments.Where(x => x.User_id == 40).ToList()

                                },
            new User(){
                                        Id=5,
                                        FirstName="Mary",
                                        LastName="Chiuzor",
                                        Email="mary.chibuzor@hotmail.com",
                                        Payments=payments.Where(x => x.User_id == 50).ToList()

                                        },
    };


        var userPayment = userList.Where(x=> x.Id== 1).ToList();

        var json = JsonConvert.SerializeObject(userPayment, Formatting.Indented);


        foreach (var user in userList)
        {


            Console.WriteLine($"ID:{user.Id}\n Name:{user.FirstName}\n  Surname:{user.LastName}\n  Email:{user.Email}");

            foreach (var x in payments)
            {
                if (x.Id == user.Id)
                {

                    Console.WriteLine($" ID:{x.User_id}\n Amount Paid:{x.Paymount_Amount}");
                }
            }

        }



         Calculator Calc = new Calculator();

        // Calc.Calculating();

        var studentName = new string[3] {"Jide ", "Bola", "Sammy" };

        //Console.WriteLine($"The student tag for Bola is {studentName[1]}");

        for(int counter = 0; counter >= studentName.Length; counter++)
        {
            Console.WriteLine(studentName[counter]);
        }

        foreach(string student in studentName)
        {
            Console.WriteLine(student);
        }


        List<string> members = new List<string>();

            members.Add("Nurudeen");
    }

}








public class Pay
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


