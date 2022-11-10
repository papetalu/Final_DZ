// Написать программу, которая из имеющегося массива строк 
//формирует массив из строк, длина которых меньше либо равна 
//3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

Console.Clear();

void InputArray(string[] array1)
{
   for (int i = 0; i < array1.Length; i++)
   {
      Console.Write("Введите элемент и нажмите Enter: ");
      string x = Convert.ToString(Console.ReadLine());
      array1[i] = x;
   }

}

void SecondArray(string[] array1, string[] array2)
{
   int count = 0;
   for (int i = 0; i < array1.Length; i++)
   {
      if (array1[i].Length <= 3)
      {
         array2[count] = array1[i];
         count++;
      }
   }
}

void PrintArray(string[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($"{array[i]} ");
   }
   Console.WriteLine();
}

Console.Write("Cколько элементов массива будем вводить? ");
int m = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[m];
string[] array2 = new string[m];
Console.WriteLine(" ");
InputArray(array1);

Console.WriteLine(" ");
Console.Write("Новый массив: ");
Console.WriteLine(" ");
SecondArray(array1, array2);
PrintArray(array2);