int [] array = new int [7];
for (int i = 0; i < 7; i++)
{
    array[i] = new Random().Next(100, 1000);
}
int count = 0; //количество четных чисел
for (int i = 0; i < 7; i++)
{
    if (array[i] % 2 ==0)
    { 
        count += 1;
    }
};
Console.WriteLine(count);