int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

Console.WriteLine(InCenter(number));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}