int[] array = {16, 25, 41, 6, 72, 8, 35, 41};
int n = array.Length;
int find = 41;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}