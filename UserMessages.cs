public class UserMessages
{
    public static void ApplicationStartMessage(string firstName)
    {
        Console.Clear();    
        Console.WriteLine("Welcome to tha static class demo app.");
        int hourOfDay = DateTime.Now.Hour;
        if (hourOfDay<22)
        {
            Console.WriteLine($"Good Morning! {firstName}");
        }
        else if (hourOfDay < 19)
        {
            Console.WriteLine($"Good Afternoon! {firstName}");
        }
        else
        {
            Console.WriteLine($"Good Evening! {firstName}");
        }
    }
    
    public static void PrintResultMessage(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine();
        Console.WriteLine("Thank you for using our app to calculate for you.");
    }
}
