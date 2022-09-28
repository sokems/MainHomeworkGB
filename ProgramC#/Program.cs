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

string[] array = {"hello", "12", "no", "butter", " "};
int size = NumberOfElementsUpToThreeInLength(array);