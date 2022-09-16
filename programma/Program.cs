// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array;
array = new string[] { "r", "w", "kkt", "kookmkm8", "5465642", "45" };

void PrintArray(string[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    if (i == arr.Length - 1) Console.Write(arr[i]);
    else Console.Write(arr[i] + "; ");
  }
  Console.Write("]");
}

string [] FindChar(string[] array)
{
int size = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i].Length <= 3) size++;
}
string[] arr2 = new string[size];

int j = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i].Length <= 3)
  {
    arr2[j] = array[i];
    j++;
  }
}
return arr2;
}
PrintArray(array);
string[] arr2 = FindChar(array);
Console.Write("-->");
PrintArray(arr2);