// 15. Программа, которая задаёт одномерный массив заполненный случайными числами
// и показывает сумму элементов стоящих на нечетных позициях.

int EnterInfomation(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}
int LengthArray = EnterInfomation(" Введите длину массива : ");
int [] RandomArray=new int [LengthArray];
for (int i=0;i<RandomArray.Length;i++)
{
RandomArray[i]=new Random().Next(1,1000);
System.Console.Write("["+RandomArray[i]+"]");
}
int SumArray=0;
for (int j=0;j<RandomArray.Length; j+=2)
{
    SumArray=SumArray+RandomArray[j];    
}
System.Console.Write($": всего {RandomArray.Length} чисел, сумма элементов на нечетных позициях = {SumArray}");