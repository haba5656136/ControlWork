// Написать программу, которая из имеющегося массива строк формирует массив из строк,длинна которых <= 3 символам


string[]array = {"dog","water","cat","123" , "586" , "11" ,"world"};

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+" ");
}
Console.WriteLine();
   
string[]newArray = array;

for (int j = 0; j < newArray.Length; j++)
{
    if (newArray[j].Length <= 3) 

        Console.Write(newArray[j]+" ");

}

