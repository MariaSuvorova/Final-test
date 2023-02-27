/* Из введенного массива строк необходимо сформировать новый массив из строк,
длина которых меньше либо равна 3 символа */

int SorteredArrayLength(string[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string element = array[i];
        if (element.Length <= 3)
        {
            n+=1;
        }
    }
    return n;
}

string[] InitSorteredArray (int newArrayLength, string[] unsortedArray)
{
    string[] sorteredArray = new string[newArrayLength];
    int i = 0;
    while (i < newArrayLength)
    {
        for (int j = 0; j < unsortedArray.Length; j++)
        {
            string element = unsortedArray[j];
            if (element.Length <= 3)
            {
                sorteredArray[i] = unsortedArray[j];
                i++;
            }
        }
    }
    return sorteredArray;
}

Console.WriteLine("Введите строки массива через пробел");
string charInLine = Console.ReadLine();
string[] arrayOfLines = charInLine.Split(" ");
int n = SorteredArrayLength(arrayOfLines);
string[] resultArray = InitSorteredArray(n, arrayOfLines);
