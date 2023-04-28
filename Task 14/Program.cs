// 14. Программа, которая задаёт массив положительных трехзначных чисел
// и показывает количество четных чисел в массиве.

int EnterInfomation(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}
int LengthArray = EnterInfomation(" Введите длину массива : ");
int [] RandomArray=new int [LengthArray];
for (int i=0;i<RandomArray.Length;i++)
{
RandomArray[i]=new Random().Next(100,999);
    if (RandomArray[i]%2==0)
{
System.Console.Write($"четное число - {RandomArray[i]}, ");
}
}