int num1 = 9;
int num2 = 17;
int max = 0;
int min = 0;
if (num1 > num2)
{
    max = num1;
    min = num2;
}
else
{
    max = num2;
    min = num1;
}
Console.WriteLine("Min = " + min);
Console.WriteLine("Max = " + max);

