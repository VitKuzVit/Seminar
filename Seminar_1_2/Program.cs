
// Console.WriteLine("number");
// double numberA = Convert.ToInt32(Console.ReadLine());
// double index = numberA;
// int count = 0;
// numberA = -numberA;
// while (count <= (index * 2))
// {
//     System.Console.WriteLine(numberA);
//     numberA++;
//     count++;
// }


Console.WriteLine("number");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
int I = -N;

while (I <= N)
{
    System.Console.WriteLine(I + " ");
    I++;
}
}
else
{
    System.Console.WriteLine("Введено не коректное значение");
}