Console.Clear();

string[] firstArray = { "Съешь", "же", "уже", "этих", "французских", "булочек", "3", "100", "." };

int findCount(string[] array)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Count() <= 3)
            count++;
    }
    return count;
}

string[] createArray()
{
    string[] secondArray = new string[findCount(firstArray)];  //length = 5
    int order = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Count() <= 3)
        {
            secondArray[order] = firstArray[i];
            order++;
        }
    }
    return secondArray;
}

string[] secondArray = createArray();

void getArray(string[] array)
{
    foreach (string s in array)
    {
        Console.Write(s + " ");
    }
}
getArray(secondArray);
