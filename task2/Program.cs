int InputExamNumber()
{
    int num;
    string input = Console.ReadLine();
    bool number = int.TryParse(input, out num);

    while (number == false)
    {
        Console.WriteLine("\nНужно ввести число!");
        input = Console.ReadLine();
        number = int.TryParse(input, out num);
    }
    Console.WriteLine($"Введено число {input}");
    return num;
}

int Sum(int m, int n)
{
    int max;
    int min;
    if (m > n)
    {
        max = m;
        min = n;
    }
    else
    {
        max = n;
        min = m;
    }
    int[] array = new int[max - (min-1)];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = min;
        ++min;
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();

    int sum=0;

    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}
Console.WriteLine("Введите первое число");
int m = InputExamNumber();
Console.WriteLine("Введите второе число");
int n = InputExamNumber();
Console.Write(Sum(m, n));
