namespace UnitTestFrameworks.ClassLib;

public class StringUtilities
{
    public static int GetMaxUnequalConsecutiveChars(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }

        int max = 0, count = 0;

        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] != str[i - 1])
            {
                count++;
                if (count > max)
                {
                    max = count;
                }
            }
            else
            {
                count = 1;
            }
        }
        return max;
    }

    public static int GetMaxConsecutiveLetters(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }

        int max = 1, count = 1;
        for (int i = 1; i < str.Length; i++)
        {
            if (char.IsLetter(str[i]) && str[i] == str[i - 1])
            {
                count++;
                if (count > max)
                {
                    max = count;
                }
            }
            else
            {
                count = 1;
            }
        }
        return max;
    }

    public static int GetMaxConsecutiveDigits(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }

        int max = 1, count = 1;
        for (int i = 1; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]) && str[i] == str[i - 1])
            {
                count++;
                if (count > max)
                {
                    max = count;
                }
            }
            else
            {
                count = 1;
            }
        }
        return max;
    }
}
