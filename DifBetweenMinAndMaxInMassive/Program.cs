int [] array = new int [] {10, 284, 35, 90, 1836, 5, 18};
int MinInArray = array [0]; // минимальное в массиве
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < MinInArray)
    {
        MinInArray = array[i];
    }
}

int MaxInArray = array [0]; // масимальное в массиве
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > MaxInArray)
    {
        MaxInArray = array[i];
    }
}

int dif = MaxInArray - MinInArray; //разница
Console.WriteLine(dif);