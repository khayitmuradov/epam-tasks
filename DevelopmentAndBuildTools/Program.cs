namespace DevelopmentAndBuildTools;

public class Program
{
    public static void Main(string[] args)
    {
        string? chars = Console.ReadLine();

        Console.Write(ConsecutiveCharacters(chars));
    }

    public static int ConsecutiveCharacters(string characters)
    {
        int length = characters.Length;
        int max = Int32.MinValue;
        int count = 1;

        for (int i = 0; i < length - 1; i++)
        {
            if (characters[i] != characters[length - 1])
            {
                count++;
                max = Math.Max(max, count);
            }
            else if (characters[i] == characters[length - 1])
            {
                count -= 1;
                max = Math.Max(max, count);
            }
            else
            {
                count = 1;
            }
        }

        if (max > count)
        {
            return max;
        }
        else
        {
            return count;
        }
    }
}