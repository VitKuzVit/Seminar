double[] array = new double[5];
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
}

System.Console.WriteLine(string.Join(" ", array));