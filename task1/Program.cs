
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

Console.WriteLine("Введите первое число");
int m = InputExamNumber();
Console.WriteLine("Введите второе число");
int n = InputExamNumber();

int max;
int min;

if (m < n)
{
    max = n;
    min = m - 1;
}
else
{
    max = m;
    min = n - 1;
}

int [] array = new int[max-min];

for (int i = 0; i < array.Length; i++)
    {
        array[i] = min + 1;
        min = min + 1;
        Console.Write($"{array[i]}\t");
    }
Console.WriteLine();
for (int i = 0; i < array.Length / 2; i++)
{
   int tmp = array[i];
   array[i] = array[array.Length - i - 1];
   array[array.Length - i - 1] = tmp;
}

for (int i = 0; i < array.Length; i++)
    {
            Console.Write($"{array[i]}\t");
    }
