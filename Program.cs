int num = 0;
int result = 0;
string input;
Stack stack = new Stack(100);

Console.Write("Digite:");
while ((input = Console.ReadLine() ?? "0") != "exit")
{
    int n;
    bool isNumeric = int.TryParse(input, out n);
    if (isNumeric)
    {
        if (stack.IsFull())
            Console.WriteLine("StackOverFlow");
        else
            stack.Push(int.Parse(input)); ;
    }
    else
    {
        num = stack.Pop();
        if (stack.IsEmpty())
        {
            Console.WriteLine("É nescessario pelo menos 2 numeros para fazer uma operação");
        }
        else
        {
            switch (input)
            {
                case "-":
                    result = stack.Pop() - num;
                    break;
                case "+":
                    result = stack.Pop() + num;
                    break;
                case "*":
                    result = stack.Pop() * num;
                    break;
                case "/":
                    result = stack.Pop() / num;
                    break;
            }
            stack.Push(result);
            Console.WriteLine(result);
        }

    }
    Console.Write("Digite:");
}