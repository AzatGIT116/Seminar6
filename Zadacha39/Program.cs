/* Задача 39: Напишите программу, которая перевернёт одномерный массив. */

 int[] GetArray(int size, int minValue, int mixValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, mixValue + 1);
    }
    return array;
}

//  Переливание 
void ReverseArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size / 2; i++)
    {
        int temp = array[i];
        array[i] = array[size - i - 1];
        array[size - i - 1] = temp;
    }
}

int[] ReverseArrayCopy(int[] array)
{
    int size = array.Length;
    int[] reverseArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        reverseArray[i] = array[size - i - 1];
    }
    return reverseArray;
}

int[] array = GetArray(10, 0, 20);
Console.WriteLine(string.Join(" ", array));

ReverseArray(array);

Console.WriteLine(string.Join(" ", array));

int[] reverseArray = ReverseArrayCopy(array);

Console.WriteLine(string.Join(" ", reverseArray)); 

//2
/* void Foo(int[] array)
{
    array[0] = 1000;
}

int[] arr = new int[1];
arr[0] = 2;

Foo(arr);
Console.WriteLine(arr[0]);
 */

