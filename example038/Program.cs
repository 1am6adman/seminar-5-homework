Console.WriteLine("Введите размер массива  ");
int size = int.Parse(Console.ReadLine());
double[] num = new double[size];
ArrayRandomNum(num);
Console.WriteLine("массив: ");
PrintArray(num);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < num.Length; z++)
{
    if (num[z] > max)
    {
        max = num[z];
    }
    if (num[z] < min)
    {
        min = num[z];
    }
}

Console.WriteLine($"всего {num.Length} чисел. Максимальное = {max}, минимальное = {min}");
Console.WriteLine($"Разница между ними = {max - min}");

void ArrayRandomNum(double[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] num)
{
    Console.Write("[ ");
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}