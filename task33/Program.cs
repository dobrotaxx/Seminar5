/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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

void findNumber(int[] incomingArray, int number) //ищем число в массиве
{
    int result = 0;
    for (int i = 0; i < incomingArray.Length; i++)//перебор массива
    {
        if (number == incomingArray[i]) // если нужное число равно какому-то элементу массива 
        {
            result = 1; // то result равно 1
            break;// и прерываем дальнейший поиск
        }
        else//иначе
        {
            result = 0;// result равен 0
        }
    }
    if (result > 0) //если result больше нуля, то
    {
        Console.WriteLine("Да");// печатаем "Да"
    }
    else
    {
        Console.WriteLine("Нет");// если не равен нулю, то печатаем "Нет"
    }
}

int[] array = getRandomArray(5, -10, 99);//Кладем в переменную массив длиной 5 элементов с рандомными значениями от -10 до 99
printArray(array);//печатаем массив
findNumber(array, 9);//Печатаем результат поиска девятки внутри массива без принудительного добавления элемента
