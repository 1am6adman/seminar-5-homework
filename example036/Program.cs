Console.WriteLine("Введите размер массива  ");
int size = int.Parse(Console.ReadLine());
int[] num = new int[size];
ArrayRandomNum(num);
Console.WriteLine("массив: ");
PrintArray(num);
int sum = 0;

for (int z = 0; z < num.Length; z += 2)
    sum = sum + num[z];

Console.WriteLine($"всего {num.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

void ArrayRandomNum(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(1, 10);
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
