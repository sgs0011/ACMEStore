using System;//Steven Shetler, ID: 800226059, This class drives the application

public class TransactionTest//class that will run our application
{
    public static void Main()//main method
    {
        Console.Write("Please enter the Customer Name: ");
        string cName = Console.ReadLine();

        Transaction tran963 = new Transaction(cName);//call to the constructor

        //calling on the object of the method
        tran963.WelcomeMessage();

        tran963.InputOrder();

        tran963.PrintResults();
    }
}