System.Console.Write("Введите число > ");

string inputString1 = Console.ReadLine();

int value1 = Convert.ToInt32(inputString1);


if (value1 % 2 == 0)

{
    
    System.Console.WriteLine($"{value1} - четное число");

}

else 

{

    System.Console.WriteLine($"{value1} - нечетное число");

}