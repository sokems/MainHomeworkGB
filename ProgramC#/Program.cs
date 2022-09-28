int NumberOfElementsUpToThreeInLength(string[] array)
{
    int current = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
            current++;
    }

    return current;
}

string[] SortArrayOfThreeCharacters(string[] array, int size)
{
    string[] sortArray = new string[size];
    int index = 0;
    
    for(int j = 0; j < size; j++)
        for(int i = index; i < array.Length; i++)
            if(array[i].Length <= 3)
            {
                index = i + 1;
                sortArray[j] = array[i];
                break;
            }
    return sortArray;
}

void ShowArray(string[] array)
{
    int size = array.Length;

    for(int i = 0; i < size; i++)
    {
        if(i == 0) Console.Write($"[{array[i]}, ");
        if((i > 0) && (i < size - 1)) Console.Write($"{array[i]}, ");
        if(i == size - 1) Console.Write($"{array[i]}]");
    }
}

string[] array = {"hello", "12", "no", "butter", " ", "123"};
int size = NumberOfElementsUpToThreeInLength(array);
string[] newArray = SortArrayOfThreeCharacters(array, size);

ShowArray(array);
Console.Write(" -> ");
ShowArray(newArray);