// Задача: Написать программу, которая из сформированного массива строк содержащих символы 
// и числа создать массив из строк, в который попадут только символы, не являющиеця цифрами.

char[] collection = ("Зада4ча: Напи3сать програм23му, котор4ая").ToCharArray();
var result = string.Empty;
foreach(var item in collection)
{
if(!char.IsDigit(item))
result+= item;
}
Console.WriteLine(result);