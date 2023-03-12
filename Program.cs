Console.Write("Введите цифру, обозначающую день недели: ");
int A = int.Parse(Console.ReadLine()!);
switch (A)
{
    case 1:
    {Console.WriteLine("Рабочий");
    break;}
    
    case 2:
    {Console.WriteLine("Рабочий");
    break;}
    
    case 3:
    {Console.WriteLine("Рабочий");
    break;}
    
    case 4:
    {Console.WriteLine("Рабочий");
    break;}

    case 5:
    {Console.WriteLine("Рабочий");
    break;}

    case 6:
    {Console.WriteLine("Выходной");
    break;}

    case 7:
    {Console.WriteLine("Выходной");
    break;}

    default:
    {Console.WriteLine("Нет такого дня!!!!");
    break;}
    
}