namespace DevelopmentAndBuildTools;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the string: ");
        string? input = Console.ReadLine();

        int maxLength = 0;
        int currentLength = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                currentLength++;
            }
            else
            {
                maxLength = Math.Max(maxLength, currentLength);
                currentLength = 1;
            }
        }

        maxLength = Math.Max(maxLength, currentLength);

        Console.WriteLine("The maximum number of unequal consecutive characters is: " + maxLength);
    }
}