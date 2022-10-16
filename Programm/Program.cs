// Задача: Написать программу, которая из сформированного массива строк содержащих символы 
// и числа создать массив из строк, в который попадут только символы, не являющиеця цифрами.

char[] stroki = ("За03дача5: На8пи3сать про6грам3му, ко4тор4ая").ToCharArray();
var result = string.Empty;
foreach(var item in stroki)
{
if(!char.IsDigit(item))
result+= item;
}
Console.WriteLine(result);