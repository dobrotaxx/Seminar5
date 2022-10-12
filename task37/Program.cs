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
    int[] result = incomingArray;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        for (int j = incomingArray.Length - 2;j < incomingArray.Length; j = incomingArray.Length - j - 2)
        {

            result[i] = incomingArray[i] * incomingArray[j];
        }

    }
    return result;
}

// Console.Write("Введите длину массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
int[] currentArray = getRandomArray(5, 1, 10);
printArray(currentArray);
int[] result = newArray(currentArray);
printArray(result);
