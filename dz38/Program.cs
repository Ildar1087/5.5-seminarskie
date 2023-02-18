/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76  */


int size = 7;
int[] res = GetBinArray(size);
Console.WriteLine($"[{String.Join(", ", res)}]");     // вывод созданного массива
int minNumb = SelectionSortMin(res);
int maxNumb = SelectionSortMax(res);
Console.WriteLine($"[{String.Join(", ", maxNumb, minNumb, "разница равна:", maxNumb - minNumb)}]");


int[] GetBinArray(int size)     /* функция по созданию и заполнению массива случ. числами */
{
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(1, 99); /* заполняем массив случайными числами */
  }
  return result;
}



int SelectionSortMin(int[] array)      // функция по поиску наименьшего элемента массива
{
  int min = array[0];

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < min) min = array[i];        // проходим циклом и находим наименьший элемент 
  }
  return min;
}


int SelectionSortMax(int[] array)       // функция по поиску максимального элемента массива
{
  int max = array[0];

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > max) max = array[i];     // проходим циклом и находим наибольший элемент 
  }
  return max;
}
// int PrintArray(int[] col) // функция по поиску суммы нётных элементов массива
// {
//   int[] mas = col;      // Console.WriteLine($"[{String.Join(", ", mas)}]"); - проверка входящего массива

//   int summa = ;
//   for (int j = 1; j < mas.Length; j++) // перебираем массив по нечётным индексам
//   {
//     if (mas[j] > )     // суммируем в summ элементы стоящие на нечётных индексах
//   }
//   return summa;
// }