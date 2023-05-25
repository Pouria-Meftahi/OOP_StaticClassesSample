internal class Program
{
    /// <summary>
    /// Pro Tip: Use class files to separate your codes 
    /// so that each class and each method has its own purpose.(DRY)
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        CalculateData.myAge = 30;
        string firstName = RequestData.GetString("Whats is your firs name: ");
        UserMessages.ApplicationStartMessage(firstName);

        double y = RequestData.GetADouble("Please enter your first number: ");
        double x = RequestData.GetADouble("Please enter your second number: ");
        // single responsibility principle
        double result = CalculateData.Add(x, y);
        UserMessages.PrintResultMessage($"The sum of {x} and {y} is {result}");
        Console.ReadLine();
    }
}