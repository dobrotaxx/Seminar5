/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

void printArray(int[] incomingArray) //печатаем массив
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
int[] getRandomArray(int length, int startPoint, int endPoint) //создаем массив с рандомными значениями
{
    int[] resultArray = new int[length]; /*новый массив int length - длина массива 
    int startPoint - число от которого будет рандом и int endPoint - число до которого*/
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1); //заполнаяем массив рандомными значениями
    }
    return resultArray; // возвращаем получившийся массив
}
int sumOfUnevenNumbers(int [] incomingArray)
{
    int result = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if(incomingArray[i] % 2 != 0)
        {
            result += incomingArray[i];
        }
    }
    return result;
}
int length = getNumberFromUser("Введите длину массива: ");
int[] currentArray = getRandomArray(length, 1, 10);
printArray(currentArray);
int result = sumOfUnevenNumbers(currentArray);
Console.Write($"Сумма всех нечетных чисел в массиве = {result}");