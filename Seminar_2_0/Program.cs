// System.Console.WriteLine("Введите размер массива ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];

// int i = 0;
// while(i < size)
// {
//     System.Console.WriteLine("Элемент" + i + ": ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     i++;
// }

// i = 0;
// while(i<size)
// {
//     System.Console.WriteLine(array[i] + " ");
//     i++;
// } 

Console.Write("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
//Здесь вначале мы объявили массив array, который будет хранить данные типа int. Далее используя операцию new, мы выделили память для size элементов массива:
// new int[size]. Число 4 еще называется длиной массива. При таком определении все элементы получают значение по умолчанию, которое предусмотренно для их типа.
// Для типа int значение по умолчанию - 0.

for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0, 10);
}
// Заполнение случайными числами 

for(int i = 0; i < size; i++)
System.Console.Write(array[i] + " ");
// цикл ФОР для вывода в консоль значение заданных ранее