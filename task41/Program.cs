/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3 */

//метод преобразования массива с испольованием функции split
int[] ConvertArray(string arrayStr)
{
    string [] array = arrayStr.Split(",");
    int[] numArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        numArray[i] = Convert.ToInt32(array[i]);
    }
    return numArray;
}

//метод поиска и подсчета положительных чисел
int FindPositiveNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)count++;
    }
    return count;
}



//команда для ввода массива
Console.WriteLine("Введите массив чисел отделяя каждую цифру запятой без пробелов:");
//в переменную arrayStr передаем введенные числа
string arrayStr = Console.ReadLine()??"";
// преобразовываем массив с использованием метода ConvertArray
int[] result = ConvertArray(arrayStr);
int countPositiveNumber = FindPositiveNumber(result);
Console.WriteLine("Количество чисел больше нуля:  " + countPositiveNumber);


