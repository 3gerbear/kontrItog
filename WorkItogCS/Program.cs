
int iterCheckLength = 0;

Console.Write("Введите количество строк в массиве: ");
int quantityStr = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество символов в строке для выборки: ");
int LengthString = int.Parse(Console.ReadLine()!);

string[] arrString = new string[quantityStr];
int[] arrNumberStrLen = new int[quantityStr];

for (int numStr = 1; numStr < quantityStr + 1; numStr++)
{
    Console.Write($"Введите строку {numStr}: ");
    arrString[numStr - 1] = Console.ReadLine()!;
}

for (int numStr = 0; numStr < quantityStr; numStr++)
{
    if (arrString[numStr].Length <= LengthString)
    {
        arrNumberStrLen[iterCheckLength] = numStr;
        iterCheckLength++;
    }
}

Console.Write("[ ");
for (int numStr = 0; numStr < quantityStr; numStr++)
{
    Console.Write($"\"{arrString[numStr]}\"");
    if (numStr < quantityStr - 1) Console.Write(", ");
}
Console.Write(" ] --> ");

string[] arrStrLen = new string[iterCheckLength + 1];

Console.Write("[ ");
for (int numStr = 0; numStr < iterCheckLength; numStr++)
{
    arrStrLen[numStr] = arrString[arrNumberStrLen[numStr]];
    Console.Write($"\"{arrStrLen[numStr]}\"");
    if (numStr < iterCheckLength - 1) Console.Write(", ");
}
Console.Write(" ]");