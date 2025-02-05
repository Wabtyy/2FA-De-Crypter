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
    List<int> indices = new List<int> { 0, 1, 2, 3 }; 
    foreach (int index in indices)
    {
        abc += ((a[index] * random) % 26 + 'a').ToString();
    }

    string output = abc.Substring(0, 4);
    Console.WriteLine(output + " | " + random);
    Thread.Sleep(5000);
    Console.Clear();
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
