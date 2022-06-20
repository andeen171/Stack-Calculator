class Stack
{
    private int[] vet;
    private int top;

    public Stack(int tam)
    {
        vet = new int[tam];
        top = 0;
    }

    public void Push(int x)
    {
        vet[top] = x;
        top++;
    }

    public int Pop()
    {
        top--;
        return (vet[top]);
    }

    public bool IsEmpty()
    {
        return (top == 0);
    }

    public bool IsFull()
    {
        return (top == vet.Length);
    }
}
