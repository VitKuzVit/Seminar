int[] array = new int[10];
     int index = 0;
     while (index < 10)
    {
        array[index] = new Random().Next(1, 10);
        index++;
    }

for (int i = 0; i < 10; i++)
{
    array[i] = - array[i];
}

for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine(array[i] + " ");
}

