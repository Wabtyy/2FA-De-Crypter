using System.Text;
Random rnd = new Random();
while (true)
{
    string input;

    Console.Write("Crypter / Decrypter : ");
    string method = Console.ReadLine().ToLower();
    Console.Clear();

    Console.WriteLine("Email: ");
    input = Console.ReadLine();
    Console.Clear();

    string a = FilterAlphanumeric(input);
    int random;

    if (method == "crypter")
    {
        random = rnd.Next(0, a.Length);
    }
    else
    {
        Console.WriteLine("Random Number:");
        random = int.Parse(Console.ReadLine());
    }

    string abc = "";
    List<int> indices = new List<int> { 0, 1, 2, 3 }; // Hier einfach eine feste Auswahl, um den Code zu reproduzieren

    foreach (int index in indices)
    {
        abc += StringToNumber((a[index] * random).ToString());
    }

    string output = GetFirstFourDigits(abc);
    Console.WriteLine(output + " | " + random);
    Thread.Sleep(5000);
    Console.Clear();
}



static string GetFirstFourDigits(string input)
{
    return input.Length >= 4 ? input.Substring(0, 4) : input;
}
static string StringToNumber(string input)
{
    if (char.IsLetter(input[0]))
    {
        return ((input.ToLower()[0] - 'a') % 10).ToString();
    }
    return input;
}
static string FilterAlphanumeric(string input)
{
    StringBuilder result = new StringBuilder();
    foreach (char c in input)
    {
        if (char.IsLetterOrDigit(c))
        {
            result.Append(c);
        }
    }
    return result.ToString();
}