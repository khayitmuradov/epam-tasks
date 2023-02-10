#nullable disable

Console.Write("Enter an decimal: ");
decimal num = decimal.Parse(Console.ReadLine());
int intNum = Decimal.ToInt32(num);

Console.WriteLine(intNum);

// With 2 to 20 base number system, I have no idea what to do. Should I create this, should I use a base system called Vigesimal
// 