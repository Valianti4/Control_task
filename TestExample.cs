/* Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.Write("Введите количество строк: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[size];
string[] array2 = new string[size];

string[] CreateArray1(string[] args)
{
    for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine("Чтобы составить элемент массива, введите строку №{0}:", i + 1);
            array1[i] = Console.ReadLine();
        }
        return array1;    
}
// Console.WriteLine();

void PrintArray1(string[] array1)
{
    Console.Write("Вывод массива: [");
    for (int i = 0; i < array1.Length; i++)
        {
            if (i < array1.Length-1) Console.Write($"\"{array1[i]}\", ");
            else Console.Write($"\"{array1[i]}\"");
        }
    Console.Write("]");
}
// Console.WriteLine();

// var newarray = array.Where(x => x.Length <= 3).ToArray();
/* void ResultArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}*/

string[] CreateArray2(string[] args)
{
    int length = 3;
    int element = 0;

    for (int j = 0; j < size; j++)
    {
        if (array1[j].Length <= length)
        {
            array2[element] = array1[j];
            element++;
        }
    }
    return array2;   
}

void PrintArray2(string[] array2)
{
    Console.Write("Нужный массив: [");
    for (int i = 0; i < array2.Length; i++)
    { 
        if (i < array2.Length-1) Console.Write($"\"{array2[i]}\", ");
        else Console.Write($"{array2[i]}");                                                  
    }
    Console.Write("]");
}
CreateArray1(array1);
PrintArray1(array1);
CreateArray2(array2);
PrintArray2(array2);