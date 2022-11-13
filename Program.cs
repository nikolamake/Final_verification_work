string[] massiv1 = { "Hello", "2", "world", ":-)"};

string[] massiv2 = { "1234", "1567", "-2", "computer science"};

string[] massiv3 = { "Russia", "Denmark", "Kazan"};

Console.WriteLine("Исходный введённый массив: [ " + String.Join(", ", massiv1) + " ]");

Console.WriteLine("Массив с длиной строк меньше или равной 3: [ " + String.Join(", ", SortingArray(massiv1)) + " ]");

string[] SortingArray(string[] sourceArray)    
{
int count = 0;

for (int i = 0; i < sourceArray.Length; i++)
{
    if (sourceArray[i].Length <=3) count++;
}

string[] filteredMassiv = new string[count];
int quantity = 0;
for (int i = 0; i < sourceArray.Length; i++)
{
    
    if (sourceArray[i].Length <=3)
    {
        filteredMassiv[quantity] = sourceArray[i];
        quantity++;
    }
}
return filteredMassiv;
}

