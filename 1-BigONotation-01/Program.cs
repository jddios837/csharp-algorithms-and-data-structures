// See https://aka.ms/new-console-template for more information

var normalString = "HelloWorld";
var reversedString = "";


for (int i = normalString.Length - 1; i >= 0; i--)
{
    reversedString += normalString[i];
}

Console.Write(reversedString);