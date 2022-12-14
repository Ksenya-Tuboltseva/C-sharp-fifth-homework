int [] array = new int [15];
for (int i = 0; i < 15; i++)
{
    array[i] = new Random().Next();
}
int sum = 0; //сумма чисел на нечетных позициях
for (int i = 0; i < 15; i = i + 2)
{
    sum = sum + array[i];
}
Console.WriteLine(sum);