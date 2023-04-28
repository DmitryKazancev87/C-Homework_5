// 16. Программа, которая задаёт массив вещественных чисел
// и находит разницу между максимальным и минимальным элементом массива.

int EnterInfomation(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}
int LengthArray = EnterInfomation(" Введите длину массива : ");
double [] RandomArray=new double [LengthArray];
for (int i=0;i<RandomArray.Length;i++)
{
RandomArray[i]=new Random().Next(1,1000);
System.Console.Write(RandomArray[i]+" ");
}
double min=Int32.MaxValue;
double max=Int32.MinValue;
for (int j=0;j<RandomArray.Length; j++)
{
   if (RandomArray[j]> max)
   {
    max= RandomArray [j];
   }
   if (RandomArray[j]<min)
   {
    min=RandomArray[j];
   }   
}
System.Console.WriteLine($": всего {RandomArray.Length} чисел(а), максимальное значение = {max}, минимальное значение = {min}.");
System.Console.WriteLine($" Разница между максимальным и минимальным элементом массива = {max-min}.");