// задайте массив из 12ти элементов , заполненными случайными числами в промежутке [-9; 9]
// найдите сумму отрицательных и положтиельных элементов массива.

Console.WriteLine();
int [] GetArray(int size, int minValue, int maxValue)
{
  int [] res = new int [size];
  for(int i = 0; i < size; i++)
}

int[] array = GetRandomArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array)//[1, 2, 3, 4, -5, 1, -3] el = -5
{
    positiveSum += el > 0 ? el : 0;//ps += -5 > 0? 2 : 0;
    negativeSum += el < 0 ? el : 0;
}
//  for (int i = 0;i < array.Length; i++){
//     int el = array[i];
    // if(el > 0)
    //     positiveSum += el;
    // if(el < 0)
    //     negativeSum += el;
// } 
Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} ");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}




Console.Clear();
int[] startArray = GetArray(6, -10, 10);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine(String.Join(" ", InversArray(startArray)));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] InversArray(int[] array){// [1, -2, 3, -4, 5] ->[-1,2,-3,4,-5]
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

32 задача 
Console.Clear();
int[] startArray = GetArray(6, -10, 10);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine(String.Join(" ", InversArray(startArray)));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] InversArray(int[] array){// [1, -2, 3, -4, 5] ->[-1,2,-3,4,-5]
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}




// задача 33 

// **Задача 33:** Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да




Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (FindElement(baseArray, n))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

bool FindElement(int[] array, int el)//[1,2,3,4] 5
{
    foreach (var item in array)//
    {
        if (el == item) // 5 == 4
            return true; 
    }
    return false;
}







