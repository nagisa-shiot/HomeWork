Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

Console.Write("Введите минимальное значение в массиве: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максиммальное значение в массиве: ");
int c = Convert.ToInt32(Console.ReadLine());

void mas(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(b,c);
        Console.Write(randomArray[i] + " ");
    }

}

int kol(int[] randomArray)
{
    int sum = 0;
    int i = 0;
    while (i < randomArray.Length)
    {
        sum = sum + randomArray[i];
        i = i + 2;
    }
    return sum;
}
mas(a);
Console.Write($"\nCумма элементов, стоящих на нечётных позициях: {kol(randomArray)}");
