System.Console.Write("Введите первое число > ");

string inputString1 = Console.ReadLine();

System.Console.Write("Введите второе число > ");

string inputString2 = Console.ReadLine();

int value1 = Convert.ToInt32(inputString1);

int value2 = Convert.ToInt32(inputString2);

if (value1 > value2)

{
    
    System.Console.WriteLine($"{value1} больше чем {value2}");

}

else if (value1 < value2)

{
  
    System.Console.WriteLine($"{value1} меньше чем {value2}");

}

else 

{

    System.Console.WriteLine("Оба числа равны");

}