// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] generateArray(int Length, int start, int end)
{
    int [] result = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}
void printArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] );
         if(i < array.Length - 1)
         {
            Console.Write(", ");
         }
    }
     Console.Write("]");
}
int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan; 
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int getCountOfEvenNumber(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ( array[i] % 2 == 0)
        {
            count = count +1;
        }
        else 
        {
            count = count + 0;
        }
    }
    return count;
}
int Number = getUserData("Введите количество элементов в массиве");
int [] array = generateArray(Number, 100, 999);
printArray(array);
int CountOfEvenNumber = getCountOfEvenNumber(array);
Console.Write($"Количество четных чисел в массиве равно {CountOfEvenNumber}");