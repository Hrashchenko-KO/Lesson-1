System.Console.Write("Введите число > ");

string inputString1 = Console.ReadLine();

int value1 = Convert.ToInt32(inputString1);

//System.Console.WriteLine(1);

for (int start = 1; start <= value1; start++)
{
    if (start % 2 == 0)
    {
        System.Console.WriteLine(start);
    }
}

// Неправильное условие задачи. Как мы можем выводить только четные числа начиная с 1, если 1 это нечетное число?
// Чтобы работало как в условии, раскомментируйте строку номер 7