string[] stringsToWorkWith = {"Hello", "2", "world", ":-)"};

string[] ThreeOrLessDigitStrings(string[] stringsToWorkWith)
{   
    int findArrSize = 0;

    for (int i = 0; i < stringsToWorkWith.Length; i++)
    {
        if (stringsToWorkWith[i].Length <= 3)
            findArrSize++;
    }

    string[] resultArr = new string[findArrSize];
    int count = 0;

    for (int i = 0; i < stringsToWorkWith.Length; i++)       
        if (stringsToWorkWith[i].Length <= 3)
        {
            resultArr[count] = stringsToWorkWith[i];
            count++;    
        }            
        
    return resultArr;
}

void ShowArrayOne(string[] array)
{
    Console.Write("\nentered stings: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }

    Console.WriteLine();
}

void ShowArrayTwo(string[] array)
{
    Console.Write("\nsorted stings: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }

    Console.WriteLine();
}


ShowArrayOne(stringsToWorkWith);

ShowArrayTwo(ThreeOrLessDigitStrings(stringsToWorkWith));