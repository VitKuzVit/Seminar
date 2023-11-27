int[] Array = new int [6] {1, 3, 2, 4, 2, 3};

int[] newArray = new int[3];

for (int i = 0; i < 3; i++)
{
    newArray[i] = Array[i] * Array[Array.Length-1-i];
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
PrintArray(newArray);