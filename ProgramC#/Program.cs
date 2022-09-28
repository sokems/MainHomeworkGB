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

string[] array = {"hello", "12", "no", "butter", " "};
int size = NumberOfElementsUpToThreeInLength(array);
string[] newArray = SortArrayOfThreeCharacters(array, size);