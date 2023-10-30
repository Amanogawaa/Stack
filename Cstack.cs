using System.Text;
public class Cstack
{
    public static int[] stack = new int[10];
    public static int top = -1;

    public static void Push(int number)
    {
        if (top < stack.Length - 1)
        {
            top++;
            stack[top] = number;
            Console.WriteLine("Item successfully added.");
        }
        else
        {
            Console.WriteLine("Stack is full");
        }
    }

    public static int Pop()
    {
        if (top >= 0)
        {
            int pop = stack[top];
            stack[top] = 0;
            top--;
            Console.WriteLine("Item removed.");
            return pop;
        }
        else
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
    }

    public static void Display()
    {
        StringBuilder formattedList = new StringBuilder();
        formattedList.Append("[ ");
        for (int i = 0; i < stack.Length; i++)
        {
            formattedList.Append(stack[i]);
            if (i < stack.Length - 1)
            {
                formattedList.Append(" , ");
            }
        }
        formattedList.Append(" ]");
        Console.WriteLine(formattedList.ToString());
    }

    public static void Sum()
    {
        if (top >= 0)
        {
            int sum = 0;
            for (int i = 0; i <= top; i++)
            {
                sum += stack[i];
            }
            Console.WriteLine($"Sum: {sum}");
        }
        else
        {
            Console.WriteLine("Stack is Empty");
        }
    }
}