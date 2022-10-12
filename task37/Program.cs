/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

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
int[] newArray(int[] incomingArray)
{
    int lengthOfNewArray = (int)Math.Ceiling(incomingArray.Length / 2.0);//Math.Ceiling(); округляет значение вверх, например 3,1 = 4
    int[] result = new int[lengthOfNewArray];
    for (int i = 0; i < lengthOfNewArray; i++)
    {
        if (i != incomingArray.Length - i - 1)
        {
            result[i] = incomingArray[i] * incomingArray[(incomingArray.Length - i) - 1];
        }
        else
        {
            result[i] = incomingArray[i];
        }
    }
    return result;
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] currentArray = getRandomArray(length, 1, 10);
printArray(currentArray);
int[] result = newArray(currentArray);
printArray(result);
