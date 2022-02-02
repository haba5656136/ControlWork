// Написать программу, которая из имеющегося массива строк формирует массив из строк,длинна которых <= 3 символам


string[] array = { "dog", "water", "cat", "123", "586", "11", "world" };
string[] newArray = new string[array.Length];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        newArray[i] = array[i];
    Console.Write(newArray[i] + " ");
}