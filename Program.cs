Console.Clear();
int option;
while (true)
{
    Console.WriteLine($"\n1 - Add a product");
    Console.WriteLine($"2 - Update a product");
    Console.WriteLine($"3 - Search a product");
    Console.WriteLine($"4 - Delte a product");
    Console.WriteLine($"5 - Terminate session");
    Console.WriteLine($"Choose a option:");
    option = Convert.ToInt16(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.WriteLine($"Product added");
            break;
        case 2:
            Console.WriteLine($"Product updated");
            break;
        case 3:
            Console.WriteLine($"Product found");
            break;
        case 4:
            Console.WriteLine($"Product deleted");
            break;
        case 5:
            Console.WriteLine($"end session");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine($"invalid option");
            break;
    }
}