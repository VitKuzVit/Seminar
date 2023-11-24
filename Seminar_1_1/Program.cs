
Console.WriteLine("введите число1 ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число2 ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

if(FirstNumber == SecondNumber * SecondNumber)
{
    System.Console.WriteLine($"a = {FirstNumber}, b = {SecondNumber} -> Да");
}
else
{   
    System.Console.WriteLine($"a = {FirstNumber}, b = {SecondNumber} -> Нет");
}

// = -Присвоить значение
// == - Сравнение