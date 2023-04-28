Console.WriteLine("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());
int[] num = new int[size];
RandomNum(num);
Console.WriteLine("В массиве: ");
PrintArray(num);

int count = 0;

for (int x = 0; x < num.Length; x++)
{
    if (num[x] % 2 == 0)
        count++;
}
Console.WriteLine($"из {num.Length} чисел, {count} четных");
void RandomNum(int[] num)
{
    for (int i = 0; i < size; i++)
    {
        num[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}