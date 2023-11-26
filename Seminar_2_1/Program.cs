int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
//Создали некую функцию считывания числа из консоли.

int[] GenerateArray(int size, int LeftRange, int rightRenge)
{
    int[] tempArray = new int[size];
    Random rend = new Random();

    for (int i = 0; i < size; i++)
    {
        tempArray[i] = rend.Next(LeftRange, rightRenge + 1);
    }
    return tempArray;
}
// Создали некую функцию GenerateArray которая создает массив с параметрами: размер левая сторона правая сторона.
// В нутри функции создается временный массив tempAraay размером size 
// и наполняется случайными числами с помощью цикла FOR в диапазоне переменных LeftRange, rightRenge.

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
// Функция void с названием PrinArray выводит на экран некий Массив

// Основной код
int size = ReadInt("Введите размер массива ");
// задаем значение переменной size обращаясь к функции ReadInt
int[] myArray = GenerateArray(size, -10, 10);
// Создаем массив с имененм myArray размером size, внутри наполненным значением целых чисел от -10 до +10.
PrintArray(myArray);