/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76
*/

int getNumberFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            Console.WriteLine($"Ошибка ввода! Введите целое число: [{userLine}].");
        }
        else
        {
            break;
        }
    }
    return result;
}

void printArray(double[] incomingArray) //печатаем массив
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

double GetRandomNumber(double minimum, double maximum) //генерация вещественных рандомных чисел
{
    Random random = new Random();
    return random.NextDouble() * (maximum - minimum) + minimum;
}

double[] getRandomArray(int length, int startPoint, int endPoint) //создаем массив с рандомными значениями
{
    double[] resultArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = GetRandomNumber(0, 100);
    }
    return resultArray;
}
double FindMin(double[] incomingArray)
{
    double minPosition = incomingArray[0];
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (minPosition > incomingArray[i])
        {
            minPosition = incomingArray[i];
        }
    }
    return minPosition;
}
double FindMax(double[] incomingArray)
{
    double maxPosition = incomingArray[0];
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] > maxPosition)
        {
            maxPosition = incomingArray[i];
        }
    }
    return maxPosition;
}

int length = getNumberFromUser("Введите длину массива: ");
double[] currentArray = getRandomArray(length, 1, 10);
printArray(currentArray);
double result = FindMax(currentArray) - FindMin(currentArray);
Console.Write($"Разница между максимальным [{FindMax(currentArray)}] и минимальным [{FindMin(currentArray)}] элементами массива составит - [{result}]");
