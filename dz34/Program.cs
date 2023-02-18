/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.

[345, 897, 568, 234] -> 2   */



// Console.WriteLine("введите колличество элементов в массиве: ");
int size = 6;
int[] res = GetBinArray(size);
Console.WriteLine($"[{String.Join(", ", res)}]");     // вывод созданного массива
int summ = PrintArray(res);
Console.WriteLine($"[{String.Join(", ", summ)}]"); ;


int[] GetBinArray(int size)     /* функция по созданию и заполнению случайными 
числами, и задаваемым количеством элементов в массиве */
{
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(100, 999); /* заполняем массив случайными числами */
  }
  return result;
}

int PrintArray(int[] col) // функция по поиску количествa чётных чисел в массиве.
{
  int[] mas = col;      // Console.WriteLine($"[{String.Join(", ", mas)}]"); - проверка входящего массива

  int count = 0;
  int chet = 0;
  for (int j = 0; j < mas.Length; j++) // перебираем массив 
  {
    if (mas[j] % 2 == 0)    // перебираем массив путём деления на 2
    {
      count++;
    }
  }
  return count;
}