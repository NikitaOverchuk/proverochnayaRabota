int arrayLenght = Convert.ToInt32(Console.ReadLine());
int index = 0;
string[] array = new string[arrayLenght];
int k = 3;
while (index < arrayLenght)
{
    array[index] = Console.ReadLine();
    index = index + 1;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.Write("[");
index = 0;
while (index < arrayLenght)
{
    if (array[index].Length <= k)
    {
        Console.Write(array[index]);
    }
    index = index + 1;
}
Console.WriteLine("]");
