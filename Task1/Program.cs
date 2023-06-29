//Создайте программу - Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int Enter(string mess)
{
    Console.Write(mess);
    string message= (Console.ReadLine()!);
    int res = Convert.ToInt32(message);
    return res;
}

int[] GetNumb(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine()!);
        result[i] = number;
    }

    return result;
}

int PosNumb(int[] collection)
{
    int count = 0;
    foreach (int el in collection)
    {
        count += el > 0 ? 1 : 0;
    }

    return count;
}

int[] array = GetNumb(Enter("Какое количество чисел будете вводить? Введите количество: "));
Console.WriteLine($"{String.Join(",", array)}");
Console.WriteLine($"{PosNumb(array)} чисел больше 0 введено пользователем");