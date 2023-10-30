namespace Stack;
public class Stack
{
    public static void Main(string[] args)
    {
        int choice = 1;

        do
        {
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Sum");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a number: ");
                        string? inputUser = Console.ReadLine();

                        if (int.TryParse(inputUser, out int number))
                        {
                            Cstack.Push(number);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Cstack.Pop();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Cstack.Display();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Cstack.Sum();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        } while (choice != 5);
    }
}