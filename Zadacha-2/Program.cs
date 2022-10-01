System.Console.Write("Введите первое число > ");

string inputString1 = Console.ReadLine();

System.Console.Write("Введите второе число > ");

string inputString2 = Console.ReadLine();

System.Console.Write("Введите третье число > ");

string inputString3 = Console.ReadLine();

int value1 = Convert.ToInt32(inputString1);

int value2 = Convert.ToInt32(inputString2);

int value3 = Convert.ToInt32(inputString3);

int max = value1;

if (value2 > value1)

{

    if (value2 > value3)
    
    {
        max = value2;
    }

    else 

    {
        max = value3;
    }

}

System.Console.WriteLine($"{max} - самое большое число");