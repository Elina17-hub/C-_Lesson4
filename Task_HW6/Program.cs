//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,]charArray = new char[,]
{
    {'a','1','c'},
    {'d','e','F'}
};
string result = " ";
for (int i = 0; i < charArray.GetLength(0); i++)
{
 for (int j = 0; j < charArray.GetLength(1); j++)
 {
    result += charArray[i,j];
 }   
}
Console.WriteLine(result);

//Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string originalString = "HeLLO WorLD";
string LowerCaseString = originalString.ToLower();
Console.WriteLine(LowerCaseString);

//Задайте произвольную строку. Выясните, является ли она палиндромом.

string str = "МАШИНА";
bool isPolindrome = true;
for (int i = 0; i < str.Length / 2; i++)
{
    if (str[i] != str[str.Length - 1 - i])
    {
        isPolindrome = false;
        break;
    }
}
if (isPolindrome)
{
    Console.WriteLine($"{str} является полиндромом");
}
   else
{
 Console.WriteLine($"{str} не является полиндромом");   
}


  