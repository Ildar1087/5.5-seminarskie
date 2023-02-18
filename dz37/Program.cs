// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6]-> 36 21


int Clear;
System.Console.WriteLine("Введите массив через пробел: ");
string massiv = Console.ReadLine();
int[] baseArray = GetBinArray(massiv);
System.Console.WriteLine(String.Join(" ", ResultArray(baseArray)));

int[] GetBinArray(string arrayString) // функция по переводу стороки в массив чисел
{
  string[] numbers = arrayString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
  int[] result = new int[numbers.Length];
  for (int i = 0; i < numbers.Length; i++)
  {
    result[i] = int.Parse(numbers[i]); /* */
  }
  return result;
}


int[] ResultArray(int[] array)  // функция по нахождению произведения пар
{
  int size = (array.Length + 1) / 2;  /* делаем не чётный массив чётным, чтобы 
  делился на 2 и мы получали парное количесто пар в массиве */
  
  int[] result = new int[size];   // создали новый массив, куда будем записывать результат
  for (int i = 0; i < array.Length / 2; i++)  /* запустили цикл до середины массива, 
  так как нам не зачем перебирать весь массив */
  {
    result[i] = array[i] * array[array.Length - 1 - i];  // выводим элементы массива по формуле в 2 прохода
  }
  if (array.Length % 2 == 1) result[size - 1] = array[array.Length / 2];  /* выводим элемент нечетного массива
  который находится по середине */
  return result;

}

