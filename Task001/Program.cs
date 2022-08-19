// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.WriteLine("Введите число a:");
string a = Console.ReadLine()!;
Console.WriteLine("Введите число b:");
string b = Console.ReadLine()!;

int numA = int.Parse(a);
int numB = int.Parse(b);

if(numB == 0)
{
    Console.WriteLine("1");
}
else if(numB == 1)
{
    Console.WriteLine(numA);
}
else
{
    int result = numA;
    void degreeThree () {
        for(int i = 1; i < numB; i++)
        {
            result = result * numA;
        }
    }
    degreeThree();
    Console.WriteLine(result);
}