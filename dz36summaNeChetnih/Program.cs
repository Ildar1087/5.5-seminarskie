/* Задача 36: Задайте одномерный массив,
  заполненный случайными числами. Найдите 
  сумму элементов, стоящих на нечётных позициях. 

      [3, 7, 23, 12] -> 19

      [-4, -6, 89, 6]-> 0   */



System.Console.WriteLine("введите колличество элементов в массиве: ");
int size = int.Parse(Console.ReadLine());
int[] res = GetBinArray(size);
Console.WriteLine($"[{String.Join(", ", res)}]");     // вывод созданного массива
int summ = PrintArray(res);
Console.WriteLine($"[{String.Join(", ", summ)}]");;   // вывод суммы элементов, стоящих на нечётных позициях.


int[] GetBinArray(int size)     /* функция по созданию и заполнению случайными 
числами, и задаваемым количеством элементов в массиве */
{
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(0, 99); /* заполняем массив случайными числами */
  }
  return result;
}



int PrintArray(int[] col) // функция по поиску суммы нётных элементов массива
{
  int[] mas = col;      // Console.WriteLine($"[{String.Join(", ", mas)}]"); - проверка входящего массива
  
  int summa = 0;
  for (int j = 1; j < mas.Length; j = j + 2) // перебираем массив по нечётным индексам
  {
    summa += mas[j];     // суммируем в summ элементы стоящие на нечётных индексах
  }
  return summa;
}


