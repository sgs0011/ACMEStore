using System;/*Steven Shetler,
* The purpose of this application is to allow the user to input product codes and quantities
* that are listed in the WelcomeMessage method.
* The inputs are taken from the InputOrder method and printed out through the PrintResults method.
* The TransactionTest class drives our application.*/

public class Transaction
{
    public string CustomerName { get; set; }//auto-implemented property

    //creating instance variables
    decimal total = 0;
    decimal lineTotal = 0;
    private string items = "";

    //creating the constructor for Transaction class
    public Transaction(string cName)
    {
        CustomerName = cName;
    }
    public void WelcomeMessage()//method that prompts user to enter customer name and welcomes them to the application
    {
        Console.WriteLine($"\nWelcome, {CustomerName}, to ACME Corporation's Product Shop!");
        Console.WriteLine("\nPlease choose from the following products by entering the product code followed by the quantity. Enter <ctrl> d to exit:\n\n");

        Console.WriteLine("Product #   | Product Name              | Price");
        Console.WriteLine("------------|---------------------------|--------");
        Console.WriteLine("Product 201 | ACME Anvil                | $19.99");
        Console.WriteLine("Product 556 | ACME Dynamite             | $59.99");
        Console.WriteLine("Product 558 | ACME Hi-Speed Tonic       | $20.50");
        Console.WriteLine("Product 909 | ACME Crash Helmet         | $105.99");
        Console.WriteLine("Product 910 | ACME Magnet               | $16.99");
        Console.WriteLine("-------------------------------------------------");

        Console.WriteLine("\nPlease choose from the following products by entering the product code followed by the quantity. Enter <ctrl> d to exit:\n\n");
    }
    public void InputOrder()//method that will take the order from the user
    { 
        Console.Write("{0}","Product code: ");
        string input = Console.ReadLine();
      
        while (input != null)//while loop
        {
            int code = int.Parse(input);

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            switch (code)
            {
                case 201:
                    lineTotal = 19.99m * quantity;
                    total += lineTotal;
                    items += $"\nProduct 201 - ACME Anvil       @19.99       *{quantity}         = {lineTotal:c}";
                    break;
                case 556:
                    lineTotal = 59.99m * quantity;
                    total += lineTotal;
                    items += $"\nProduct 556 - ACME Anvil       @59.99       *{quantity}         = {lineTotal:c}";
                    break;
                case 558:
                    lineTotal = 20.50m * quantity;
                    total += lineTotal;
                    items += $"\nProduct 558 - ACME Anvil       @20.50       *{quantity}         = {lineTotal:c}";
                    break;
                case 909:
                    lineTotal = 105.99m * quantity;
                    total += lineTotal;
                    items += $"\nProduct 909 - ACME Anvil       @105.99      *{quantity}         = {lineTotal:c}";
                    break;
                case 910:
                    lineTotal = 16.99m * quantity;
                    total += lineTotal;
                    items += $"\nProduct 910 - ACME Anvil       @16.99       *{quantity}         = {lineTotal:c}";
                    break;
                default:
                    break;
            }
            Console.Write("{0}", "\nProduct code: ");
            input = Console.ReadLine();
        }
    }
    public void PrintResults()//method that will print out the results of the application
    {
        Console.WriteLine($"\n\nCustomer Name: {CustomerName}");

        Console.WriteLine("\nItems Ordered:\n");
        Console.WriteLine("Product #   Product Name       Price        Qty        Line Total");

        Console.WriteLine("-----------------------------------------------------------------");

        Console.Write(items);

        Console.WriteLine("\n-----------------------------------------------------------------");

        Console.Write($"\n\nInvoice Total: {total:c}");
    }
}
