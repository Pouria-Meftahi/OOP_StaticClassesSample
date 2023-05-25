
public class RequestData
{
    public static string GetString(string message)
    {
        Console.Write(message);
        string output = Console.ReadLine();
        return output;
    }
    public static double GetADouble(string messagge)
    {
        Console.Write(messagge);
        string numberText = Console.ReadLine();
        double output;
        bool isDouble = double.TryParse(numberText, out output);
        while (isDouble == false)
        {
            Console.WriteLine("This was not a valid number. Please try again.");
            Console.Write(messagge);
            numberText = Console.ReadLine();

            isDouble = double.TryParse(numberText, out output);
        }
        return output;
    }
}
