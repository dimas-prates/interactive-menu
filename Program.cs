Console.Clear();
int option;
int[] history = new int[0];
int[] OptionsHistory(int[] array, int option)
{
    Array.Resize(ref array, array.Length + 1);
    array[array.Length - 1] = option;
    return array;
}
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
            history = OptionsHistory(history, option);
            break;
        case 2:
            Console.WriteLine($"Product updated");
            history = OptionsHistory(history, option);
            break;
        case 3:
            Console.WriteLine($"Product found");
            history = OptionsHistory(history, option);
            break;
        case 4:
            Console.WriteLine($"Product deleted");
            history = OptionsHistory(history, option);
            break;
        case 5:
            Console.WriteLine($"\nSession terminated");
            history = OptionsHistory(history, option);
            Console.WriteLine($"\nHistory of chossen options:");
            Array.ForEach(history, Console.WriteLine);
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine($"invalid option");
            break;
    }

}