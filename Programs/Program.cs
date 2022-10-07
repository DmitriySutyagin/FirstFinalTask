Console.Clear();
Console.WriteLine("How many lines do you want to enter?");
int size = Convert.ToInt32(Console.ReadLine());
string b = "yes";
int count = 0;
int k = 0;
string?[] array = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Enter {i + 1} line");
    string? a = Console.ReadLine();
    array[i] = a;
    if (b.Length >= a.Length) count++;
    
}
Console.WriteLine();
Console.WriteLine('[' + string.Join(",", array) + ']');
string?[] arr = new string[count];
for (int j = 0; j < array.Length; j++)
{
    if (array[j]?.Length <= b.Length && k <= count)
    {
        arr[k] = array[j];  
        k++;
    }
}
Console.WriteLine('[' + string.Join(",", arr) + ']');