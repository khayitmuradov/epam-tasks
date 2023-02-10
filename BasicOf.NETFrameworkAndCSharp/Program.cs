decimal decimalNumber;
int newBase;
string result = "";

Console.Write("Enter a decimal number: ");
decimalNumber = decimal.Parse(Console.ReadLine());

Console.Write("Enter the base of the new number system (2-20): ");
newBase = int.Parse(Console.ReadLine());

while (decimalNumber > 0)
{
    int remainder = (int)(decimalNumber % newBase);
    result = remainder + result;
    decimalNumber /= newBase;
}

Console.WriteLine("The converted number is: " + result);