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


int[] array = new int[10];
FillArray(array);
PrintArray(array);
