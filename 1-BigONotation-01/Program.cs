// See https://aka.ms/new-console-template for more information

var normalString = "HelloWorld";
var reversedString = "";


for (int i = normalString.Length - 1; i >= 0; i--)
{
    reversedString += normalString[i];
}

Console.WriteLine(reversedString);
Console.WriteLine(addUpToFirst(100));
Console.WriteLine(addUpToSecond(100));

int addUpToFirst(int n)
{
    int total = 0;

    for (int i = 1; i <= n; i++)
    {
        total += i;
    }
    
    return total;
}

int addUpToSecond(int n)
{
    return n * (n + 1) / 2;
}