// See https://aka.ms/new-console-template for more information

class Program
{
    public static int Sum(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
    public static int Sub(int a, int b)
    {
        int sum = a - b;
        return sum;
    }
    public static int Mult(int a, int b)
    {
        int sum = a * b;
        return sum;
    }
    public static int Div(int a, int b)
    {
        int sum = a / b;
        return sum;
    }
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        char k = Convert.ToChar(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        switch (k)
        {
            case '*':
                Console.WriteLine(Mult(a, b));
                break;
            case '/':
                Console.WriteLine(Div(a, b));
                break;
            case '-':
                Console.WriteLine(Sub(a, b));
                break;
            case '+':
                Console.WriteLine(Sum(a, b));
                break;


        }

    }
}