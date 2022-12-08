int[] array = new int [8];
Random zxc = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = zxc.Next(1, 101);
    Console.Write($"{array[i]} ");
}
