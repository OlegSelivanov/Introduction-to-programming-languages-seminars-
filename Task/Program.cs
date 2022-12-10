/*
// Task 19 Новое решение для любых чисел

Console.Clear();

Console.Write("Введите число: ");
string? number = Console.ReadLine();
int count = number.Length - 1;
double newNumber = 0;
for (int i = count; i >= 0; i--)
{
    newNumber = newNumber + int.Parse(number[i].ToString()) * Math.Pow(10, i);
}

Console.WriteLine(number == newNumber.ToString());


/* Task dop. 
Второй максимум
(Время: 1 сек. Память: 16 Мб Сложность: 16%)
Задана последовательность натуральных чисел, завершающаяся числом 0. Требуется определить значение второго 
по величине элемента в этой последовательности, то есть элемента, который будет наибольшим, 
если из последовательности удалить наибольший элемент.

Входные данные
Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел, не превышающих значения 100. 
Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0, 
перед которым идет как минимум 2 элемента.

Выходные данные
В выходной файл OUTPUT.TXT выведите целое число – значение второго максимума.
*/

/*
Console.Clear();
int n = int.Parse(Console.ReadLine());
int maxFirst = n, maxSecond = -1;
while (n != 0)
{
    n = int.Parse(Console.ReadLine());
    if (maxFirst < n)
    {
        maxSecond = maxFirst;
        maxFirst = n;
    }
    else if (maxSecond < n)
        maxSecond = n;
}
Console.WriteLine(maxSecond);

// Вывод чисел в одну строку
Console.Clear();
string[] array = Console.ReadLine().Split(" ");
int n = int.Parse(array[0]);
int m = int.Parse(array[1]);
Console.WriteLine(n + m);

/* Tsk dop 2 
В фермерском хозяйстве в Карелии выращивают чернику. Она растет на круглой грядке, 
причем кусты высажены только по окружности. Таким образом, у каждого куста есть ровно 
два соседних. Всего на грядке растет N кустов.

Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло различное 
число ягод – на i-ом кусте выросло ai ягод.

В этом фермерском хозяйстве внедрена система автоматического сбора черники. Эта система 
состоит из управляющего модуля и нескольких собирающих модулей. Собирающий модуль за один заход, 
находясь непосредственно перед некоторым кустом, собирает ягоды с этого куста и с двух соседних с ним.

Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход 
собирающий модуль, находясь перед некоторым кустом заданной во входном файле грядки.

Входные данные
Первая строка входного файла INPUT.TXT содержит целое число N (3 ≤ N ≤ 1000) – количество кустов черники. 
Вторая строка содержит N целых положительных чисел a1, a2, ..., aN – число ягод черники, 
растущее на соответствующем кусте. Все ai не превосходят 1000.

Выходные данные
В выходной файл OUTPUT.TXT выведите ответ на задачу.
*/

/*
Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
string[] input = Console.ReadLine().Split(" ");
for (int i = 0; i < input.Length; i++)
    array[i] = int.Parse(input[i].ToString());

int maxSumma = 0;
for (int i = 1; i < array.Length - 1; i++)
{
    int sum = array[i - 1] + array[i] + array[i + 1];
    if (sum > maxSumma)
        maxSumma = sum;
}
if (array[0] + array[1] + array[array.Length - 1] > maxSumma)
    maxSumma = array[0] + array[1] + array[array.Length - 1];

if (array[array.Length - 1] + array[array.Length - 2] + array[0] > maxSumma)
    maxSumma = array[array.Length - 1] + array[array.Length - 2] + array[0];

Console.WriteLine(maxSumma);

// Array

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]

Console.WriteLine($"[{string.Join(", ", array)}]");

// Function. Void

int f(int a, int b)
{
    if (a > b)
        return a;
    return b;
}

// return возвращает значение либо в консоль, либо в переменную
// return завершает работу функции
// Сколько аргументов мы передаем, столько и принимаем. НО!!!
Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a, b));

// Void - процедура
// Void

void f(ref int a)
{
    a += 5;
}


Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
f(ref a);
Console.WriteLine(a);


// task 24

Console.Clear();
Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((1 + n) / 2 * n);
*/

/*Задача 26: 
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Clear();


/*
// task 28


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), res = 1;
for (int i = 2; i <= n; i++ )
    res *= i;

Console.WriteLine(res);
*/

// Задача 30

Console.Clear();
int n = 8;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 2); // [1, 10]

Console.WriteLine($"[{string.Join(", ", array)}]");