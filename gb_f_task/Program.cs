// Написать программу, которая из имеющегося массива строк формирует массив из строк,длина которых меньше либо равно 3.
// Первоначальный массив можно ввести с клавиатуры,либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();
string[] array = {"hello", "2", "world", ":-)"};
// string[] array = {"1234", "1567", "-2", "computer science"};
int count = GetCountEl(array);
string[] resultArray = GetResultArray(array, count);

PrintArray(array);
Console.Write(" -> ");
PrintArray(resultArray);
Console.WriteLine();

int GetCountEl(string[] arr)
{
  int count = 0;
  
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i].Length <= 3)
    {
      count++;
    }
  }
  return count;
}

string[] GetResultArray(string[] array, int count)
{
  string[] resultArray = new string[count];
  int resArrayIndex = 0;
  
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      resultArray[resArrayIndex] = array[i];
      resArrayIndex++;
    }
  }
  return resultArray;
}

void PrintArray(string[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (i == 0) Console.Write("[");
    if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
    else Console.Write(arr[i] + "]");
  }
}