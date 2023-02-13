Console.Clear();
void GetShortStringArray(int nsize)
{
    string[] stringArray = new string[nsize];
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Enter the {i + 1} string:");
        stringArray[i] = Console.ReadLine();
        if (stringArray[i].Length < 4)
            count++;
    }
    string[] newStringArray = new string[count];
    count = 0;

    for (int j = 0; j < stringArray.Length; j++)
    {
        if (stringArray[j].Length < 4)
        {
            newStringArray[count] = stringArray[j];
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine("This is short string array.");
    for (int f = 0; f < newStringArray.Length; f++)
    {
        Console.WriteLine($"{f + 1}. {newStringArray[f]}");
        Console.WriteLine();
    }
}
Console.WriteLine("Enter the size yours array:");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("**************************************");
GetShortStringArray(size);