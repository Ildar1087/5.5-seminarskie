// Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2]-> 0

// [10, 11, 12, 13, 14]-> 5


Console.Clear();
int[] array = GetBinArray(123, 0, 1000); // задаем функции количество и интервал значений массива
Console.WriteLine($"количество элементов в диапазоне [10, 100] = {FindNumber(array, 10, 99)}");


int[] GetBinArray(int size, int minchiclo, int maschiclo)
{
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(minchiclo, maschiclo); /* заполняем массив случайными числами,
    в заданом диапазоне от 10 до 99 включительно*/
  }
  return result;
}
Console.WriteLine($"[{String.Join(", ", array)}]");



int FindNumber(int[] array, int minNuber, int maxNumber) /* функция по поиску элементов в массиве,
 в заданном диапазоне */
{
  int count = 0;
  foreach (int mass in array) // присваиваем значение массива переменной mass
  {
    if (mass >= minNuber && mass <= maxNumber) /* осуществляем поиск значений в заданном 
    диапазоне значений массиве путём перебора массива */
    count++;
  }
  return count;
}

