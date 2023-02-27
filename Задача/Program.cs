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

Console.WriteLine("Введите строки массива через пробел");
string charInLine = Console.ReadLine();
string[] arrayOfLines = charInLine.Split(" ");