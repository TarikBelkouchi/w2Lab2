Dictionary<string, decimal> shoes = new Dictionary<string, decimal>();
shoes.Add("Nike Air Force 1", 92.00m);
shoes.Add("Yeezy Boost 350", 234.99m);
shoes.Add("Jordan 4 Retro", 284.00m);
shoes.Add("Timberland Boots", 198.00m);
shoes.Add("UGG Tasman", 100.00m);
shoes.Add("KOBE AD NXT FF", 205.00m);
shoes.Add("Lebron 9", 309.00m);
shoes.Add("Converse Chuck Taylor", 59.99m);
shoes.Add("Vans Classic Slip-Ons", 65.00m);



List<string> cart = new List<string>();


Console.WriteLine("Welcome to Foot Locker");
Console.WriteLine("Take a look at what we have in stock");
bool runProgram = true;
while (runProgram)
{
 
    foreach (KeyValuePair<string, decimal> item in shoes)
    {
        Console.WriteLine(string.Format("{0,-10} {1,10}", item.Key, item.Value));
    }


    Console.WriteLine("What would you like to order?");
    string items = Console.ReadLine();

    if (shoes.ContainsKey(items))
    {
        Console.WriteLine($"You chose the {items} for {shoes[items]}");
        cart.Add(items);
        while (true)
        {
            Console.WriteLine("Would you like to add more to cart? (y/n)");
            string loopChoice = Console.ReadLine();
            if (loopChoice == "y")
            {
                runProgram = true;
                break;
            }
            else if (loopChoice == "n")
            {
                runProgram = false;
                break;
            }
            else
            {
                Console.WriteLine("Not a valid response!");
            }
        }
    }
    else
    {
        Console.WriteLine("We don't currently have those in stock.");
    }
}

Console.WriteLine();
Console.WriteLine("This is your order:");
decimal total = 0;

foreach (string item in cart)
{
    Console.WriteLine(string.Format("{0,-10} {1,10}", item, shoes[item]));
    total += shoes[item];
}

Console.WriteLine($"Average price per item in order was{Math.Round(total / cart.Count, 2)}");