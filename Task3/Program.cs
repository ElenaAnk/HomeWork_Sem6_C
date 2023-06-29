//Доп.Задача Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. (Решить можно, если хотите потренироваться)
//(Следующее число складывается из двух предыдущих)
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine()!);

int[] Fib(int N)
{
    int[] result = new int[N];
    int numb = 1;
    int sum = 0;
    for (int i = 0; i < N; i++)
    {
        result[i] = sum;
        int numbnext = sum + numb;
        numb = sum;
        sum = numbnext;
    }
    return result;
}

int[] Fibon = Fib(N);
Console.WriteLine($"{String.Join(" ", Fibon)}");
