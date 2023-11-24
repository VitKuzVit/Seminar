// Пригласили пользователя кл ввду


Console.Write("Ведите число ");
// int namber = int.Parse(Console.ReadLine());
int number = Convert.ToInt32(Console.ReadLine());

// Получили квадрат числа и записали его в переменную SQR
int sqr = number * number;

// Console.WriteLine(number + " -> " + sqr); вывод текста (подсказки) в терминал
System.Console.WriteLine($"{number} -> {sqr} текс текст");
