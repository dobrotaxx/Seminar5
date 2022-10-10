/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int getNumberFromUser(string userInformation)//берем данные от пользователя и обрабатываем их
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);//пишем пользователю сообщение
        string userLine = Console.ReadLine();//представляем данные от пользователя строковым типом
        int.TryParse(userLine, out result);//парсим строковые данные от пользователя в как int-овые в result
        if (result == 0 && userLine != "0")//если данные не равны 0 и result до сих пор 0...
        {
            Console.WriteLine($"Ошибка ввода! Введите целое число: [{userLine}].");//печатаем это
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

int findElements(int[] incomingArray, int startPoint, int endPoint)//ищем элементы в определенном диапазоне внутри массива
{
    int result = 0;
    for (int i = 0; i < incomingArray.Length; i++)//перебор массива
    {
        if (incomingArray[i] > startPoint && incomingArray[i] < endPoint)
        {
            result += 1;
        }
    }
    return result;
}

int quantityElements = getNumberFromUser("Задайте количество элементов в массиве: ");
int[] currentArray = getRandomArray(quantityElements, -99, 199);//присваиваем переменной сгенерированный массив
printArray(currentArray);//печатаем массив
int result = findElements(currentArray, 10, 99);//ищем в массиве числа в диапазаоне от 10 до 99
Console.WriteLine($"Количество элементов в массиве в диапазоне от 10 до 99 = {result}");

