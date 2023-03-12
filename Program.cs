Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
if (A/100==0)
{
    Console.WriteLine("Третьей цифры нет!!!");
}
else
{
    string B = Convert.ToString(A);
    Console.WriteLine($"Третья цифра {B[2]}");
}