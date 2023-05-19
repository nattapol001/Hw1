using System;
public class Program
{
    public static void Main()
{
int i = int.Parse(Console.ReadLine());

while (i < 0){
    Console.WriteLine("Invalid triangle row num.");
    i = int.Parse(Console.ReadLine());
}
for (int row = 0; row < i+1; row++){
    int num = 1;
    for (int col = 0; col <= row; col++){

    {
    Console.Write(num + " ");
    num = num * (row - col) / (col + 1);
}
Console.WriteLine();
}
}
}
}