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
int s = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[s];

string[] CreateArray1(string[] args)
{
    for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine("Чтобы составить элемент массива, введите строку №{0}:", i + 1);
            array1[i] = Console.ReadLine();
        }
        Console.WriteLine();
        return array1;        
}

void PrintArray(string[] array)
{
    Console.Write("Вывод массива: [");
    for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length-1) Console.Write($"\"{array[i]}\", ");
            else Console.Write($"\"{array[i]}\"");
        }
    Console.Write("]");
    Console.WriteLine();
}

string[] CreateArray2(string[] args)
{
    int size = 0;
    int length = 3;
    for (int i = 0; i < args.Length; i++)
    {
        if(args[i].Length <= length) size++;
    }

    string[] array = new string[size];
    int j = 0;

    for (int i = 0; i < args.Length; i++)
    {
        if(args[i].Length <= length)
        {
            array[j] = args[i];
            j++;
        }
    }
    return array;   
}

CreateArray1(array1);
PrintArray(array1);
string[] array2 = CreateArray2(array1);
PrintArray(array2);