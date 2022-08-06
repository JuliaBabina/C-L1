// Метод, который наполняет массив (изначально от создается с нулями), рандомными числами, collection - имя массива

void FillArray(int[] collection)
{

    int length = collection.Length;
    int index = 0;
    while (index < length)
    {

        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// Метод, который выводить массив на печать, col - имя массива

void PrintArray(int[] col)
{

    int count = col.Length;
    int position = 0;

    while (position < count)

    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find)

{

    int count = collection.Length;
    int index = 0;
    int position = -1; // не 0, чтобы при варианте, когда в массиве не будет искомого числа, выводил не 0, а -1, что можно интерпретировать, что такого нет
    while (index < count)

    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
}
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);


