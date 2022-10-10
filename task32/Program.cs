/*
Задача 32: Напишите программу замены элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

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

int[] reverseArray(int[] incomingArray) // меняем положительные значения на отрицательные и наоборот
{
    for (int i = 0; i < incomingArray.Length; i++)
    {
        incomingArray[i] *= (-1); // меняем положительные значения на отрицательные и наоборот 
    }
    return incomingArray; // возвращаем получившийся массив
}
int[] currentArray = getRandomArray(12, -9, 9);
printArray(currentArray);
int [] reverse = reverseArray(currentArray);
printArray(reverse);
